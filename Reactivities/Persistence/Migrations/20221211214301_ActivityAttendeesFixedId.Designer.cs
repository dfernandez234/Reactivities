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
    [Migration("20221211214301_ActivityAttendeesFixedId")]
    partial class ActivityAttendeesFixedId
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
                            ActivityId = "6c3d9fb0-340e-4bcd-8799-35ddc01cad50",
                            Category = "Drinks",
                            City = "London",
                            Date = new DateTime(2022, 11, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7068),
                            Description = "Activity 1 months ago",
                            Title = "Past Activity 1",
                            Venue = "Pub"
                        },
                        new
                        {
                            ActivityId = "767220aa-9f47-4386-9b21-4563900007cd",
                            Category = "Culture",
                            City = "Paris",
                            Date = new DateTime(2022, 10, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7132),
                            Description = "Activity 2 months ago",
                            Title = "Past Activity 2",
                            Venue = "Louvre"
                        },
                        new
                        {
                            ActivityId = "0119b73d-2738-42ff-a718-ba21da97dd3e",
                            Category = "Culture",
                            City = "London",
                            Date = new DateTime(2023, 1, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7138),
                            Description = "Activity 1 month in future",
                            Title = "Future Activity 1",
                            Venue = "Natural History Museum"
                        },
                        new
                        {
                            ActivityId = "8cab35bd-eaf1-409e-b0a2-659d4fdff8ee",
                            Category = "Music",
                            City = "London",
                            Date = new DateTime(2023, 2, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7143),
                            Description = "Activity 2 month in future",
                            Title = "Future Activity 2",
                            Venue = "02 Arena"
                        },
                        new
                        {
                            ActivityId = "f5f5cd06-b71e-42a0-bca9-f2e5e6bd53c9",
                            Category = "Drinks",
                            City = "London",
                            Date = new DateTime(2023, 3, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7148),
                            Description = "Activity 3 month in future",
                            Title = "Future Activity 3",
                            Venue = "Another Pub"
                        },
                        new
                        {
                            ActivityId = "211dc6e1-afb5-4c52-9521-c9b6772249dd",
                            Category = "Drinks",
                            City = "London",
                            Date = new DateTime(2023, 4, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7153),
                            Description = "Activity 4 month in future",
                            Title = "Future Activity 4",
                            Venue = "Just Another Pub"
                        },
                        new
                        {
                            ActivityId = "3e5fe89e-646d-4ac2-a8cf-dcb73ab34c04",
                            Category = "Culture",
                            City = "Paris",
                            Date = new DateTime(2023, 5, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7158),
                            Description = "Activity 5 month in future",
                            Title = "Future Activity 5",
                            Venue = "Musée d'Orsay"
                        },
                        new
                        {
                            ActivityId = "7b2ab7bc-89ce-422a-9737-c46054abb1e3",
                            Category = "Music",
                            City = "Italy",
                            Date = new DateTime(2023, 6, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7163),
                            Description = "Activity 6 month in future",
                            Title = "Future Activity 6",
                            Venue = "Coliseum"
                        },
                        new
                        {
                            ActivityId = "af0d38d9-f6c6-4db9-a2e8-58c8b107155e",
                            Category = "Drinks",
                            City = "London",
                            Date = new DateTime(2023, 7, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7170),
                            Description = "Activity 7 month in future",
                            Title = "Future Activity 7",
                            Venue = "Another Pub Again"
                        },
                        new
                        {
                            ActivityId = "308c248c-2a00-4a4a-875f-99121904aa79",
                            Category = "Drinks",
                            City = "Paris",
                            Date = new DateTime(2023, 8, 11, 15, 43, 0, 781, DateTimeKind.Local).AddTicks(7175),
                            Description = "Activity 8 month in future",
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

                    b.ToTable("ActivitiesAttendees");
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
                            Id = "69007e27-e5df-4877-b3d5-e5ae3bb3e389",
                            AccessFailedCount = 0,
                            Bio = "",
                            ConcurrencyStamp = "033b695c-477a-421b-99d5-277c2f559ad6",
                            DisplayName = "Bob",
                            Email = "bob@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEEVbLQPV5sjtzKt7+6yLi8w4UQOtoNpqZUO6w/F2zJs5b/UTebN5IiH10YJAJJccHg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "88170e8c-df57-4e5b-a70b-8dd20b708734",
                            TwoFactorEnabled = false,
                            UserName = "bob"
                        },
                        new
                        {
                            Id = "2d66a081-f6ee-4569-a846-c0e52081960f",
                            AccessFailedCount = 0,
                            Bio = "",
                            ConcurrencyStamp = "e809d4b3-3164-4836-b3cb-226695dd91f3",
                            DisplayName = "Tom",
                            Email = "tom@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAEEMMFCP+oCGm1s89LLZ97fs+d14Y6T6a+sJkdeO0aNon20ht+8LhgOsv8Ebxf/abCg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c54352c0-c93d-41cd-bdaf-35c4b0bbacc5",
                            TwoFactorEnabled = false,
                            UserName = "tom"
                        },
                        new
                        {
                            Id = "6a2880dd-a1c7-47bc-bb1c-8aa05743d7ec",
                            AccessFailedCount = 0,
                            Bio = "",
                            ConcurrencyStamp = "0f0d3d2c-5b92-4895-ab75-6ecc1d2b5e31",
                            DisplayName = "Jane",
                            Email = "jane@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAELf+cb3/bKFvZJ+DQlgdRUcsOdK2Pm9YUfpo/CF+/VFrixdafcSqiHAKcR5FcfQIvg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f12fde2b-2921-4a5f-b415-3b5d2c1eac0d",
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
                        .HasForeignKey("AppUserId")
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