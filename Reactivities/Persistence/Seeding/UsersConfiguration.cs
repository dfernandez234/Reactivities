using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reactivities.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Persistence.Seeding
{
    public class UsersConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();
            builder.HasData(
                new AppUser { 
                    Id = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                    DisplayName = "Bob",
                    Bio = "",
                    UserName = "bob",
                    Email = "bob@test.com",
                    NormalizedEmail = "bob@test.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                },

                new AppUser
                {
                    Id = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                    DisplayName = "Tom",
                    Bio = "",
                    UserName = "tom",
                    Email = "tom@test.com",
                    NormalizedEmail = "tom@test.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                },

                new AppUser
                {
                    Id = "07065484-6bbd-4ddd-9fad-ec075a068141",
                    DisplayName = "Jane",
                    Bio = "",
                    UserName = "jane",
                    Email = "jane@test.com",
                    NormalizedEmail = "jane@test.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                }
            );
        }
    }
}
