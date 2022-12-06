using Application.Core;
using AutoMapper;
using MediatR;
using Reactivities.Domain.Entities.Activity;
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

        public ActivityCreateCommandHandler(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        async Task<ServiceResponse<Unit>> IRequestHandler<ActivityCreateCommand, ServiceResponse<Unit>>.Handle(ActivityCreateCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await context.Activities.AddAsync(mapper.Map<Activity>(request.CreateRequest), cancellationToken);
                await context.SaveChangesAsync(cancellationToken);

                return ServiceResponse<Unit>.Success(Unit.Value);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
