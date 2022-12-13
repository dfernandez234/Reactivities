using Application.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities.Commands.Cancel
{
    internal class CancelActivityCommandHandler : IRequestHandler<CancelActivityCommand, ServiceResponse<Unit>>
    {
        private readonly ApplicationDbContext context;

        public CancelActivityCommandHandler(ApplicationDbContext context)
        {
            this.context = context;
        }

        async Task<ServiceResponse<Unit>> IRequestHandler<CancelActivityCommand, ServiceResponse<Unit>>.Handle(CancelActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await context.Activities.FirstOrDefaultAsync(x => x.ActivityId == request.Id);

            if (activity == null)
            {
                return null;
            }

            activity.IsCancelled = !activity.IsCancelled;
            context.Activities.Update(activity);
            var result = await context.SaveChangesAsync(cancellationToken) > 0;

            if (!result) return ServiceResponse<Unit>.Failure("Failed to update activity");

            return ServiceResponse<Unit>.Success(Unit.Value);
        }
    }
}
