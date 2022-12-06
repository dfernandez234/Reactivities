using FluentValidation;
using Reactivities.Contracts.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities.Commands.Edit
{
    public class ActivityEditCommandValidator : AbstractValidator<ActivityEditCommand>
    {
        public ActivityEditCommandValidator() 
        {
            RuleFor(x => x.EditRequest.Title).NotEmpty();
            RuleFor(x => x.EditRequest.Date).NotEmpty();
            RuleFor(x => x.EditRequest.Description).NotEmpty();
            RuleFor(x => x.EditRequest.Venue).NotEmpty();
            RuleFor(x => x.EditRequest.City).NotEmpty();
            RuleFor(x => x.EditRequest.Category).NotEmpty();
        }  
    }
}
