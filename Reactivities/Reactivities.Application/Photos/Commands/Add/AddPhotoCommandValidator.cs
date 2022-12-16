using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Photos.Commands.Add
{
    internal class AddPhotoCommandValidator : AbstractValidator<AddPhoto.Command>
    {
        public AddPhotoCommandValidator() {
            RuleFor(x => x.File);
        }
    }
}
