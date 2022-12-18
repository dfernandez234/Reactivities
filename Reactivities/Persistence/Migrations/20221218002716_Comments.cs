using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Comments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsMain",
                table: "Photos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ActivityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "15c98ad8-1a10-4a16-a4e2-ac00bd224b10",
                column: "Date",
                value: new DateTime(2023, 6, 17, 18, 27, 16, 253, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "367d29d2-93fe-4346-bb60-030f82b5a404",
                column: "Date",
                value: new DateTime(2023, 1, 17, 18, 27, 16, 253, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "457d8bc2-c043-47fd-a346-9c80bbb0faf6",
                column: "Date",
                value: new DateTime(2023, 5, 17, 18, 27, 16, 253, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "66daebb2-b0f6-49d9-89f9-011b7a5151b3",
                column: "Date",
                value: new DateTime(2023, 8, 17, 18, 27, 16, 253, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "6fa46c14-7d32-45af-9f49-96a93cca8e02",
                column: "Date",
                value: new DateTime(2022, 10, 17, 18, 27, 16, 253, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "b16a420b-2b43-46ec-9e04-1be283cd68cb",
                column: "Date",
                value: new DateTime(2022, 11, 17, 18, 27, 16, 253, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d1110c65-87ae-4fcf-af8e-761890a3c80a",
                column: "Date",
                value: new DateTime(2023, 2, 17, 18, 27, 16, 253, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d50fc785-d15c-4faa-9e50-d456b132d508",
                column: "Date",
                value: new DateTime(2023, 4, 17, 18, 27, 16, 253, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d9a5dbeb-2b83-4263-83f7-d033b7f345b1",
                column: "Date",
                value: new DateTime(2023, 7, 17, 18, 27, 16, 253, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "dd01183f-901e-411f-abae-3e065cb57456",
                column: "Date",
                value: new DateTime(2023, 3, 17, 18, 27, 16, 253, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07065484-6bbd-4ddd-9fad-ec075a068141",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1af547d-201c-4736-be9f-077e19f44caf", "AQAAAAIAAYagAAAAEGOZvD5o47G8Y+PT7+Vj2w3IVm3L+/0soZ+rJtJEDEtAVHi33MMk+jggxvUCLmXtmA==", "01f0e514-9614-44f3-a336-3c30a0163dfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3055acfb-e8b6-409c-8311-2302b75c37a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba43cdc9-8a89-4dc1-aaeb-a9cfa5d95daf", "AQAAAAIAAYagAAAAELVpUHRLLXJux4BmK1c21yfFnpYcyHEGEdv2y0x7kZ079RevPy7H7uwwYr/YdlTGXw==", "f5e27491-7ac2-4462-9d11-dfd564a9f9ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6f39bfc-82d5-4ee0-a51c-8faba627ef6f", "AQAAAAIAAYagAAAAEPK09Q6oibCW3BaxU6SJqm8eIZTo9eB/kY4QD9JlC4elrVnpbn84XsnlBINtzrpFTg==", "4fb36b0d-6c2e-44fb-b7ca-38d438378c07" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ActivityId",
                table: "Comments",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "IsMain",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

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
        }
    }
}
