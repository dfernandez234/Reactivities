using Application.Core;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Reactivities.Application.Interfaces;
using Reactivities.Domain.Entities;
using Reactivities.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Photos.Commands.Add
{
    public class AddPhoto
    {
        public class Command : IRequest<ServiceResponse<Photo>>
        {
            public IFormFile File { get; set; }
        }

        public class AddPhotoCommandHandler : IRequestHandler<Command, ServiceResponse<Photo>>
        {
            private readonly ApplicationDbContext context;
            private readonly IPhotoAccessor photoAccessor;
            private readonly IUserAccessor userAccessor;

            public AddPhotoCommandHandler(ApplicationDbContext context, IPhotoAccessor photoAccessor, IUserAccessor userAccessor)
            {
                this.context = context;
                this.photoAccessor = photoAccessor;
                this.userAccessor = userAccessor;
            }

            async Task<ServiceResponse<Photo>> IRequestHandler<Command, ServiceResponse<Photo>>.Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Email == userAccessor.GetUsername());

                if (user == null) return null;

                var photoUploadResult = await photoAccessor.AddPhoto(request.File);

                var photo = new Photo
                {
                    Url = photoUploadResult.Url,
                    Id = photoUploadResult.PublicId
                };

                if (!user.Photos.Any(x => x.IsMain)) photo.IsMain = true;

                user.Photos.Add(photo);

                var result = await context.SaveChangesAsync() > 0;

                if (result) return ServiceResponse<Photo>.Success(photo);

                return ServiceResponse<Photo>.Failure("Problem adding Photo");
            }
        }
    }
}
