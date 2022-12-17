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

namespace Reactivities.Application.Profiles.Command
{
    public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand, ServiceResponse<Unit>>
    {
        private readonly ApplicationDbContext context;
        private readonly IUserAccessor userAccessor;

        public UpdateProfileCommandHandler(ApplicationDbContext context, IUserAccessor userAccessor)
        {
            this.context = context;
            this.userAccessor = userAccessor;
        }

        async Task<ServiceResponse<Unit>> IRequestHandler<UpdateProfileCommand, ServiceResponse<Unit>>.Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Email == userAccessor.GetUsername(), cancellationToken: cancellationToken);
            if (user == null) return null;

            user.DisplayName = request.Update.DisplayName;
            user.Bio = request.Update.Bio;

            var result = await context.SaveChangesAsync(cancellationToken) > 0;

            if (result) return ServiceResponse<Unit>.Success(Unit.Value);

            return ServiceResponse<Unit>.Failure("Problem Updating Profile");
        }
    }
}
