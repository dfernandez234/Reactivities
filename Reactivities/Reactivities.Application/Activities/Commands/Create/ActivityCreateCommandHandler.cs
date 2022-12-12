using Application.Core;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Interfaces;
using Reactivities.Domain.Entities;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities.Commands.Create
{
    public class ActivityCreateCommandHandler : IRequestHandler<ActivityCreateCommand, ServiceResponse<Unit>>
    {
        private ApplicationDbContext context;
        private IMapper mapper;
        private readonly IUserAccessor userAccessor;

        public ActivityCreateCommandHandler(ApplicationDbContext context, IMapper mapper, IUserAccessor userAccessor)
        {
            this.context = context;
            this.mapper = mapper;
            this.userAccessor = userAccessor;
        }

        async Task<ServiceResponse<Unit>> IRequestHandler<ActivityCreateCommand, ServiceResponse<Unit>>.Handle(ActivityCreateCommand request, CancellationToken cancellationToken)
        {
            var user = await context.Users.FirstOrDefaultAsync(x =>
            x.Email == userAccessor.GetUsername());

            var activity = mapper.Map<Activity>(request.CreateRequest);

            var attendee = new ActivityAttendee
            {
                AppUser = user,
                Activity = activity,
                IsHost = true,
            };
            
            activity.Attendees.Add(attendee);
            context.Activities.Add(activity);

            var result = await context.SaveChangesAsync() > 0;

            if (!result) return ServiceResponse<Unit>.Failure("Failed to create activity");

            return ServiceResponse<Unit>.Success(Unit.Value);
        }
    }
}
