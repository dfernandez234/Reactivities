using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reactivities.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Venue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
