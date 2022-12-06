using Application.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities.Commands.Delete
{
    public record ActivityDeleteCommand(
        Guid Id
        ):IRequest<ServiceResponse<Unit>>;
}
