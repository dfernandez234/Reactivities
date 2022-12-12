using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActivityCancelledType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Activities",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "Activities");

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
    }
}
