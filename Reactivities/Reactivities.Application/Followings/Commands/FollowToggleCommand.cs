using Application.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Interfaces;
using Reactivities.Domain.Entities;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Followings.Commands
{
    public class FollowToggle
    {
        public class Command : IRequest<ServiceResponse<Unit>>
        {
            public string TargetUsername { get; set; }
        }

        public class FollowToggleHandler : IRequestHandler<Command, ServiceResponse<Unit>>
        {
            private readonly ApplicationDbContext context;
            private readonly IUserAccessor userAccessor;

            public FollowToggleHandler(ApplicationDbContext context, IUserAccessor userAccessor)
            {
                this.context = context;
                this.userAccessor = userAccessor;
            }

            async Task<ServiceResponse<Unit>> IRequestHandler<Command, ServiceResponse<Unit>>.Handle(Command request, CancellationToken cancellationToken)
            {
                var target = await context.Users.Include(f => f.Followers).FirstOrDefaultAsync(u => u.UserName == request.TargetUsername);

                if (target == null) return null;

                var observer = await context.Users.Include(f => f.Followers).FirstOrDefaultAsync(u => u.Email == userAccessor.GetUsername());

                if (observer == null) return null;

                var following = await context.UserFollowings.FindAsync(observer.Id, target.Id);
                
                if(following == null)
                {
                    var newFollowing = new UserFollowing
                    {
                        Oberver = observer,
                        Target = target,
                    };

                    target.Followers.Add(newFollowing);
                    observer.Followings.Add(newFollowing);
                }
                else
                {
                    target.Followers.Remove(following);
                    observer.Followings.Remove(following);
                }

                var success = await context.SaveChangesAsync(cancellationToken) > 0;

                if (success) return ServiceResponse<Unit>.Success(Unit.Value);

                return ServiceResponse<Unit>.Failure("An Error ocurring while following user.");
            }
        }
    }
}
