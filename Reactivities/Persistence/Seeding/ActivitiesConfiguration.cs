using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reactivities.Domain.Entities;

namespace Reactivities.Persistence.Seeding
{
    public class ActivitiesConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasData(
                new Activity
                {
                    ActivityId = "b16a420b-2b43-46ec-9e04-1be283cd68cb",
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 months ago",
                    Category = "Drinks",
                    City = "London",
                    Venue = "Pub"
                },
                new Activity
                {
                    ActivityId = "6fa46c14-7d32-45af-9f49-96a93cca8e02",
                    Title = "Past Activity 2",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "Culture",
                    City = "Paris",
                    Venue = "Louvre"
                },
                new Activity
                {
                    ActivityId = "367d29d2-93fe-4346-bb60-030f82b5a404",
                    Title = "Future Activity 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Activity 1 month in future",
                    Category = "Culture",
                    City = "London",
                    Venue = "Natural History Museum"
                },
                new Activity
                {
                    ActivityId = "d1110c65-87ae-4fcf-af8e-761890a3c80a",
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Activity 2 month in future",
                    Category = "Music",
                    City = "London",
                    Venue = "02 Arena"
                },
                new Activity
                {
                    ActivityId = "dd01183f-901e-411f-abae-3e065cb57456",
                    Title = "Future Activity 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Activity 3 month in future",
                    Category = "Drinks",
                    City = "London",
                    Venue = "Another Pub"
                },
                new Activity
                {
                    ActivityId = "d50fc785-d15c-4faa-9e50-d456b132d508",
                    Title = "Future Activity 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Activity 4 month in future",
                    Category = "Drinks",
                    City = "London",
                    Venue = "Just Another Pub"
                },
                new Activity
                {
                    ActivityId = "457d8bc2-c043-47fd-a346-9c80bbb0faf6",
                    Title = "Future Activity 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Activity 5 month in future",
                    Category = "Culture",
                    City = "Paris",
                    Venue = "Musée d'Orsay"
                },
                new Activity
                {
                    ActivityId = "15c98ad8-1a10-4a16-a4e2-ac00bd224b10",
                    Title = "Future Activity 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Activity 6 month in future",
                    Category = "Music",
                    City = "Italy",
                    Venue = "Coliseum"
                },
                new Activity
                {
                    ActivityId = "d9a5dbeb-2b83-4263-83f7-d033b7f345b1",
                    Title = "Future Activity 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Activity 7 month in future",
                    Category = "Drinks",
                    City = "London",
                    Venue = "Another Pub Again"
                },
                new Activity
                {
                    ActivityId = "66daebb2-b0f6-49d9-89f9-011b7a5151b3",
                    Title = "Future Activity 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Activity 8 month in future",
                    Category = "Drinks",
                    City = "Paris",
                    Venue = "Ritz Hotel"
                }
            );
        }
    }
}
