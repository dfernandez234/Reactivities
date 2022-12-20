using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FluentResults;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Interfaces;
using Reactivities.Contracts.Activities;
using Reactivities.Infrastructure.Persistence.Context;

namespace Reactivities.Application.Activities.Queries.List
{
    public class ListQuery : IRequest<ServiceResponse<List<GetActivityResponse>>> { }

    public class ListQueryHandler : IRequestHandler<ListQuery, ServiceResponse<List<GetActivityResponse>>>
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IUserAccessor userAccessor;

        public ListQueryHandler(ApplicationDbContext context, IMapper mapper, IUserAccessor userAccessor)
        {
            this.mapper = mapper;
            this.context = context;
            this.userAccessor = userAccessor;
        }

        public async Task<ServiceResponse<List<GetActivityResponse>>> Handle(ListQuery request, CancellationToken cancellationToken)
        {
            var activites = await context.Activities
                .ProjectTo<GetActivityResponse>(mapper.ConfigurationProvider, new { currentUsername = userAccessor.GetUsername() })
                .ToListAsync();

            return ServiceResponse<List<GetActivityResponse>>.Success(mapper.Map<List<GetActivityResponse>>(activites));
        }
    }

}
