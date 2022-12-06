using Azure;
using FluentResults;
using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reactivities.API.Middleware;
using System.Diagnostics;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Reactivities.API.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _env;

        public ErrorHandlingMiddleware(RequestDelegate next, IWebHostEnvironment env)
        {
            _next = next;
            _env = env; 
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (ValidationException ex)
            {
                await HandleValidationExceptionAsync(httpContext, ex);
            }
            catch (Exception ex)
            {
                await HanddleExceptionAsync(httpContext, ex, _env);
            }
        }

        private static Task HandleValidationExceptionAsync(HttpContext context, ValidationException exception)
        {
            var problemDetails = GetBadRequestValidationProblemDetails(exception);
            var response = context.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return context.Response.WriteAsync(JsonSerializer.Serialize(problemDetails));
        }


        private static Task HanddleExceptionAsync(HttpContext context, Exception exception, IWebHostEnvironment env)
        {

            var response = context.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int)HttpStatusCode.InternalServerError;
            ProblemDetails problemDetails = GetProblemDetails(exception, env);

            return context.Response.WriteAsync(JsonSerializer.Serialize(problemDetails));
        }

        private static ProblemDetails GetProblemDetails(Exception ex, IWebHostEnvironment env)
        {
            string traceId = Guid.NewGuid().ToString();

            if (env.EnvironmentName == "Development")
            {
                return new ProblemDetails
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Type = "https://httpstatuses.com/500",
                    Title = ex.Message,
                    Detail = ex.ToString(),
                    Instance = traceId
                };
            }
            else
            {
                return new ProblemDetails
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Type = "https://httpstatuses.com/500",
                    Title = "Something went wrong. Please try after some time",
                    Detail = @"We apologize for inconvenience. Please let us know about the error at support@orion.com. Include traceId: {traceId} in email",
                    Instance = traceId
                };
            }
        }

        private static ValidationProblemDetails GetBadRequestValidationProblemDetails(ValidationException ex)
        {
            string traceId = Guid.NewGuid().ToString();

            var errors = new Dictionary<string, string[]>();
            foreach (var error in ex.Errors)
            {
                errors.Add(error.PropertyName, new string[] { error.ErrorMessage });
            }

            var validationProblemDetails = new ValidationProblemDetails(errors);

            validationProblemDetails.Status = (int)HttpStatusCode.BadRequest;
            validationProblemDetails.Type = "https://httpstatuses.com/400";
            validationProblemDetails.Title = "Validation failed";
            validationProblemDetails.Detail = "One or more inputs need to be corrected. Check errors for details";
            validationProblemDetails.Instance = traceId;

            return validationProblemDetails;
        }
    }

// Extension method used to add the middleware to the HTTP request pipeline.
public static class ErrorHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}
