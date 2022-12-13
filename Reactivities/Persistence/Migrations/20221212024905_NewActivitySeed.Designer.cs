﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reactivities.Infrastructure.Persistence.Context;

#nullable disable

namespace Reactivities.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221212024905_NewActivitySeed")]
    partial class NewActivitySeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Reactivities.Domain.Entities.Activity", b =>
                {
                    b.Property<string>("ActivityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Venue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityId");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            ActivityId = "b16a420b-2b43-46ec-9e04-1be283cd68cb",
                            Category = "Drinks",
                            City = "London",
                            Date = new DateTime(2022, 11, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2676),
                            Description = "Activity 1 months ago",
                            IsCancelled = false,
                            Title = "Past Activity 1",
                            Venue = "Pub"
                        },
                        new
                        {
                            ActivityId = "6fa46c14-7d32-45af-9f49-96a93cca8e02",
                            Category = "Culture",
                            City = "Paris",
                            Date = new DateTime(2022, 10, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2725),
                            Description = "Activity 2 months ago",
                            IsCancelled = false,
                            Title = "Past Activity 2",
                            Venue = "Louvre"
                        },
                        new
                        {
                            ActivityId = "367d29d2-93fe-4346-bb60-030f82b5a404",
                            Category = "Culture",
                            City = "London",
                            Date = new DateTime(2023, 1, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2752),
                            Description = "Activity 1 month in future",
                            IsCancelled = false,
                            Title = "Future Activity 1",
                            Venue = "Natural History Museum"
                        },
                        new
                        {
                            ActivityId = "d1110c65-87ae-4fcf-af8e-761890a3c80a",
                            Category = "Music",
                            City = "London",
                            Date = new DateTime(2023, 2, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2756),
                            Description = "Activity 2 month in future",
                            IsCancelled = false,
                            Title = "Future Activity 2",
                            Venue = "02 Arena"
                        },
                        new
                        {
                            ActivityId = "dd01183f-901e-411f-abae-3e065cb57456",
                            Category = "Drinks",
                            City = "London",
                            Date = new DateTime(2023, 3, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2760),
                            Description = "Activity 3 month in future",
                            IsCancelled = false,
                            Title = "Future Activity 3",
                            Venue = "Another Pub"
                        },
                        new
                        {
                            ActivityId = "d50fc785-d15c-4faa-9e50-d456b132d508",
                            Category = "Drinks",
                            City = "London",
                            Date = new DateTime(2023, 4, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2764),
                            Description = "Activity 4 month in future",
                            IsCancelled = false,
                            Title = "Future Activity 4",
                            Venue = "Just Another Pub"
                        },
                        new
                        {
                            ActivityId = "457d8bc2-c043-47fd-a346-9c80bbb0faf6",
                            Category = "Culture",
                            City = "Paris",
                            Date = new DateTime(2023, 5, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2767),
                            Description = "Activity 5 month in future",
                            IsCancelled = false,
                            Title = "Future Activity 5",
                            Venue = "Musée d'Orsay"
                        },
                        new
                        {
                            ActivityId = "15c98ad8-1a10-4a16-a4e2-ac00bd224b10",
                            Category = "Music",
                            City = "Italy",
                            Date = new DateTime(2023, 6, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2831),
                            Description = "Activity 6 month in future",
                            IsCancelled = false,
                            Title = "Future Activity 6",
                            Venue = "Coliseum"
                        },
                        new
                        {
                            ActivityId = "d9a5dbeb-2b83-4263-83f7-d033b7f345b1",
                            Category = "Drinks",
                            City = "London",
                            Date = new DateTime(2023, 7, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2836),
                            Description = "Activity 7 month in future",
                            IsCancelled = false,
                            Title = "Future Activity 7",
                            Venue = "Another Pub Again"
                        },
                        new
                        {
                            ActivityId = "66daebb2-b0f6-49d9-89f9-011b7a5151b3",
                            Category = "Drinks",
                            City = "Paris",
                            Date = new DateTime(2023, 8, 11, 20, 49, 4, 769, DateTimeKind.Local).AddTicks(2841),
                            Description = "Activity 8 month in future",
                            IsCancelled = false,
                            Title = "Future Activity 8",
                            Venue = "Ritz Hotel"
                        });
                });

            modelBuilder.Entity("Reactivities.Domain.Entities.ActivityAttendee", b =>
                {
                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActivityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsHost")
                        .HasColumnType("bit");

                    b.HasKey("AppUserId", "ActivityId");

                    b.HasIndex("ActivityId");

                    b.ToTable("ActivitiesAttendees");

                    b.HasData(
                        new
                        {
                            AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                            ActivityId = "b16a420b-2b43-46ec-9e04-1be283cd68cb",
                            IsHost = true
                        },
                        new
                        {
                            AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                            ActivityId = "6fa46c14-7d32-45af-9f49-96a93cca8e02",
                            IsHost = true
                        },
                        new
                        {
                            AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                            ActivityId = "6fa46c14-7d32-45af-9f49-96a93cca8e02",
                            IsHost = false
                        },
                        new
                        {
                            AppUserId = "07065484-6bbd-4ddd-9fad-ec075a068141",
                            ActivityId = "367d29d2-93fe-4346-bb60-030f82b5a404",
                            IsHost = true
                        },
                        new
                        {
                            AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                            ActivityId = "367d29d2-93fe-4346-bb60-030f82b5a404",
                            IsHost = false
                        },
                        new
                        {
                            AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                            ActivityId = "d1110c65-87ae-4fcf-af8e-761890a3c80a",
                            IsHost = true
                        },
                        new
                        {
                            AppUserId = "07065484-6bbd-4ddd-9fad-ec075a068141",
                            ActivityId = "d1110c65-87ae-4fcf-af8e-761890a3c80a",
                            IsHost = false
                        },
                        new
                        {
                            AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                            ActivityId = "dd01183f-901e-411f-abae-3e065cb57456",
                            IsHost = true
                        },
                        new
                        {
                            AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                            ActivityId = "dd01183f-901e-411f-abae-3e065cb57456",
                            IsHost = false
                        },
                        new
                        {
                            AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                            ActivityId = "d50fc785-d15c-4faa-9e50-d456b132d508",
                            IsHost = true
                        },
                        new
                        {
                            AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                            ActivityId = "457d8bc2-c043-47fd-a346-9c80bbb0faf6",
                            IsHost = true
                        },
                        new
                        {
                            AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                            ActivityId = "457d8bc2-c043-47fd-a346-9c80bbb0faf6",
                            IsHost = false
                        },
                        new
                        {
                            AppUserId = "07065484-6bbd-4ddd-9fad-ec075a068141",
                            ActivityId = "15c98ad8-1a10-4a16-a4e2-ac00bd224b10",
                            IsHost = true
                        },
                        new
                        {
                            AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                            ActivityId = "15c98ad8-1a10-4a16-a4e2-ac00bd224b10",
                            IsHost = false
                        },
                        new
                        {
                            AppUserId = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                            ActivityId = "d9a5dbeb-2b83-4263-83f7-d033b7f345b1",
                            IsHost = true
                        },
                        new
                        {
                            AppUserId = "07065484-6bbd-4ddd-9fad-ec075a068141",
                            ActivityId = "d9a5dbeb-2b83-4263-83f7-d033b7f345b1",
                            IsHost = false
                        },
                        new
                        {
                            AppUserId = "07065484-6bbd-4ddd-9fad-ec075a068141",
                            ActivityId = "66daebb2-b0f6-49d9-89f9-011b7a5151b3",
                            IsHost = true
                        },
                        new
                        {
                            AppUserId = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                            ActivityId = "66daebb2-b0f6-49d9-89f9-011b7a5151b3",
                            IsHost = false
                        });
                });

            modelBuilder.Entity("Reactivities.Domain.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3055acfb-e8b6-409c-8311-2302b75c37a9",
                            AccessFailedCount = 0,
                            Bio = "",
                            ConcurrencyStamp = "5cf6b718-a6b1-48e0-b18f-81e5d27ce780",
                            DisplayName = "Bob",
                            Email = "bob@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "BOB@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEKkJVUryDpOn3QK1TcC1Gyjk0bmfUudUBB47YkjHxzf6pdl4auOoFAP2+hbUEuUPpg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7cbdc912-0131-438c-9c61-f3b02b4d1d36",
                            TwoFactorEnabled = false,
                            UserName = "bob"
                        },
                        new
                        {
                            Id = "53503633-08ab-4c93-a2a1-5f8ea67229fd",
                            AccessFailedCount = 0,
                            Bio = "",
                            ConcurrencyStamp = "858e7280-0a47-4243-8735-9ba0f3942619",
                            DisplayName = "Tom",
                            Email = "tom@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "TOM@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEI/R96Yust3tU2+KQ9mb9DSK0hyp+CoAp2gHqfUrKRI+s/LevLy5q3GyQxzYJ3f0zA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "411b51f3-9890-435e-b496-32f426a623eb",
                            TwoFactorEnabled = false,
                            UserName = "tom"
                        },
                        new
                        {
                            Id = "07065484-6bbd-4ddd-9fad-ec075a068141",
                            AccessFailedCount = 0,
                            Bio = "",
                            ConcurrencyStamp = "fa1518c7-864e-4dc6-8902-77a80ae2766b",
                            DisplayName = "Jane",
                            Email = "jane@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "JANE@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJVjHkp3v7yPeuP1pgPL/0PVKcV9A6XUaIxbfxuLKR5skksWoOsEES8f1MewN2WNDg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "71db655d-ac5c-4afb-95e0-268dce753674",
                            TwoFactorEnabled = false,
                            UserName = "jane"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Reactivities.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Reactivities.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reactivities.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Reactivities.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Reactivities.Domain.Entities.ActivityAttendee", b =>
                {
                    b.HasOne("Reactivities.Domain.Entities.Activity", "Activity")
                        .WithMany("Attendees")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reactivities.Domain.Entities.AppUser", "AppUser")
                        .WithMany("Activities")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Reactivities.Domain.Entities.Activity", b =>
                {
                    b.Navigation("Attendees");
                });

            modelBuilder.Entity("Reactivities.Domain.Entities.AppUser", b =>
                {
                    b.Navigation("Activities");
                });
#pragma warning restore 612, 618
        }
    }
}