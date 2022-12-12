using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NewActivitySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "536e5bb5-578f-488c-881b-46ff68e131da");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "5b566f8f-0c65-412b-a2b2-769e7f89bf9c");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "73bd6596-fc90-4f34-8c26-7c9f9c0e72ae");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "96dd72dc-0597-4bff-99c9-4e68a43318c5");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "9e0bacb5-d6bb-4f9f-bbf2-f45bae65a00a");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "b07797fc-e982-4494-bb72-2201c45f0127");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "b7d09299-ea89-4ffe-b8d7-e0d2722209a7");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d045b78b-dcd9-4593-a961-ebf987b1ca69");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "e7c151b4-f97f-42dd-b75c-27e41b4b0e42");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "fe8093db-aa57-417c-9e20-56d28ba4b9be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f22522b-0e78-4b33-affe-fd1fd11b3978");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6945e9ee-f766-4533-acc9-ba890dafe71b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a46f98c2-eced-4fb1-9cae-5a2845a6342f");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[,]
                {
                    { "15c98ad8-1a10-4a16-a4e2-ac00bd224b10", "Music", "Italy", new DateTime(2023, 6, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2831), "Activity 6 month in future", false, "Future Activity 6", "Coliseum" },
                    { "367d29d2-93fe-4346-bb60-030f82b5a404", "Culture", "London", new DateTime(2023, 1, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2752), "Activity 1 month in future", false, "Future Activity 1", "Natural History Museum" },
                    { "457d8bc2-c043-47fd-a346-9c80bbb0faf6", "Culture", "Paris", new DateTime(2023, 5, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2767), "Activity 5 month in future", false, "Future Activity 5", "Musée d'Orsay" },
                    { "66daebb2-b0f6-49d9-89f9-011b7a5151b3", "Drinks", "Paris", new DateTime(2023, 8, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2841), "Activity 8 month in future", false, "Future Activity 8", "Ritz Hotel" },
                    { "6fa46c14-7d32-45af-9f49-96a93cca8e02", "Culture", "Paris", new DateTime(2022, 10, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2725), "Activity 2 months ago", false, "Past Activity 2", "Louvre" },
                    { "b16a420b-2b43-46ec-9e04-1be283cd68cb", "Drinks", "London", new DateTime(2022, 11, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2676), "Activity 1 months ago", false, "Past Activity 1", "Pub" },
                    { "d1110c65-87ae-4fcf-af8e-761890a3c80a", "Music", "London", new DateTime(2023, 2, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2756), "Activity 2 month in future", false, "Future Activity 2", "02 Arena" },
                    { "d50fc785-d15c-4faa-9e50-d456b132d508", "Drinks", "London", new DateTime(2023, 4, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2764), "Activity 4 month in future", false, "Future Activity 4", "Just Another Pub" },
                    { "d9a5dbeb-2b83-4263-83f7-d033b7f345b1", "Drinks", "London", new DateTime(2023, 7, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2836), "Activity 7 month in future", false, "Future Activity 7", "Another Pub Again" },
                    { "dd01183f-901e-411f-abae-3e065cb57456", "Drinks", "London", new DateTime(2023, 3, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2760), "Activity 3 month in future", false, "Future Activity 3", "Another Pub" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07065484-6bbd-4ddd-9fad-ec075a068141", 0, "", "fa1518c7-864e-4dc6-8902-77a80ae2766b", "Jane", "jane@test.com", false, false, null, "JANE@TEST.COM", null, "AQAAAAIAAYagAAAAEJVjHkp3v7yPeuP1pgPL/0PVKcV9A6XUaIxbfxuLKR5skksWoOsEES8f1MewN2WNDg==", null, false, "71db655d-ac5c-4afb-95e0-268dce753674", false, "jane" },
                    { "3055acfb-e8b6-409c-8311-2302b75c37a9", 0, "", "5cf6b718-a6b1-48e0-b18f-81e5d27ce780", "Bob", "bob@test.com", false, false, null, "BOB@TEST.COM", null, "AQAAAAIAAYagAAAAEKkJVUryDpOn3QK1TcC1Gyjk0bmfUudUBB47YkjHxzf6pdl4auOoFAP2+hbUEuUPpg==", null, false, "7cbdc912-0131-438c-9c61-f3b02b4d1d36", false, "bob" },
                    { "53503633-08ab-4c93-a2a1-5f8ea67229fd", 0, "", "858e7280-0a47-4243-8735-9ba0f3942619", "Tom", "tom@test.com", false, false, null, "TOM@TEST.COM", null, "AQAAAAIAAYagAAAAEI/R96Yust3tU2+KQ9mb9DSK0hyp+CoAp2gHqfUrKRI+s/LevLy5q3GyQxzYJ3f0zA==", null, false, "411b51f3-9890-435e-b496-32f426a623eb", false, "tom" }
                });

            migrationBuilder.InsertData(
                table: "ActivitiesAttendees",
                columns: new[] { "ActivityId", "AppUserId", "IsHost" },
                values: new object[,]
                {
                    { "15c98ad8-1a10-4a16-a4e2-ac00bd224b10", "07065484-6bbd-4ddd-9fad-ec075a068141", true },
                    { "367d29d2-93fe-4346-bb60-030f82b5a404", "07065484-6bbd-4ddd-9fad-ec075a068141", true },
                    { "66daebb2-b0f6-49d9-89f9-011b7a5151b3", "07065484-6bbd-4ddd-9fad-ec075a068141", true },
                    { "d1110c65-87ae-4fcf-af8e-761890a3c80a", "07065484-6bbd-4ddd-9fad-ec075a068141", false },
                    { "d9a5dbeb-2b83-4263-83f7-d033b7f345b1", "07065484-6bbd-4ddd-9fad-ec075a068141", false },
                    { "457d8bc2-c043-47fd-a346-9c80bbb0faf6", "3055acfb-e8b6-409c-8311-2302b75c37a9", true },
                    { "6fa46c14-7d32-45af-9f49-96a93cca8e02", "3055acfb-e8b6-409c-8311-2302b75c37a9", true },
                    { "b16a420b-2b43-46ec-9e04-1be283cd68cb", "3055acfb-e8b6-409c-8311-2302b75c37a9", true },
                    { "d1110c65-87ae-4fcf-af8e-761890a3c80a", "3055acfb-e8b6-409c-8311-2302b75c37a9", true },
                    { "d9a5dbeb-2b83-4263-83f7-d033b7f345b1", "3055acfb-e8b6-409c-8311-2302b75c37a9", true },
                    { "dd01183f-901e-411f-abae-3e065cb57456", "3055acfb-e8b6-409c-8311-2302b75c37a9", false },
                    { "15c98ad8-1a10-4a16-a4e2-ac00bd224b10", "53503633-08ab-4c93-a2a1-5f8ea67229fd", false },
                    { "367d29d2-93fe-4346-bb60-030f82b5a404", "53503633-08ab-4c93-a2a1-5f8ea67229fd", false },
                    { "457d8bc2-c043-47fd-a346-9c80bbb0faf6", "53503633-08ab-4c93-a2a1-5f8ea67229fd", false },
                    { "66daebb2-b0f6-49d9-89f9-011b7a5151b3", "53503633-08ab-4c93-a2a1-5f8ea67229fd", false },
                    { "6fa46c14-7d32-45af-9f49-96a93cca8e02", "53503633-08ab-4c93-a2a1-5f8ea67229fd", false },
                    { "d50fc785-d15c-4faa-9e50-d456b132d508", "53503633-08ab-4c93-a2a1-5f8ea67229fd", true },
                    { "dd01183f-901e-411f-abae-3e065cb57456", "53503633-08ab-4c93-a2a1-5f8ea67229fd", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "15c98ad8-1a10-4a16-a4e2-ac00bd224b10", "07065484-6bbd-4ddd-9fad-ec075a068141" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "367d29d2-93fe-4346-bb60-030f82b5a404", "07065484-6bbd-4ddd-9fad-ec075a068141" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "66daebb2-b0f6-49d9-89f9-011b7a5151b3", "07065484-6bbd-4ddd-9fad-ec075a068141" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "d1110c65-87ae-4fcf-af8e-761890a3c80a", "07065484-6bbd-4ddd-9fad-ec075a068141" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "d9a5dbeb-2b83-4263-83f7-d033b7f345b1", "07065484-6bbd-4ddd-9fad-ec075a068141" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "457d8bc2-c043-47fd-a346-9c80bbb0faf6", "3055acfb-e8b6-409c-8311-2302b75c37a9" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "6fa46c14-7d32-45af-9f49-96a93cca8e02", "3055acfb-e8b6-409c-8311-2302b75c37a9" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "b16a420b-2b43-46ec-9e04-1be283cd68cb", "3055acfb-e8b6-409c-8311-2302b75c37a9" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "d1110c65-87ae-4fcf-af8e-761890a3c80a", "3055acfb-e8b6-409c-8311-2302b75c37a9" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "d9a5dbeb-2b83-4263-83f7-d033b7f345b1", "3055acfb-e8b6-409c-8311-2302b75c37a9" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "dd01183f-901e-411f-abae-3e065cb57456", "3055acfb-e8b6-409c-8311-2302b75c37a9" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "15c98ad8-1a10-4a16-a4e2-ac00bd224b10", "53503633-08ab-4c93-a2a1-5f8ea67229fd" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "367d29d2-93fe-4346-bb60-030f82b5a404", "53503633-08ab-4c93-a2a1-5f8ea67229fd" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "457d8bc2-c043-47fd-a346-9c80bbb0faf6", "53503633-08ab-4c93-a2a1-5f8ea67229fd" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "66daebb2-b0f6-49d9-89f9-011b7a5151b3", "53503633-08ab-4c93-a2a1-5f8ea67229fd" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "6fa46c14-7d32-45af-9f49-96a93cca8e02", "53503633-08ab-4c93-a2a1-5f8ea67229fd" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "d50fc785-d15c-4faa-9e50-d456b132d508", "53503633-08ab-4c93-a2a1-5f8ea67229fd" });

            migrationBuilder.DeleteData(
                table: "ActivitiesAttendees",
                keyColumns: new[] { "ActivityId", "AppUserId" },
                keyValues: new object[] { "dd01183f-901e-411f-abae-3e065cb57456", "53503633-08ab-4c93-a2a1-5f8ea67229fd" });

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "15c98ad8-1a10-4a16-a4e2-ac00bd224b10");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "367d29d2-93fe-4346-bb60-030f82b5a404");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "457d8bc2-c043-47fd-a346-9c80bbb0faf6");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "66daebb2-b0f6-49d9-89f9-011b7a5151b3");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "6fa46c14-7d32-45af-9f49-96a93cca8e02");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "b16a420b-2b43-46ec-9e04-1be283cd68cb");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d1110c65-87ae-4fcf-af8e-761890a3c80a");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d50fc785-d15c-4faa-9e50-d456b132d508");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d9a5dbeb-2b83-4263-83f7-d033b7f345b1");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "dd01183f-901e-411f-abae-3e065cb57456");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07065484-6bbd-4ddd-9fad-ec075a068141");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3055acfb-e8b6-409c-8311-2302b75c37a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53503633-08ab-4c93-a2a1-5f8ea67229fd");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[,]
                {
                    { "536e5bb5-578f-488c-881b-46ff68e131da", "Drinks", "London", new DateTime(2023, 4, 11, 17, 42, 20, 927, DateTimeKind.Local).AddTicks(8884), "Activity 4 month in future", false, "Future Activity 4", "Just Another Pub" },
                    { "5b566f8f-0c65-412b-a2b2-769e7f89bf9c", "Culture", "London", new DateTime(2023, 1, 11, 17, 42, 20, 927, DateTimeKind.Local).AddTicks(8874), "Activity 1 month in future", false, "Future Activity 1", "Natural History Museum" },
                    { "73bd6596-fc90-4f34-8c26-7c9f9c0e72ae", "Drinks", "London", new DateTime(2023, 7, 11, 17, 42, 20, 927, DateTimeKind.Local).AddTicks(8897), "Activity 7 month in future", false, "Future Activity 7", "Another Pub Again" },
                    { "96dd72dc-0597-4bff-99c9-4e68a43318c5", "Culture", "Paris", new DateTime(2022, 10, 11, 17, 42, 20, 927, DateTimeKind.Local).AddTicks(8870), "Activity 2 months ago", false, "Past Activity 2", "Louvre" },
                    { "9e0bacb5-d6bb-4f9f-bbf2-f45bae65a00a", "Culture", "Paris", new DateTime(2023, 5, 11, 17, 42, 20, 927, DateTimeKind.Local).AddTicks(8888), "Activity 5 month in future", false, "Future Activity 5", "Musée d'Orsay" },
                    { "b07797fc-e982-4494-bb72-2201c45f0127", "Drinks", "London", new DateTime(2023, 3, 11, 17, 42, 20, 927, DateTimeKind.Local).AddTicks(8881), "Activity 3 month in future", false, "Future Activity 3", "Another Pub" },
                    { "b7d09299-ea89-4ffe-b8d7-e0d2722209a7", "Music", "Italy", new DateTime(2023, 6, 11, 17, 42, 20, 927, DateTimeKind.Local).AddTicks(8891), "Activity 6 month in future", false, "Future Activity 6", "Coliseum" },
                    { "d045b78b-dcd9-4593-a961-ebf987b1ca69", "Music", "London", new DateTime(2023, 2, 11, 17, 42, 20, 927, DateTimeKind.Local).AddTicks(8878), "Activity 2 month in future", false, "Future Activity 2", "02 Arena" },
                    { "e7c151b4-f97f-42dd-b75c-27e41b4b0e42", "Drinks", "London", new DateTime(2022, 11, 11, 17, 42, 20, 927, DateTimeKind.Local).AddTicks(8824), "Activity 1 months ago", false, "Past Activity 1", "Pub" },
                    { "fe8093db-aa57-417c-9e20-56d28ba4b9be", "Drinks", "Paris", new DateTime(2023, 8, 11, 17, 42, 20, 927, DateTimeKind.Local).AddTicks(8900), "Activity 8 month in future", false, "Future Activity 8", "Ritz Hotel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f22522b-0e78-4b33-affe-fd1fd11b3978", 0, "", "be706a0f-0930-472c-bc77-31fc44dfc2ea", "Jane", "jane@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEKBe3v0UjbXL1ovNTnheQB8VMSg+YD5BzR/JVSVV4JBBfgUvVD0ywl4aE3U9kSUexA==", null, false, "33011d6a-5b77-4bb1-98c0-bea291db3c6a", false, "jane" },
                    { "6945e9ee-f766-4533-acc9-ba890dafe71b", 0, "", "b9a9c2a3-38d7-4024-9e0c-9d112bb5e524", "Bob", "bob@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEEALRKryeTlzokuExruoTuSfHe2HaovSDz8DxD+y3C1IdntfPiUfYHTjTpCzopOg6A==", null, false, "0b353857-1740-4a10-89de-58c48434bb16", false, "bob" },
                    { "a46f98c2-eced-4fb1-9cae-5a2845a6342f", 0, "", "2d188167-bd99-41ec-92bc-74912826bfa5", "Tom", "tom@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEHZRHJmbrwd0KG7V3PMLWKxQwqmfzNVwQH09s2qcr5OSHoANhoN027J2GH445GKPrg==", null, false, "a08698f8-5ab2-4cb4-b09b-428666405093", false, "tom" }
                });
        }
    }
}
