using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Interfaces;
using Reactivities.Contracts.Activities;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Activities.Queries.SingleActivity
{
    internal class SingleActivityQueryHandler : IRequestHandler<SingleActivityQuery, ServiceResponse<GetActivityResponse>>
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IUserAccessor userAccessor;
        public SingleActivityQueryHandler(ApplicationDbContext context, IMapper mapper, IUserAccessor userAccessor)
        {
            this.context = context;
            this.mapper = mapper;
            this.userAccessor = userAccessor;
        }

        async Task<ServiceResponse<GetActivityResponse>> IRequestHandler<SingleActivityQuery, ServiceResponse<GetActivityResponse>>.Handle(SingleActivityQuery request, CancellationToken cancellationToken)
        {
            var activity = await context.Activities
                .ProjectTo<GetActivityResponse>(mapper.ConfigurationProvider, new { currentUsername = userAccessor.GetUsername()})
                .FirstOrDefaultAsync(q => q.ActivityId == request.Id);

            if (activity == null) 
            {
                return ServiceResponse<GetActivityResponse>.Failure("Activity Not Found");
            }

            return ServiceResponse<GetActivityResponse>.Success(mapper.Map<GetActivityResponse>(activity));
        }
    }
}
