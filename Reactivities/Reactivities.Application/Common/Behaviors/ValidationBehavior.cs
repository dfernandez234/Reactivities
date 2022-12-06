using Application.Core;
using FluentResults;
using FluentValidation;
using MediatR;
using ValidationException = FluentValidation.ValidationException;

namespace Reactivities.Application.Common.Behaviors
{
    public class ValidateBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> 
        where TRequest : IRequest<TResponse>
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;

        public ValidateBehavior(IEnumerable<IValidator<TRequest>> validators)
        {
            _validators = validators;
        }

        Task<TResponse> IPipelineBehavior<TRequest, TResponse>.Handle(
            TRequest request, 
            RequestHandlerDelegate<TResponse> next, 
            CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);
            var failures = _validators.Select(v => v.Validate(context)).SelectMany(v => v.Errors).Where(v => v != null).ToList();

            if (failures.Any())
            {
                throw new ValidationException(failures);
            }

            return next();
        }
    }
}
