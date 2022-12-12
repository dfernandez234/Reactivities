using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ActivityAttendeesSSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

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
    }
}
