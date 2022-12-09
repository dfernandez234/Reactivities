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
                    DisplayName = "Bob",
                    Bio = "",
                    UserName = "bob",
                    Email = "bob@test.com",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                },

                new AppUser
                {
                    DisplayName = "Tom",
                    Bio = "",
                    UserName = "tom",
                    Email = "tom@test.com",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                },

                new AppUser
                {
                    DisplayName = "Jane",
                    Bio = "",
                    UserName = "jane",
                    Email = "jane@test.com",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                }
            );
        }
    }
}
