using Application.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Attendance.Commands
{
    public record UpdateAttendanceCommand(
        string Id
    ) : IRequest<ServiceResponse<Unit>>;
}
