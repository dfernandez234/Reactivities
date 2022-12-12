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
    internal class AttendeesConfiguration : IEntityTypeConfiguration<ActivityAttendee>
    {
        public void Configure(EntityTypeBuilder<ActivityAttendee> builder)
        {
            builder.HasData(
                new ActivityAttendee 
                {
                    AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                    ActivityId = "b16a420b-2b43-46ec-9e04-1be283cd68cb",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                    ActivityId = "6fa46c14-7d32-45af-9f49-96a93cca8e02",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                    ActivityId = "6fa46c14-7d32-45af-9f49-96a93cca8e02",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    AppUserId = "07065484-6bbd-4ddd-9fad-ec075a068141",
                    ActivityId = "367d29d2-93fe-4346-bb60-030f82b5a404",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                    ActivityId = "367d29d2-93fe-4346-bb60-030f82b5a404",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                    ActivityId = "d1110c65-87ae-4fcf-af8e-761890a3c80a",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    AppUserId = "07065484-6bbd-4ddd-9fad-ec075a068141",
                    ActivityId = "d1110c65-87ae-4fcf-af8e-761890a3c80a",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                    ActivityId = "dd01183f-901e-411f-abae-3e065cb57456",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                    ActivityId = "dd01183f-901e-411f-abae-3e065cb57456",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                    ActivityId = "d50fc785-d15c-4faa-9e50-d456b132d508",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                    ActivityId = "457d8bc2-c043-47fd-a346-9c80bbb0faf6",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                    ActivityId = "457d8bc2-c043-47fd-a346-9c80bbb0faf6",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    AppUserId = "07065484-6bbd-4ddd-9fad-ec075a068141",
                    ActivityId = "15c98ad8-1a10-4a16-a4e2-ac00bd224b10",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                    ActivityId = "15c98ad8-1a10-4a16-a4e2-ac00bd224b10",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                    ActivityId = "d9a5dbeb-2b83-4263-83f7-d033b7f345b1",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    AppUserId = "07065484-6bbd-4ddd-9fad-ec075a068141",
                    ActivityId = "d9a5dbeb-2b83-4263-83f7-d033b7f345b1",
                    IsHost = false
                },
                new ActivityAttendee
                {
                    AppUserId = "07065484-6bbd-4ddd-9fad-ec075a068141",
                    ActivityId = "66daebb2-b0f6-49d9-89f9-011b7a5151b3",
                    IsHost = true
                },
                new ActivityAttendee
                {
                    AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                    ActivityId = "66daebb2-b0f6-49d9-89f9-011b7a5151b3",
                    IsHost = false
                }
            );
        }
    }
}
