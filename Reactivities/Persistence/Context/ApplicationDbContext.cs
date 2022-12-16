using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reactivities.Domain.Entities;
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

            modelBuilder.Entity<ActivityAttendee>(x => x.HasKey(aa => new { aa.AppUserId, aa.ActivityId }));

            modelBuilder.Entity<ActivityAttendee>()
                .HasOne(u => u.AppUser)
                .WithMany(a => a.Activities)
                .HasForeignKey(aa => aa.AppUserId);

            modelBuilder.Entity<ActivityAttendee>()
                .HasOne(a => a.Activity)
                .WithMany(u => u.Attendees)
                .HasForeignKey(uu => uu.ActivityId);

            modelBuilder.ApplyConfiguration(new ActivitiesConfiguration());
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new AttendeesConfiguration());
        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityAttendee> ActivitiesAttendees { get; set;}
        public DbSet<Photo> Photos { get; set; }
    }
}
