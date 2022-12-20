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
using Reactivities.Application.Core;
using Reactivities.Application.Interfaces;
using Reactivities.Contracts.Activities;
using Reactivities.Infrastructure.Persistence.Context;

namespace Reactivities.Application.Activities.Queries.List
{
    public class ListQuery : IRequest<ServiceResponse<PagedList<GetActivityResponse>>> {
        public PagingParams Params { get; set; }
    }

    public class ListQueryHandler : IRequestHandler<ListQuery, ServiceResponse<PagedList<GetActivityResponse>>>
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

        public async Task<ServiceResponse<PagedList<GetActivityResponse>>> Handle(ListQuery request, CancellationToken cancellationToken)
        {
            var query = context.Activities.OrderBy(x => x.Date)
                   .ProjectTo<GetActivityResponse>(mapper.ConfigurationProvider,
                            new { currentUsername = userAccessor.GetUsername() })
                   .AsQueryable();

            return ServiceResponse<PagedList<GetActivityResponse>>.Success(
                await PagedList<GetActivityResponse>.CreateAsync(query, request.Params.PageNumber, request.Params.PageSize)
            );
        }
    }

}
