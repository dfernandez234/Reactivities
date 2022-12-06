using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities.Commands.Create
{
    public class ActivityCreateCommandValidator : AbstractValidator<ActivityCreateCommand>
    {
        public ActivityCreateCommandValidator() 
        {
            RuleFor(x => x.CreateRequest.Title).NotEmpty();
            RuleFor(x => x.CreateRequest.Date).NotEmpty();
            RuleFor(x => x.CreateRequest.Category).NotEmpty();
            RuleFor(x => x.CreateRequest.City).NotEmpty();
            RuleFor(x => x.CreateRequest.Venue).NotEmpty();
            RuleFor(x => x.CreateRequest.Description).NotEmpty();
        }
    }
}
