using Microsoft.AspNetCore.Http;
using Reactivities.Contracts.Photos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Application.Interfaces
{
    public interface IPhotoAccessor
    {
        Task<PhotosUploadResult?> AddPhoto(IFormFile file);
        Task<string?> DeletePhoto(string publicId);
    }
}
