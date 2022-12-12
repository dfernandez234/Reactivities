using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActivityAttendeesFixedIdType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "011e6799-f2a9-44c0-930e-c433d09c3434");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "28036784-0c84-4f51-836d-350f8ceff771");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "3b6b2a52-9d06-4c2b-80f3-40a7ed33fd1f");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "65f30673-a40f-43fe-a4cf-dfeed53717f6");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "7962eee3-eec1-4aa5-b460-147ed65c990d");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "8eeb1adc-6217-4d3e-92c7-bb1d424dcacb");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "a918a8a7-c490-452a-a73a-d0b9edb13b6b");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "aa749c67-bb9b-42aa-b108-bf309ee09482");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "ae7b3fed-7ba8-4191-ac72-4759b27e8755");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "dbe05581-6877-4ca2-9e2a-82f496de5c78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d9bdb2e-1e2e-4c53-bcf2-9428cb03491c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c1b750b-f0ee-40ba-ae27-656fbe946e2b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a558614d-cb29-43c7-bce5-29e196ca0608");

            migrationBuilder.DropTable(
                name: "ActivitiesAttendees"
            );

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { "0724c038-8bbd-468b-abab-355e33562a9f", "Culture", "London", new DateTime(2023, 1, 11, 15, 30, 19, 47, DateTimeKind.Local).AddTicks(2368), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { "2a9e2acb-0799-4743-a06c-41c902efc082", "Drinks", "London", new DateTime(2023, 4, 11, 15, 30, 19, 47, DateTimeKind.Local).AddTicks(2379), "Activity 4 month in future", "Future Activity 4", "Just Another Pub" },
                    { "2f097966-5efd-48a2-afdf-7e7ad169276e", "Drinks", "London", new DateTime(2023, 7, 11, 15, 30, 19, 47, DateTimeKind.Local).AddTicks(2398), "Activity 7 month in future", "Future Activity 7", "Another Pub Again" },
                    { "4411c3a3-d4d2-46f5-a6b9-0f39155e812d", "Music", "Italy", new DateTime(2023, 6, 11, 15, 30, 19, 47, DateTimeKind.Local).AddTicks(2394), "Activity 6 month in future", "Future Activity 6", "Coliseum" },
                    { "72735220-0ebc-44ab-801c-15a4ad157e35", "Music", "London", new DateTime(2023, 2, 11, 15, 30, 19, 47, DateTimeKind.Local).AddTicks(2372), "Activity 2 month in future", "Future Activity 2", "02 Arena" },
                    { "901498bb-2f60-466c-98b5-73b790864d7e", "Culture", "Paris", new DateTime(2023, 5, 11, 15, 30, 19, 47, DateTimeKind.Local).AddTicks(2390), "Activity 5 month in future", "Future Activity 5", "Musée d'Orsay" },
                    { "9b9e41c3-12d5-46c6-9814-997c336c8df4", "Drinks", "London", new DateTime(2022, 11, 11, 15, 30, 19, 47, DateTimeKind.Local).AddTicks(2247), "Activity 1 months ago", "Past Activity 1", "Pub" },
                    { "bc68702c-fc8f-4566-bafb-a109ed238cb4", "Drinks", "Paris", new DateTime(2023, 8, 11, 15, 30, 19, 47, DateTimeKind.Local).AddTicks(2402), "Activity 8 month in future", "Future Activity 8", "Ritz Hotel" },
                    { "d10b648e-a9fd-4276-9b49-f6d437a81b5b", "Culture", "Paris", new DateTime(2022, 10, 11, 15, 30, 19, 47, DateTimeKind.Local).AddTicks(2297), "Activity 2 months ago", "Past Activity 2", "Louvre" },
                    { "d8c39fe8-27bb-4d94-8142-54765f284c90", "Drinks", "London", new DateTime(2023, 3, 11, 15, 30, 19, 47, DateTimeKind.Local).AddTicks(2375), "Activity 3 month in future", "Future Activity 3", "Another Pub" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "34487998-54d7-4e79-87d6-20d41698363f", 0, "", "21f081cc-a0db-4c65-97b4-aa3c8a14ac80", "Bob", "bob@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEIjH/Q6AW6j7e4rfTBO/BdJLQA5Gsx3w9jl4EjXcydO7nYzKKpAPm3dQ9WGOtqpWdg==", null, false, "c57439b1-eacf-458a-96ec-6916e6022347", false, "bob" },
                    { "71689f0d-86ba-4d1e-8697-d2a8bee9a0e9", 0, "", "6856ad1e-7d76-4deb-9194-4b33030ed233", "Tom", "tom@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEAf/isTGTEg3EKOu+1wtjqyrQpAiTCIx6esGSUfPe0EzfOZn80uPgWQDF9G860VlHg==", null, false, "d02199d3-e883-484a-b337-83a50639e2f4", false, "tom" },
                    { "cfbd9da9-03d8-40d4-867d-ffaf28fa0eaf", 0, "", "437f28ec-96e7-4d65-bd58-a0b06001f378", "Jane", "jane@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAECyemyJu13LmCJ3IW7e7SGEM9pjMpvP7GR7boMAf3Xi0DWUjXZNIenNTzTzu/Hvcsg==", null, false, "90c79da8-8c7f-4ce0-b61c-f2285b7f06d9", false, "jane" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "0724c038-8bbd-468b-abab-355e33562a9f");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "2a9e2acb-0799-4743-a06c-41c902efc082");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "2f097966-5efd-48a2-afdf-7e7ad169276e");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "4411c3a3-d4d2-46f5-a6b9-0f39155e812d");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "72735220-0ebc-44ab-801c-15a4ad157e35");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "901498bb-2f60-466c-98b5-73b790864d7e");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "9b9e41c3-12d5-46c6-9814-997c336c8df4");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "bc68702c-fc8f-4566-bafb-a109ed238cb4");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d10b648e-a9fd-4276-9b49-f6d437a81b5b");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d8c39fe8-27bb-4d94-8142-54765f284c90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34487998-54d7-4e79-87d6-20d41698363f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71689f0d-86ba-4d1e-8697-d2a8bee9a0e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfbd9da9-03d8-40d4-867d-ffaf28fa0eaf");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { "011e6799-f2a9-44c0-930e-c433d09c3434", "Drinks", "London", new DateTime(2022, 11, 11, 13, 10, 6, 568, DateTimeKind.Local).AddTicks(386), "Activity 1 months ago", "Past Activity 1", "Pub" },
                    { "28036784-0c84-4f51-836d-350f8ceff771", "Drinks", "Paris", new DateTime(2023, 8, 11, 13, 10, 6, 568, DateTimeKind.Local).AddTicks(473), "Activity 8 month in future", "Future Activity 8", "Ritz Hotel" },
                    { "3b6b2a52-9d06-4c2b-80f3-40a7ed33fd1f", "Culture", "Paris", new DateTime(2023, 5, 11, 13, 10, 6, 568, DateTimeKind.Local).AddTicks(462), "Activity 5 month in future", "Future Activity 5", "Musée d'Orsay" },
                    { "65f30673-a40f-43fe-a4cf-dfeed53717f6", "Music", "Italy", new DateTime(2023, 6, 11, 13, 10, 6, 568, DateTimeKind.Local).AddTicks(466), "Activity 6 month in future", "Future Activity 6", "Coliseum" },
                    { "7962eee3-eec1-4aa5-b460-147ed65c990d", "Drinks", "London", new DateTime(2023, 7, 11, 13, 10, 6, 568, DateTimeKind.Local).AddTicks(470), "Activity 7 month in future", "Future Activity 7", "Another Pub Again" },
                    { "8eeb1adc-6217-4d3e-92c7-bb1d424dcacb", "Culture", "Paris", new DateTime(2022, 10, 11, 13, 10, 6, 568, DateTimeKind.Local).AddTicks(435), "Activity 2 months ago", "Past Activity 2", "Louvre" },
                    { "a918a8a7-c490-452a-a73a-d0b9edb13b6b", "Music", "London", new DateTime(2023, 2, 11, 13, 10, 6, 568, DateTimeKind.Local).AddTicks(443), "Activity 2 month in future", "Future Activity 2", "02 Arena" },
                    { "aa749c67-bb9b-42aa-b108-bf309ee09482", "Drinks", "London", new DateTime(2023, 3, 11, 13, 10, 6, 568, DateTimeKind.Local).AddTicks(447), "Activity 3 month in future", "Future Activity 3", "Another Pub" },
                    { "ae7b3fed-7ba8-4191-ac72-4759b27e8755", "Culture", "London", new DateTime(2023, 1, 11, 13, 10, 6, 568, DateTimeKind.Local).AddTicks(440), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { "dbe05581-6877-4ca2-9e2a-82f496de5c78", "Drinks", "London", new DateTime(2023, 4, 11, 13, 10, 6, 568, DateTimeKind.Local).AddTicks(459), "Activity 4 month in future", "Future Activity 4", "Just Another Pub" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3d9bdb2e-1e2e-4c53-bcf2-9428cb03491c", 0, "", "f9cd0c66-1dcd-422e-b26c-a5513b652753", "Bob", "bob@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEJQHutA0hMVEmQs7G66urypeuTTrpJ+Ta+pGqoTZwHFtWS8IeMJ7/6kvikETXEKRzg==", null, false, "e8a12353-d334-4bf5-8923-40a71dd23e2c", false, "bob" },
                    { "5c1b750b-f0ee-40ba-ae27-656fbe946e2b", 0, "", "d5b7ded5-b350-41c3-b65f-55872edc165a", "Tom", "tom@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEEgjJCccWNjPdJzrbTkleWzowfefKx5sLAkkTuSTs6iPGNQLxvIRbt+smaMzIi2Rdw==", null, false, "8cccc219-1dc3-48b6-b4b8-67c3677019a4", false, "tom" },
                    { "a558614d-cb29-43c7-bce5-29e196ca0608", 0, "", "3c5f2c7b-a3d5-441b-a459-fdd0e47af03a", "Jane", "jane@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEN9EkzM3s2wcKGyJaJrdvYQtpF8P9uHe9T1OW/8FtFxW8oK5lw7SQtaGHtanmSFTKQ==", null, false, "59ef71d6-bb1b-4815-8218-2a214fb96ec4", false, "jane" }
                });
        }
    }
}
