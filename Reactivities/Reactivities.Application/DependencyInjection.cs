using FluentResults;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Reactivities.Application.Activities.Commands.Create;
using Reactivities.Application.Activities.Commands.Edit;
using Reactivities.Application.Common.Behaviors;
using Reactivities.Application.Photos.Commands.Add;
using Reactivities.Application.Profiles.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Reactivities.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        {
            services.AddMediatR(typeof(DependencyInjection).Assembly);
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidateBehavior<,>));

            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddScoped<IValidator<ActivityCreateCommand>, ActivityCreateCommandValidator>();
            services.AddScoped<IValidator<ActivityEditCommand>, ActivityEditCommandValidator>();
            services.AddScoped<IValidator<AddPhoto.Command>, AddPhotoCommandValidator>();
            services.AddScoped<IValidator<UpdateProfileCommand>, UpdateProfileCommandValidator>();

            return services;
        }
    }
}
