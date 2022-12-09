using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reactivities.Domain.Entities;
using Reactivities.Domain.Entities.Activity;
using Reactivities.Persistence.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Infrastructure.Persistence.Context
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ActivitiesConfiguration());
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
