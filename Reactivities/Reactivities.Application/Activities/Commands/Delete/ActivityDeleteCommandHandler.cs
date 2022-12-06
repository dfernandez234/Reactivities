using Application.Core;
using MediatR;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities.Commands.Delete
{
    public class ActivityDeleteCommandHandler : IRequestHandler<ActivityDeleteCommand, ServiceResponse<Unit>>
    {
        private readonly ApplicationDbContext context;

        public ActivityDeleteCommandHandler(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<ServiceResponse<Unit>> Handle(ActivityDeleteCommand request, CancellationToken cancellationToken)
        {
            var activity = await context.Activities.FindAsync(request.Id, cancellationToken);
            if (activity == null)
            {
                return ServiceResponse<Unit>.Failure("Activity Not Found");
            }

            context.Activities.Remove(activity);
            await context.SaveChangesAsync(cancellationToken);
            return ServiceResponse<Unit>.Success(Unit.Value);
        }
    }
}
