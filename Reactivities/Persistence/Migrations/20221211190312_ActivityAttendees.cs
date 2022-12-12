using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActivityAttendees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities",
                table: "Activities");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1defc91c-d5fc-4c8c-90f5-fd3f0e7b929f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fa72a24-4691-4b4f-add0-45980de073f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f2c965e-d2db-4690-b9ef-63c383bbc52a");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Activities");

            migrationBuilder.AddColumn<string>(
                name: "ActivityId",
                table: "Activities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities",
                table: "Activities",
                column: "ActivityId");

            migrationBuilder.CreateTable(
                name: "ActivitiesAttendees",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2fa03324-6204-4714-9914-e3b32e932c16", 0, "", "fc9f6a23-ac54-4cc8-b4f4-5e63761f6632", "Jane", "jane@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAELGEfuxTFm0Dq7Rku8zdUVt1r7mKRFxcW7Zfx6+UpRqTn6NHohB9B5r7v1r84g6xXw==", null, false, "c53ced4b-9429-4177-a885-b203dd9c5f24", false, "jane" },
                    { "bdc2c73e-f8cf-4371-bf42-1aa5e414f452", 0, "", "fff4d9e6-ebe1-4864-9f01-07c7d89862fc", "Tom", "tom@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEHA2xnO9TSJvTXvoZ2SlNBEKOW+UFrnty+vidrX7R3udjmeXVFLnZ3h4pgd4tYFTSg==", null, false, "38dbdfb3-2b51-469c-9d09-08bdf47afd6d", false, "tom" },
                    { "d770e92d-4a7a-4eb4-9a5a-b7988851ef1c", 0, "", "a745d875-9f79-4026-9346-0b751dd5488b", "Bob", "bob@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEB8Xw+sTFnwE5ibtHF1V5xY0+G2qhMCECqpHsT3tAaGTQNKHFBzwM7jlWoQxeZpUdw==", null, false, "0cced7a5-8d52-465e-a49b-e107a322e780", false, "bob" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitiesAttendees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities",
                table: "Activities");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fa03324-6204-4714-9914-e3b32e932c16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdc2c73e-f8cf-4371-bf42-1aa5e414f452");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d770e92d-4a7a-4eb4-9a5a-b7988851ef1c");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "Activities");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities",
                table: "Activities",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("061d521e-e288-4ed1-b912-550ae6ef035c"), "Culture", "Paris", new DateTime(2022, 10, 8, 17, 55, 18, 137, DateTimeKind.Local).AddTicks(8713), "Activity 2 months ago", "Past Activity 2", "Louvre" },
                    { new Guid("365f1f98-5e1e-4e65-a8e3-0a468457581a"), "Music", "London", new DateTime(2023, 2, 8, 17, 55, 18, 137, DateTimeKind.Local).AddTicks(8725), "Activity 2 month in future", "Future Activity 2", "02 Arena" },
                    { new Guid("49a9dad3-69b0-4dc9-8e70-d4da16eb0aed"), "Drinks", "London", new DateTime(2023, 3, 8, 17, 55, 18, 137, DateTimeKind.Local).AddTicks(8728), "Activity 3 month in future", "Future Activity 3", "Another Pub" },
                    { new Guid("7297d931-7141-478d-a2e6-129ae12443bc"), "Music", "Italy", new DateTime(2023, 6, 8, 17, 55, 18, 137, DateTimeKind.Local).AddTicks(8734), "Activity 6 month in future", "Future Activity 6", "Coliseum" },
                    { new Guid("8397c5c6-557b-4ead-84e1-6c2817506622"), "Culture", "London", new DateTime(2023, 1, 8, 17, 55, 18, 137, DateTimeKind.Local).AddTicks(8723), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("a396aaab-6f7a-420c-9a18-84660c291fc4"), "Drinks", "London", new DateTime(2022, 11, 8, 17, 55, 18, 137, DateTimeKind.Local).AddTicks(8663), "Activity 1 months ago", "Past Activity 1", "Pub" },
                    { new Guid("a3aa4bee-5e11-4eef-9fa7-406b242bc56c"), "Drinks", "London", new DateTime(2023, 7, 8, 17, 55, 18, 137, DateTimeKind.Local).AddTicks(8736), "Activity 7 month in future", "Future Activity 7", "Another Pub Again" },
                    { new Guid("b4f29600-ae80-4bc6-b6b1-56627ff95d72"), "Drinks", "London", new DateTime(2023, 4, 8, 17, 55, 18, 137, DateTimeKind.Local).AddTicks(8730), "Activity 4 month in future", "Future Activity 4", "Just Another Pub" },
                    { new Guid("c4f128c2-c591-4445-901e-edcae131cf1b"), "Drinks", "Paris", new DateTime(2023, 8, 8, 17, 55, 18, 137, DateTimeKind.Local).AddTicks(8739), "Activity 8 month in future", "Future Activity 8", "Ritz Hotel" },
                    { new Guid("ce3b5bc9-e21f-4516-b92a-98c57fd28730"), "Culture", "Paris", new DateTime(2023, 5, 8, 17, 55, 18, 137, DateTimeKind.Local).AddTicks(8732), "Activity 5 month in future", "Future Activity 5", "Musée d'Orsay" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1defc91c-d5fc-4c8c-90f5-fd3f0e7b929f", 0, "", "8e12d9be-bd58-4c55-81af-1b60cef3fbe4", "Bob", "bob@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEBIzulR7Swng13NnW8VP8NBuPTY21nI4brKbiPwEZZQSbwJOqDVEroH/jP+egYp9cA==", null, false, "94e304b8-0acb-425b-8e10-b5ca3c573074", false, "bob" },
                    { "3fa72a24-4691-4b4f-add0-45980de073f7", 0, "", "2f14d8a0-7f99-43e0-887f-f35d12047c77", "Tom", "tom@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAELutKnCFqu0SFxIMWus5s8hMeL3X43FZmIFxOnxCvZgT7Z/3G9fQWE1qJfngEaZRKA==", null, false, "9cdac2fb-8bb9-4be2-820b-650fa455a943", false, "tom" },
                    { "5f2c965e-d2db-4690-b9ef-63c383bbc52a", 0, "", "8a3b1c9f-0acb-4c79-9f7f-b480d516cd48", "Jane", "jane@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEF/sJ/1QdrGMGAPAzU9KxIqZC50Y7nW5VkqUZoSYGPLODLERgYiJi3BzRl8G2ddPGw==", null, false, "d51185dd-28f4-4df2-8393-7a71749da314", false, "jane" }
                });
        }
    }
}
