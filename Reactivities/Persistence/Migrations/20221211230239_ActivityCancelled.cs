using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActivityCancelled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Activities",
                type: "INTEGER",
                nullable: false,
                defaultValue:false
            );

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
                    { "1199a9b9-8683-49f2-9397-095d37af2ecd", "Culture", "Paris", new DateTime(2023, 5, 11, 17, 2, 39, 359, DateTimeKind.Local).AddTicks(6086), "Activity 5 month in future", "Future Activity 5", "Musée d'Orsay" },
                    { "2b31af69-0b36-443b-9ace-ca59b7aa00d3", "Music", "Italy", new DateTime(2023, 6, 11, 17, 2, 39, 359, DateTimeKind.Local).AddTicks(6090), "Activity 6 month in future", "Future Activity 6", "Coliseum" },
                    { "608e0aea-1501-416c-9d3f-4d4405966883", "Drinks", "London", new DateTime(2022, 11, 11, 17, 2, 39, 359, DateTimeKind.Local).AddTicks(6013), "Activity 1 months ago", "Past Activity 1", "Pub" },
                    { "7811de8a-6615-42c0-b773-53f70b183f0c", "Culture", "London", new DateTime(2023, 1, 11, 17, 2, 39, 359, DateTimeKind.Local).AddTicks(6065), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { "81e32fd0-2e0e-4f26-82fb-703c6740439c", "Drinks", "London", new DateTime(2023, 4, 11, 17, 2, 39, 359, DateTimeKind.Local).AddTicks(6083), "Activity 4 month in future", "Future Activity 4", "Just Another Pub" },
                    { "859435a1-d287-4efa-85ab-c3d229dcc876", "Music", "London", new DateTime(2023, 2, 11, 17, 2, 39, 359, DateTimeKind.Local).AddTicks(6068), "Activity 2 month in future", "Future Activity 2", "02 Arena" },
                    { "8f4f2927-a5c8-4ab8-92e3-4103d17cef21", "Culture", "Paris", new DateTime(2022, 10, 11, 17, 2, 39, 359, DateTimeKind.Local).AddTicks(6061), "Activity 2 months ago", "Past Activity 2", "Louvre" },
                    { "bcdb7d9f-a5bd-4819-94d5-5c52941a7794", "Drinks", "London", new DateTime(2023, 3, 11, 17, 2, 39, 359, DateTimeKind.Local).AddTicks(6079), "Activity 3 month in future", "Future Activity 3", "Another Pub" },
                    { "f685ae68-cf18-43d8-ac05-8fdf7e9ccdec", "Drinks", "London", new DateTime(2023, 7, 11, 17, 2, 39, 359, DateTimeKind.Local).AddTicks(6094), "Activity 7 month in future", "Future Activity 7", "Another Pub Again" },
                    { "f8464cff-8b48-43c8-a376-37306cbe235f", "Drinks", "Paris", new DateTime(2023, 8, 11, 17, 2, 39, 359, DateTimeKind.Local).AddTicks(6098), "Activity 8 month in future", "Future Activity 8", "Ritz Hotel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "28606032-d6fc-4d08-9e76-dc4237fa5a3d", 0, "", "25fd1950-2675-4771-941e-3bf240637246", "Tom", "tom@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEIIOZLllwMEo6mRfSqNKZpZiq6kbU22LaHB+0ldA+POcfH0nre0wh2Tc3GuSJiYVkQ==", null, false, "0fbd095e-fa43-4359-bcfb-ced072929a05", false, "tom" },
                    { "2c17a51e-b074-4576-b6b5-94335686303d", 0, "", "3b5dcd64-368f-4338-b07e-101e5a93da60", "Jane", "jane@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAELd+x6yyievoYXuDXA3bsWbVPVuIo6ecXNJuUn8Ay4iBIK1Nt/3CAmjTJiD/fnyzow==", null, false, "020d9cff-59cc-4df4-8a3e-a35458776ded", false, "jane" },
                    { "df9291d3-a4df-454b-97b0-afd7e72d9a0d", 0, "", "5a4ff96a-88e2-4f4c-9b97-6dc38210cd4b", "Bob", "bob@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEKIF3NAvpDUXx5wraEkDFIsopK4+dnHdIlBLmuGm4aqSa6Pl2aG/IIWJ01vfTv3ogw==", null, false, "23583915-febd-4fa6-a2fd-7646d5208257", false, "bob" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "1199a9b9-8683-49f2-9397-095d37af2ecd");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "2b31af69-0b36-443b-9ace-ca59b7aa00d3");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "608e0aea-1501-416c-9d3f-4d4405966883");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "7811de8a-6615-42c0-b773-53f70b183f0c");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "81e32fd0-2e0e-4f26-82fb-703c6740439c");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "859435a1-d287-4efa-85ab-c3d229dcc876");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "8f4f2927-a5c8-4ab8-92e3-4103d17cef21");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "bcdb7d9f-a5bd-4819-94d5-5c52941a7794");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "f685ae68-cf18-43d8-ac05-8fdf7e9ccdec");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "f8464cff-8b48-43c8-a376-37306cbe235f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28606032-d6fc-4d08-9e76-dc4237fa5a3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c17a51e-b074-4576-b6b5-94335686303d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df9291d3-a4df-454b-97b0-afd7e72d9a0d");

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
        }
    }
}
