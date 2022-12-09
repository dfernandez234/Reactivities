using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NullableBio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("09f2a431-bd6a-4726-b11d-dd72e4cfe3ee"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("19bd71dc-bf23-4d9f-b4dd-1596e58a22d6"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1d5348ee-7d82-4adf-9c9f-abe659eac2db"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5e5e30ea-3391-488a-a111-4ad76eeda735"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("89174de3-50dd-490d-83cd-0b936c479dfa"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b10eec72-41d7-487c-ae0d-cf667f2b1bbd"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b3f0ca65-ac5f-4da0-aeae-be0dc97ec915"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b991e780-f59e-49d7-a3b1-59477cd5958c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("cac8fced-d322-4d46-89fb-91dda4654750"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f2a3df0c-23f7-4580-bf72-4fac82228276"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fc1c068-f58c-41b3-a37a-8a6ebd9d7376");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e498555-51f0-491c-8a4d-1fc6fafdcc1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0533685-0b84-4bb1-ac82-20bbab28f4d5");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("061d521e-e288-4ed1-b912-550ae6ef035c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("365f1f98-5e1e-4e65-a8e3-0a468457581a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("49a9dad3-69b0-4dc9-8e70-d4da16eb0aed"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("7297d931-7141-478d-a2e6-129ae12443bc"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8397c5c6-557b-4ead-84e1-6c2817506622"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a396aaab-6f7a-420c-9a18-84660c291fc4"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a3aa4bee-5e11-4eef-9fa7-406b242bc56c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b4f29600-ae80-4bc6-b6b1-56627ff95d72"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("c4f128c2-c591-4445-901e-edcae131cf1b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ce3b5bc9-e21f-4516-b92a-98c57fd28730"));

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

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("09f2a431-bd6a-4726-b11d-dd72e4cfe3ee"), "Music", "London", new DateTime(2023, 2, 7, 16, 22, 54, 155, DateTimeKind.Local).AddTicks(8893), "Activity 2 month in future", "Future Activity 2", "02 Arena" },
                    { new Guid("19bd71dc-bf23-4d9f-b4dd-1596e58a22d6"), "Drinks", "Paris", new DateTime(2023, 8, 7, 16, 22, 54, 155, DateTimeKind.Local).AddTicks(8907), "Activity 8 month in future", "Future Activity 8", "Ritz Hotel" },
                    { new Guid("1d5348ee-7d82-4adf-9c9f-abe659eac2db"), "Culture", "London", new DateTime(2023, 1, 7, 16, 22, 54, 155, DateTimeKind.Local).AddTicks(8891), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("5e5e30ea-3391-488a-a111-4ad76eeda735"), "Drinks", "London", new DateTime(2023, 7, 7, 16, 22, 54, 155, DateTimeKind.Local).AddTicks(8905), "Activity 7 month in future", "Future Activity 7", "Another Pub Again" },
                    { new Guid("89174de3-50dd-490d-83cd-0b936c479dfa"), "Culture", "Paris", new DateTime(2023, 5, 7, 16, 22, 54, 155, DateTimeKind.Local).AddTicks(8900), "Activity 5 month in future", "Future Activity 5", "Musée d'Orsay" },
                    { new Guid("b10eec72-41d7-487c-ae0d-cf667f2b1bbd"), "Drinks", "London", new DateTime(2023, 4, 7, 16, 22, 54, 155, DateTimeKind.Local).AddTicks(8898), "Activity 4 month in future", "Future Activity 4", "Just Another Pub" },
                    { new Guid("b3f0ca65-ac5f-4da0-aeae-be0dc97ec915"), "Drinks", "London", new DateTime(2022, 11, 7, 16, 22, 54, 155, DateTimeKind.Local).AddTicks(8837), "Activity 1 months ago", "Past Activity 1", "Pub" },
                    { new Guid("b991e780-f59e-49d7-a3b1-59477cd5958c"), "Music", "Italy", new DateTime(2023, 6, 7, 16, 22, 54, 155, DateTimeKind.Local).AddTicks(8903), "Activity 6 month in future", "Future Activity 6", "Coliseum" },
                    { new Guid("cac8fced-d322-4d46-89fb-91dda4654750"), "Culture", "Paris", new DateTime(2022, 10, 7, 16, 22, 54, 155, DateTimeKind.Local).AddTicks(8881), "Activity 2 months ago", "Past Activity 2", "Louvre" },
                    { new Guid("f2a3df0c-23f7-4580-bf72-4fac82228276"), "Drinks", "London", new DateTime(2023, 3, 7, 16, 22, 54, 155, DateTimeKind.Local).AddTicks(8896), "Activity 3 month in future", "Future Activity 3", "Another Pub" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2fc1c068-f58c-41b3-a37a-8a6ebd9d7376", 0, "", "3037198d-84a8-4381-8721-6055b3e0580f", "Jane", "jane@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEL/RcR2qtYO+MFNTJHGbrh2Ehs2+jb155gF5F4yjYlrMVOPbYSUKrSaDmcqP2vWsoQ==", null, false, "81379522-3f4b-4dd9-a64d-9914382aa582", false, "jane" },
                    { "7e498555-51f0-491c-8a4d-1fc6fafdcc1c", 0, "", "bf688dc8-e4f4-44f9-acf5-507af9eb4dd2", "Bob", "bob@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAENPOWv9wn43oPWkzv2+Bo5W6g8c7C5VDDVn1evq3vGC4TDwyv00SpMgj3FlzsV953g==", null, false, "fccfd97d-da4f-4c93-9f2f-d30f958d0153", false, "bob" },
                    { "b0533685-0b84-4bb1-ac82-20bbab28f4d5", 0, "", "bbae0955-53e1-4ef4-9593-f4e80283988d", "Tom", "tom@test.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEFlm8O6HVDknps2C5xWpQ5nJapSFvX+pcygnrYBklul2ORi2hhRvloKuIQviMctg3A==", null, false, "5fcbdb1f-8997-4640-8dfb-1cdb58c645fd", false, "tom" }
                });
        }
    }
}
