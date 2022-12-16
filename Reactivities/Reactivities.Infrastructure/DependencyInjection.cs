using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reactivities.Application.Common.Interfaces.Authentication;
using Reactivities.Application.Common.Interfaces.Services;
using Reactivities.Application.Interfaces;
using Reactivities.Infrastructure.Authentication;
using Reactivities.Infrastructure.Photos;
using Reactivities.Infrastructure.Services;

namespace Reactivities.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            Microsoft.Extensions.Configuration.ConfigurationManager configuration)
        {

            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddScoped<IUserAccessor, UserAccessor>();
            services.AddScoped<IPhotoAccessor, PhotoAccessor>();
            return services;
        }
    }
}
