using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Reactivities.Domain.Entities;
using Reactivities.Infrastructure.Persistence.Context;

namespace Reactivities.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(
            this IServiceCollection services,
            Microsoft.Extensions.Configuration.ConfigurationManager configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentityCore<AppUser>(opt => { opt.Password.RequireNonAlphanumeric = false; })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddSignInManager<SignInManager<AppUser>>();
            services.TryAddSingleton<ISystemClock, SystemClock>();
            return services;
        }
    }
}
