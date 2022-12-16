using Application.Core;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Interfaces;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Photos.Commands.Delete
{
    public class DeletePhoto
    {
        public class Command : IRequest<ServiceResponse<Unit>>
        {
            public string Id { get; set; }
        }

        public class DeletePhotoCommandHandler : IRequestHandler<Command, ServiceResponse<Unit>>
        {
            private readonly ApplicationDbContext context;
            private readonly IPhotoAccessor photoAccessor;
            private readonly IUserAccessor userAccessor;

            public DeletePhotoCommandHandler(ApplicationDbContext context, IPhotoAccessor photoAccessor, IUserAccessor userAccessor)
            {
                this.context = context;
                this.photoAccessor = photoAccessor;
                this.userAccessor = userAccessor;
            }

            async Task<ServiceResponse<Unit>> IRequestHandler<Command, ServiceResponse<Unit>>.Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Email == userAccessor.GetUsername());
                if (user == null) return null;

                var photo = user.Photos.FirstOrDefault(x => x.Id == request.Id);
                if (photo == null) return null;

                if (photo.IsMain) return ServiceResponse<Unit>.Failure("You cannot delete your main photo");

                var result = await photoAccessor.DeletePhoto(photo.Id);

                if (result == null) return ServiceResponse<Unit>.Failure("Problem deleting photo from Cloudinary");
                user.Photos.Remove(photo);

                var success = await context.SaveChangesAsync() > 0;
                if (success) return ServiceResponse<Unit>.Success(Unit.Value);

                return ServiceResponse<Unit>.Failure("Problem deleting from Cloudinary");
            }
        }
    }
}
