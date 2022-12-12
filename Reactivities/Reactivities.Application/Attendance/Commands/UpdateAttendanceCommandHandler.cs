using Application.Core;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Activities.Commands.Create;
using Reactivities.Application.Interfaces;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Attendance.Commands
{
    public class UpdateAttendanceCommandHandler : IRequestHandler<UpdateAttendanceCommand, ServiceResponse<Unit>>
    {
        private ApplicationDbContext context;
        private IMapper mapper;
        private readonly IUserAccessor userAccessor;

        public UpdateAttendanceCommandHandler(ApplicationDbContext context, IMapper mapper, IUserAccessor userAccessor)
        {
            this.context = context;
            this.mapper = mapper;
            this.userAccessor = userAccessor;
        }

        async Task<ServiceResponse<Unit>> IRequestHandler<UpdateAttendanceCommand, ServiceResponse<Unit>>.Handle(UpdateAttendanceCommand request, CancellationToken cancellationToken)
        {
            var activity =await context.Activities
                .Include(a => a.Attendees).ThenInclude(u => u.AppUser)
                .SingleOrDefaultAsync(x => x.ActivityId == request.Id);

            if (activity == null) return null;

            var user = await context.Users.FirstOrDefaultAsync(u => u.Email == userAccessor.GetUsername());
            if (user == null) return null;

            var hostName = activity.Attendees.FirstOrDefault(x => x.IsHost)?.AppUser?.UserName;
            var attendance = activity.Attendees.FirstOrDefault(x => x.AppUser.UserName == user.UserName);

            if(attendance != null && hostName == user.UserName)
                activity.IsCancelled = !activity.IsCancelled;

            if(attendance != null && hostName != user.UserName)
                activity.Attendees.Remove(attendance);

            if(attendance == null)
            {
                attendance = new Domain.Entities.ActivityAttendee
                {
                    AppUser = user,
                    Activity = activity,
                    IsHost = false
                };

                activity.Attendees.Add(attendance);
            }

            var result = await context.SaveChangesAsync() > 0;

            return result ? ServiceResponse<Unit>.Success(Unit.Value) : ServiceResponse<Unit>.Failure("Problem updating Activity");
        }
    }
}
