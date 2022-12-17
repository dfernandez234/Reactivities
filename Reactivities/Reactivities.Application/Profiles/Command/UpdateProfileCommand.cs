using Application.Core;
using MediatR;
using Reactivities.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Profiles.Command
{
    public record UpdateProfileCommand(
        UpdateProfile Update):IRequest<ServiceResponse<Unit>>;
}
