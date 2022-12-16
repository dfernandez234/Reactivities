using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Profiles.Queries
{
    public class ProfileDetails
    {
        public class Query : IRequest<ServiceResponse<Reactivities.Contracts.Users.Profile>>
        {
            public string Username { get; set; }
        }

        public class ProfileDetailsQueryHandler : IRequestHandler<Query, ServiceResponse<Reactivities.Contracts.Users.Profile>>
        {
            private readonly ApplicationDbContext context;
            private readonly IMapper mapper;

            public ProfileDetailsQueryHandler(ApplicationDbContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<Reactivities.Contracts.Users.Profile>> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await context.Users
                    .ProjectTo<Reactivities.Contracts.Users.Profile>(mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(x => x.Username == request.Username);

                if (user == null) return null;

                return ServiceResponse<Reactivities.Contracts.Users.Profile>.Success(user);
            }
        }
    }
}
