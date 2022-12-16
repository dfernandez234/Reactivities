﻿using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Reactivities.Application.Interfaces;
using Reactivities.Contracts.Photos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Infrastructure.Photos
{
    public class PhotoAccessor : IPhotoAccessor
    {
        private readonly Cloudinary cloudinary;

        public PhotoAccessor(IOptions<CloudinarySettings> config)
        {
            var account = new Account(
                config.Value.CloudName,
                config.Value.ApiKey,
                config.Value.ApiSecret
            );

            cloudinary = new Cloudinary( account );
        }

        async Task<PhotosUploadResult?> IPhotoAccessor.AddPhoto(IFormFile file)
        {
            if(file.Length > 0)
            {

                await using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.Name, stream),
                    Transformation = new Transformation().Height(500).Width(500).Crop("fill")
                };

                var uploadResult = await cloudinary.UploadAsync(uploadParams);

                if(uploadResult == null)
                {
                    throw new Exception(uploadResult.Error.Message);
                }

                return new PhotosUploadResult
                {
                    PublicId = uploadResult.PublicId,
                    Url = uploadResult.SecureUrl.ToString()
                };
            }

            return null;
        }

        async Task<string?> IPhotoAccessor.DeletePhoto(string publicId)
        {
            var deleteParams = new DeletionParams(publicId);
            var result = await cloudinary.DestroyAsync(deleteParams);
            return result.Result == "ok" ? result.Result : null;
        }
    }
}
