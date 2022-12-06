using Application.Core;
using AutoMapper;
using MediatR;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities.Commands.Edit
{
    public class ActivityEditCommandHandler : IRequestHandler<ActivityEditCommand, ServiceResponse<Unit>>
    {
        ApplicationDbContext context;
        IMapper mapper;

        public ActivityEditCommandHandler(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<Unit>> Handle(ActivityEditCommand request, CancellationToken cancellationToken)
        {
            var activity = await context.Activities.FindAsync(request.EditActivityId, cancellationToken);

            if (activity == null)
            {
                return null;
            }

            mapper.Map(request.EditRequest, activity);
            var result = await context.SaveChangesAsync(cancellationToken) > 0;

            if (!result) return ServiceResponse<Unit>.Failure("Failed to update activity");

            return ServiceResponse<Unit>.Success(Unit.Value);
        }
    }
}
