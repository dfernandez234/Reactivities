using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActivityAttendeesRelationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivitiesAttendees_Activities_AppUserId",
                table: "ActivitiesAttendees");

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
                    { "017c17a5-351b-491c-a58f-fd12ebe52807", "Music", "Italy", new DateTime(2023, 6, 11, 16, 3, 48, 818, DateTimeKind.Local).AddTicks(7194), "Activity 6 month in future", "Future Activity 6", "Coliseum" },
                    { "2642d3af-0cd7-4e05-8bf2-3398306e28f5", "Culture", "London", new DateTime(2023, 1, 11, 16, 3, 48, 818, DateTimeKind.Local).AddTicks(7174), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { "3d5b53ad-557f-470a-bb80-ef200486410e", "Drinks", "London", new DateTime(2023, 7, 11, 16, 3, 48, 818, DateTimeKind.Local).AddTicks(7198), "Activity 7 month in future", "Future Activity 7", "Another Pub Again" },
                    { "442ec2a9-3060-4a1f-b628-2c9b98f355dd", "Drinks", "London", new DateTime(2023, 3, 11, 16, 3, 48, 818, DateTimeKind.Local).AddTicks(7183), "Activity 3 month in future", "Future Activity 3", "Another Pub" },
                    { "48aeb038-d2ac-49ed-bb43-cef226766e26", "Drinks", "London", new DateTime(2023, 4, 11, 16, 3, 48, 818, DateTimeKind.Local).AddTicks(7187), "Activity 4 month in future", "Future Activity 4", "Just Another Pub" },
                    { "9045c52a-1098-474d-bccf-d0bea5de51fd", "Drinks", "Paris", new DateTime(2023, 8, 11, 16, 3, 48, 818, DateTimeKind.Local).AddTicks(7201), "Activity 8 month in future", "Future Activity 8", "Ritz Hotel" },
                    { "9465dc0e-055e-4921-a87b-6b479404237e", "Culture", "Paris", new DateTime(2023, 5, 11, 16, 3, 48, 818, DateTimeKind.Local).AddTicks(7191), "Activity 5 month in future", "Future Activity 5", "Musée d'Orsay" },
                    { "b30132d7-e2aa-4490-96fb-cb8916079322", "Culture", "Paris", new DateTime(2022, 10, 11, 16, 3, 48, 818, DateTimeKind.Local).AddTicks(7149), "Activity 2 months ago", "Past Activity 2", "Louvre" },
                    { "e787e01e-282d-4c4f-b80f-1e81e29cb6d2", "Drinks", "London", new DateTime(2022, 11, 11, 16, 3, 48, 818, DateTimeKind.Local).AddTicks(7081), "Activity 1 months ago", "Past Activity 1", "Pub" },
                    { "fc8091ee-4df2-4fcb-a376-b3e6449b16d7", "Music", "London", new DateTime(2023, 2, 11, 16, 3, 48, 818, DateTimeKind.Local).AddTicks(7179), "Activity 2 month in future", "Future Activity 2", "02 Arena" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "45254f2a-7e2a-4f3a-9229-645f45d60fa7", 0, "", "b2e9f0a2-d3e1-4c53-a478-d1db4324e2fc", "Tom", "tom@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEPf3EKydaCRel+22I3zh55lowHGXdBG1oLLZQejBGIUWMAQLqcLr4huQekD5BLsdZA==", null, false, "02248ec5-bec5-4742-b617-99a4cc47eabd", false, "tom" },
                    { "bebe5dcc-4042-4ce2-8400-f47e6a01f433", 0, "", "93bb4590-5c75-461e-863c-bb42f4725531", "Bob", "bob@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEMsoRRy8xmphrw8mUkFFowlmCk8vQPX81LvaEmTuqhFrsH/AX7NPob2PpwoABwsCZQ==", null, false, "c6346759-046e-4456-9db7-d85b41aa76cb", false, "bob" },
                    { "f45bd1ac-2677-468c-9c1d-3b774ed2c3ab", 0, "", "9fabc2b9-a7f3-468e-baee-bebcaf1bb553", "Jane", "jane@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEL+YP0r5I4amtLI/V13AePyqb5nD7xdQBx6pnp+xuTGOCCryfQvgG/d1HJFveWdzHg==", null, false, "2872602f-846b-4100-a417-d233cdc33c04", false, "jane" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesAttendees_ActivityId",
                table: "ActivitiesAttendees",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivitiesAttendees_Activities_ActivityId",
                table: "ActivitiesAttendees",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivitiesAttendees_Activities_ActivityId",
                table: "ActivitiesAttendees");

            migrationBuilder.DropIndex(
                name: "IX_ActivitiesAttendees_ActivityId",
                table: "ActivitiesAttendees");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "017c17a5-351b-491c-a58f-fd12ebe52807");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "2642d3af-0cd7-4e05-8bf2-3398306e28f5");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "3d5b53ad-557f-470a-bb80-ef200486410e");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "442ec2a9-3060-4a1f-b628-2c9b98f355dd");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "48aeb038-d2ac-49ed-bb43-cef226766e26");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "9045c52a-1098-474d-bccf-d0bea5de51fd");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "9465dc0e-055e-4921-a87b-6b479404237e");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "b30132d7-e2aa-4490-96fb-cb8916079322");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "e787e01e-282d-4c4f-b80f-1e81e29cb6d2");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "fc8091ee-4df2-4fcb-a376-b3e6449b16d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45254f2a-7e2a-4f3a-9229-645f45d60fa7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bebe5dcc-4042-4ce2-8400-f47e6a01f433");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f45bd1ac-2677-468c-9c1d-3b774ed2c3ab");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ActivitiesAttendees_Activities_AppUserId",
                table: "ActivitiesAttendees",
                column: "AppUserId",
                principalTable: "Activities",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
