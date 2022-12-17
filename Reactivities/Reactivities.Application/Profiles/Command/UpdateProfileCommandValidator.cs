using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Profiles.Command
{
    public class UpdateProfileCommandValidator : AbstractValidator<UpdateProfileCommand>
    {
        public UpdateProfileCommandValidator() { 
            RuleFor(x => x.Update.DisplayName).NotEmpty();
            RuleFor(x => x.Update.Bio).NotEmpty();
        }
    }
}
