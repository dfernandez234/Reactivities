using Application.Core;
using MediatR;
using Reactivities.Contracts.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities.Commands.Create
{
    public record ActivityCreateCommand(
        CreateRequest CreateRequest
        ):IRequest<ServiceResponse<Unit>>;
}
