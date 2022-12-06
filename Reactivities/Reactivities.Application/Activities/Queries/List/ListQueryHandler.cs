﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using FluentResults;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Contracts.Activities;
using Reactivities.Infrastructure.Persistence.Context;

namespace Reactivities.Application.Activities.Queries.List
{
    public class ListQuery : IRequest<ServiceResponse<List<GetActivityResponse>>> { }

    public class ListQueryHandler : IRequestHandler<ListQuery, ServiceResponse<List<GetActivityResponse>>>
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ListQueryHandler(ApplicationDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<ServiceResponse<List<GetActivityResponse>>> Handle(ListQuery request, CancellationToken cancellationToken)
        {
            var activites = mapper.Map<List<GetActivityResponse>>(await context.Activities.ToListAsync());

            return ServiceResponse<List<GetActivityResponse>>.Success(activites);
        }
    }

}