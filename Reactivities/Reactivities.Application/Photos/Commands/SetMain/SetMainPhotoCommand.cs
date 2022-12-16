using Application.Core;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Interfaces;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Photos.Commands.SetMain
{
    public class SetMainPhoto
    {
        public class Command : IRequest<ServiceResponse<Unit>>
        {
            public string Id { get; set; }
        }

        public class SetMainPhotoCommandHandler : IRequestHandler<Command, ServiceResponse<Unit>>
        {
            private readonly ApplicationDbContext context;
            private readonly IPhotoAccessor photoAccessor;
            private readonly IUserAccessor userAccessor;

            public SetMainPhotoCommandHandler(ApplicationDbContext context, IPhotoAccessor photoAccessor, IUserAccessor userAccessor)
            {
                this.context = context;
                this.photoAccessor = photoAccessor;
                this.userAccessor = userAccessor;
            }

            public async Task<ServiceResponse<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Email == userAccessor.GetUsername());
                if (user == null) return null;

                var photo = user.Photos.FirstOrDefault(x => x.Id == request.Id);
                if (photo!.IsMain | photo == null) return null;

                var oldMainPhoto = user.Photos.FirstOrDefault(x => x.IsMain);

                if(oldMainPhoto != null) oldMainPhoto.IsMain = false;
                photo.IsMain = true;

                var success = await context.SaveChangesAsync() > 0;
                if (success) return ServiceResponse<Unit>.Success(Unit.Value);

                return ServiceResponse<Unit>.Failure("Problem deleting from Cloudinary");
            }
        }
    }
}
