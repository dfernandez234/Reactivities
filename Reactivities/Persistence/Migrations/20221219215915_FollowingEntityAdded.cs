using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FollowingEntityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserFollowings",
                columns: table => new
                {
                    ObserverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TargetId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFollowings", x => new { x.ObserverId, x.TargetId });
                    table.ForeignKey(
                        name: "FK_UserFollowings_AspNetUsers_ObserverId",
                        column: x => x.ObserverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserFollowings_AspNetUsers_TargetId",
                        column: x => x.TargetId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "15c98ad8-1a10-4a16-a4e2-ac00bd224b10",
                column: "Date",
                value: new DateTime(2023, 6, 19, 15, 59, 15, 80, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "367d29d2-93fe-4346-bb60-030f82b5a404",
                column: "Date",
                value: new DateTime(2023, 1, 19, 15, 59, 15, 80, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "457d8bc2-c043-47fd-a346-9c80bbb0faf6",
                column: "Date",
                value: new DateTime(2023, 5, 19, 15, 59, 15, 80, DateTimeKind.Local).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "66daebb2-b0f6-49d9-89f9-011b7a5151b3",
                column: "Date",
                value: new DateTime(2023, 8, 19, 15, 59, 15, 80, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "6fa46c14-7d32-45af-9f49-96a93cca8e02",
                column: "Date",
                value: new DateTime(2022, 10, 19, 15, 59, 15, 80, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "b16a420b-2b43-46ec-9e04-1be283cd68cb",
                column: "Date",
                value: new DateTime(2022, 11, 19, 15, 59, 15, 80, DateTimeKind.Local).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d1110c65-87ae-4fcf-af8e-761890a3c80a",
                column: "Date",
                value: new DateTime(2023, 2, 19, 15, 59, 15, 80, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d50fc785-d15c-4faa-9e50-d456b132d508",
                column: "Date",
                value: new DateTime(2023, 4, 19, 15, 59, 15, 80, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "d9a5dbeb-2b83-4263-83f7-d033b7f345b1",
                column: "Date",
                value: new DateTime(2023, 7, 19, 15, 59, 15, 80, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "ActivityId",
                keyValue: "dd01183f-901e-411f-abae-3e065cb57456",
                column: "Date",
                value: new DateTime(2023, 3, 19, 15, 59, 15, 80, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07065484-6bbd-4ddd-9fad-ec075a068141",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4381782d-8954-44e9-b15e-50a6a99b0a3b", "AQAAAAIAAYagAAAAEKTgfdwnT3RngNb5Bq/FlVDmZ8LMLYC99N0JYo4SPeavt0qLpWWdxtFm0wKdONxP5A==", "4257ef85-3433-410a-b69b-818f9163e34b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3055acfb-e8b6-409c-8311-2302b75c37a9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cdb0583-1228-4e03-9ed1-301f1809df0d", "AQAAAAIAAYagAAAAEFVJ3slYU2przcSvJiBrkfzdnbuYS/BaKesguarp22AmX8xGcIeFCAwfwBeB4TQyfg==", "d50d7f0e-1946-4fc2-8680-42a93569a333" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83cdb3a7-126d-408f-85cb-b2036f57d83d", "AQAAAAIAAYagAAAAEBFHDlUIDIAwLG5clt0CL7DG118I9+ntoDytXACDX5xayN/8CAYL5HTNXwXM+JnLmg==", "9f173a8b-d66d-4038-8d0a-933490978cf2" });

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowings_TargetId",
                table: "UserFollowings",
                column: "TargetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFollowings");

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
        }
    }
}
