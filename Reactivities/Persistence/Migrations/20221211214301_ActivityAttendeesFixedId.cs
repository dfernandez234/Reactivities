using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActivityAttendeesFixedId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
            name: "ActivitiesAttendees",
            columns: table => new
            {
                AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                ActivityId = table.Column<string>(type: "uniqueidentifier", nullable: false),
                IsHost = table.Column<bool>(type: "bit", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ActivitiesAttendees", x => new { x.AppUserId, x.ActivityId });
                table.ForeignKey(
                    name: "FK_ActivitiesAttendees_Activities_AppUserId",
                    column: x => x.AppUserId,
                    principalTable: "Activities",
                    principalColumn: "ActivityId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_ActivitiesAttendees_AspNetUsers_AppUserId",
                    column: x => x.AppUserId,
                    principalTable: "AspNetUsers",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { "0119b73d-2738-42ff-a718-ba21da97dd3e", "Culture", "London", new DateTime(2023, 1, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7138), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { "211dc6e1-afb5-4c52-9521-c9b6772249dd", "Drinks", "London", new DateTime(2023, 4, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7153), "Activity 4 month in future", "Future Activity 4", "Just Another Pub" },
                    { "308c248c-2a00-4a4a-875f-99121904aa79", "Drinks", "Paris", new DateTime(2023, 8, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7175), "Activity 8 month in future", "Future Activity 8", "Ritz Hotel" },
                    { "3e5fe89e-646d-4ac2-a8cf-dcb73ab34c04", "Culture", "Paris", new DateTime(2023, 5, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7158), "Activity 5 month in future", "Future Activity 5", "Musée d'Orsay" },
                    { "6c3d9fb0-340e-4bcd-8799-35ddc01cad50", "Drinks", "London", new DateTime(2022, 11, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7068), "Activity 1 months ago", "Past Activity 1", "Pub" },
                    { "767220aa-9f47-4386-9b21-4563900007cd", "Culture", "Paris", new DateTime(2022, 10, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7132), "Activity 2 months ago", "Past Activity 2", "Louvre" },
                    { "7b2ab7bc-89ce-422a-9737-c46054abb1e3", "Music", "Italy", new DateTime(2023, 6, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7163), "Activity 6 month in future", "Future Activity 6", "Coliseum" },
                    { "8cab35bd-eaf1-409e-b0a2-659d4fdff8ee", "Music", "London", new DateTime(2023, 2, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7143), "Activity 2 month in future", "Future Activity 2", "02 Arena" },
                    { "af0d38d9-f6c6-4db9-a2e8-58c8b107155e", "Drinks", "London", new DateTime(2023, 7, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7170), "Activity 7 month in future", "Future Activity 7", "Another Pub Again" },
                    { "f5f5cd06-b71e-42a0-bca9-f2e5e6bd53c9", "Drinks", "London", new DateTime(2023, 3, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7148), "Activity 3 month in future", "Future Activity 3", "Another Pub" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2d66a081-f6ee-4569-a846-c0e52081960f", 0, "", "e809d4b3-3164-4836-b3cb-226695dd91f3", "Tom", "tom@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEEMMFCP+oCGm1s89LLZ97fs+d14Y6T6a+sJkdeO0aNon20ht+8LhgOsv8Ebxf/abCg==", null, false, "c54352c0-c93d-41cd-bdaf-35c4b0bbacc5", false, "tom" },
                    { "69007e27-e5df-4877-b3d5-e5ae3bb3e389", 0, "", "033b695c-477a-421b-99d5-277c2f559ad6", "Bob", "bob@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEEVbLQPV5sjtzKt7+6yLi8w4UQOtoNpqZUO6w/F2zJs5b/UTebN5IiH10YJAJJccHg==", null, false, "88170e8c-df57-4e5b-a70b-8dd20b708734", false, "bob" },
                    { "6a2880dd-a1c7-47bc-bb1c-8aa05743d7ec", 0, "", "0f0d3d2c-5b92-4895-ab75-6ecc1d2b5e31", "Jane", "jane@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAELf+cb3/bKFvZJ+DQlgdRUcsOdK2Pm9YUfpo/CF+/VFrixdafcSqiHAKcR5FcfQIvg==", null, false, "f12fde2b-2921-4a5f-b415-3b5d2c1eac0d", false, "jane" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "ActivitiesAttendees");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "0119b73d-2738-42ff-a718-ba21da97dd3e");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "211dc6e1-afb5-4c52-9521-c9b6772249dd");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "308c248c-2a00-4a4a-875f-99121904aa79");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "3e5fe89e-646d-4ac2-a8cf-dcb73ab34c04");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "6c3d9fb0-340e-4bcd-8799-35ddc01cad50");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "767220aa-9f47-4386-9b21-4563900007cd");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "7b2ab7bc-89ce-422a-9737-c46054abb1e3");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "8cab35bd-eaf1-409e-b0a2-659d4fdff8ee");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "af0d38d9-f6c6-4db9-a2e8-58c8b107155e");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "f5f5cd06-b71e-42a0-bca9-f2e5e6bd53c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d66a081-f6ee-4569-a846-c0e52081960f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69007e27-e5df-4877-b3d5-e5ae3bb3e389");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a2880dd-a1c7-47bc-bb1c-8aa05743d7ec");

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
    }
}
