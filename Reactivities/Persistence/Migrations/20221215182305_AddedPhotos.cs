using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "15c98ad8-1a10-4a16-a4e2-ac00bd224b10",
                column: "Date",
                value: new DateTime(2023, 6, 15, 12, 23, 5, 363, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "367d29d2-93fe-4346-bb60-030f82b5a404",
                column: "Date",
                value: new DateTime(2023, 1, 15, 12, 23, 5, 363, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "457d8bc2-c043-47fd-a346-9c80bbb0faf6",
                column: "Date",
                value: new DateTime(2023, 5, 15, 12, 23, 5, 363, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "66daebb2-b0f6-49d9-89f9-011b7a5151b3",
                column: "Date",
                value: new DateTime(2023, 8, 15, 12, 23, 5, 363, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "6fa46c14-7d32-45af-9f49-96a93cca8e02",
                column: "Date",
                value: new DateTime(2022, 10, 15, 12, 23, 5, 363, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "b16a420b-2b43-46ec-9e04-1be283cd68cb",
                column: "Date",
                value: new DateTime(2022, 11, 15, 12, 23, 5, 363, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d1110c65-87ae-4fcf-af8e-761890a3c80a",
                column: "Date",
                value: new DateTime(2023, 2, 15, 12, 23, 5, 363, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d50fc785-d15c-4faa-9e50-d456b132d508",
                column: "Date",
                value: new DateTime(2023, 4, 15, 12, 23, 5, 363, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d9a5dbeb-2b83-4263-83f7-d033b7f345b1",
                column: "Date",
                value: new DateTime(2023, 7, 15, 12, 23, 5, 363, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "dd01183f-901e-411f-abae-3e065cb57456",
                column: "Date",
                value: new DateTime(2023, 3, 15, 12, 23, 5, 363, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07065484-6bbd-4ddd-9fad-ec075a068141",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e702d72-6d33-4fc8-bbbf-a1583cc0beeb", "AQAAAAIAAYagAAAAEOU4hgoKzTqQYlg/0Wl0qSVt1RB2YVbBQRYY1om4jDb6NdeJ2aSAvLuSWSR+49hMQg==", "5c4ae667-d943-4b0e-83fd-51581d916ade" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3055acfb-e8b6-409c-8311-2302b75c37a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0398651d-e9d8-4d37-9b0a-268b634ec728", "AQAAAAIAAYagAAAAEIT7I9CKj70Fj2ngs76fG3jkoMzqijCEMDNc6SE44PXlOVF2gu9D2KHvck4IKvI8mA==", "7e4d1d87-a112-47db-922e-d2535b6a9ac9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcea775f-be43-4e23-8323-94983258bed0", "AQAAAAIAAYagAAAAEHbcW6O0Cv+G1EWC78G+gvPnzT8j+iGxKX9/S9eUnX2LQxH7Otxh0qezwA35Mr+NZw==", "4a87ca34-575f-4717-89e3-8e14b1676839" });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_AppUserId",
                table: "Photos",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "15c98ad8-1a10-4a16-a4e2-ac00bd224b10",
                column: "Date",
                value: new DateTime(2023, 6, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "367d29d2-93fe-4346-bb60-030f82b5a404",
                column: "Date",
                value: new DateTime(2023, 1, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "457d8bc2-c043-47fd-a346-9c80bbb0faf6",
                column: "Date",
                value: new DateTime(2023, 5, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "66daebb2-b0f6-49d9-89f9-011b7a5151b3",
                column: "Date",
                value: new DateTime(2023, 8, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "6fa46c14-7d32-45af-9f49-96a93cca8e02",
                column: "Date",
                value: new DateTime(2022, 10, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "b16a420b-2b43-46ec-9e04-1be283cd68cb",
                column: "Date",
                value: new DateTime(2022, 11, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d1110c65-87ae-4fcf-af8e-761890a3c80a",
                column: "Date",
                value: new DateTime(2023, 2, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d50fc785-d15c-4faa-9e50-d456b132d508",
                column: "Date",
                value: new DateTime(2023, 4, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d9a5dbeb-2b83-4263-83f7-d033b7f345b1",
                column: "Date",
                value: new DateTime(2023, 7, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "dd01183f-901e-411f-abae-3e065cb57456",
                column: "Date",
                value: new DateTime(2023, 3, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07065484-6bbd-4ddd-9fad-ec075a068141",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa1518c7-864e-4dc6-8902-77a80ae2766b", "AQAAAAIAAYagAAAAEJVjHkp3v7yPeuP1pgPL/0PVKcV9A6XUaIxbfxuLKR5skksWoOsEES8f1MewN2WNDg==", "71db655d-ac5c-4afb-95e0-268dce753674" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3055acfb-e8b6-409c-8311-2302b75c37a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cf6b718-a6b1-48e0-b18f-81e5d27ce780", "AQAAAAIAAYagAAAAEKkJVUryDpOn3QK1TcC1Gyjk0bmfUudUBB47YkjHxzf6pdl4auOoFAP2+hbUEuUPpg==", "7cbdc912-0131-438c-9c61-f3b02b4d1d36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "858e7280-0a47-4243-8735-9ba0f3942619", "AQAAAAIAAYagAAAAEI/R96Yust3tU2+KQ9mb9DSK0hyp+CoAp2gHqfUrKRI+s/LevLy5q3GyQxzYJ3f0zA==", "411b51f3-9890-435e-b496-32f426a623eb" });
        }
    }
}
