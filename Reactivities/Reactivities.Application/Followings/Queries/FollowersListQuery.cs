using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Interfaces;
using Reactivities.Contracts.Users;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Followings.Queries
{
    public class FollowersList
    {
        public class Query : IRequest<ServiceResponse<List<Contracts.Users.Profile>>>
        {
            public string Predicate { get; set; }
            public string Username { get; set; }
        }

        public class FollowerListQueryHandler : IRequestHandler<Query, ServiceResponse<List<Contracts.Users.Profile>>>
        {
            private readonly ApplicationDbContext context;
            private readonly IUserAccessor userAccessor;
            private readonly IMapper mapper;

            public FollowerListQueryHandler(ApplicationDbContext context, IUserAccessor userAccessor, IMapper mapper)
            {
                this.context = context;
                this.userAccessor = userAccessor;
                this.mapper = mapper;
            }

            async Task<ServiceResponse<List<Contracts.Users.Profile>>> IRequestHandler<Query, ServiceResponse<List<Contracts.Users.Profile>>>.Handle(Query request, CancellationToken cancellationToken)
            {
                var profiles = new List<Contracts.Users.Profile>();
                var currentUser = userAccessor.GetUsername();

                switch (request.Predicate)
                {
                    case "followers":
                        profiles = await context.UserFollowings.Where(x => x.Target.UserName == request.Username)
                            .Select(u => u.Oberver)
                            .ProjectTo<Contracts.Users.Profile>(mapper.ConfigurationProvider, new { currentUsername = currentUser })
                            .ToListAsync();
                        break;

                    case "followings":
                        profiles = await context.UserFollowings.Where(x => x.Oberver.UserName == request.Username)
                            .Select(u => u.Target)
                            .ProjectTo<Contracts.Users.Profile>(mapper.ConfigurationProvider, new { currentUsername = currentUser })
                            .ToListAsync();
                        break;
                }

                return ServiceResponse<List<Contracts.Users.Profile>>.Success(profiles);
            }
        }
    }
}
