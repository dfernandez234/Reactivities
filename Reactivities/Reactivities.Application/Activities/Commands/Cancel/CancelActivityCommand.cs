using Application.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities.Commands.Cancel
{
    public record CancelActivityCommand(
        string Id):IRequest<ServiceResponse<Unit>>;
}
