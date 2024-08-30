﻿// <auto-generated />
using System;
using MemoryMagi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MemoryMagi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MemoryMagi.Models.AllowedUser", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("user_id");

                    b.Property<int>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("game_id");

                    b.HasKey("UserId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("AllowedUsers");
                });

            modelBuilder.Entity("MemoryMagi.Models.CategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "images/Veteran_car.jpg",
                            Name = "Frukt"
                        },
                        new
                        {
                            Id = 2,
                            Image = "images/Veteran_car.jpg",
                            Name = "Alkohol"
                        },
                        new
                        {
                            Id = 3,
                            Image = "images/Veteran_car.jpg",
                            Name = "Djur"
                        },
                        new
                        {
                            Id = 4,
                            Image = "images/Veteran_car.jpg",
                            Name = "Bilar"
                        });
                });

            modelBuilder.Entity("MemoryMagi.Models.DifficultyLevelModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Level")
                        .HasColumnType("int")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int>("NrOfCards")
                        .HasColumnType("int")
                        .HasColumnName("nr_of_cards");

                    b.HasKey("Id");

                    b.ToTable("DifficultyLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Level = 1,
                            Name = "Lätt",
                            NrOfCards = 4
                        },
                        new
                        {
                            Id = 2,
                            Level = 2,
                            Name = "Medium",
                            NrOfCards = 8
                        },
                        new
                        {
                            Id = 3,
                            Level = 3,
                            Name = "Svår",
                            NrOfCards = 15
                        });
                });

            modelBuilder.Entity("MemoryMagi.Models.GameModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("created_by");

                    b.Property<int>("DifficultyLevelId")
                        .HasColumnType("int")
                        .HasColumnName("difficulty_level_id");

                    b.Property<string>("GameType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("game_type");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DifficultyLevelId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DifficultyLevelId = 1,
                            GameType = "public",
                            Name = "Goda frukter"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            DifficultyLevelId = 2,
                            GameType = "public",
                            Name = "18+ drinkar"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            DifficultyLevelId = 3,
                            GameType = "public",
                            Name = "Djur på bonnagården"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            DifficultyLevelId = 1,
                            GameType = "public",
                            Name = "Bilar man hade velat ha"
                        });
                });

            modelBuilder.Entity("MemoryMagi.Models.ItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("game_id");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 1,
                            Image = "images/Apples.jpg",
                            Name = "Äpple"
                        },
                        new
                        {
                            Id = 2,
                            GameId = 1,
                            Image = "images/Pasta.jpg",
                            Name = "Pasta"
                        },
                        new
                        {
                            Id = 3,
                            GameId = 1,
                            Image = "images/Pineapple.jpg",
                            Name = "Ananas"
                        },
                        new
                        {
                            Id = 4,
                            GameId = 1,
                            Image = "images/Pumpkins.jpg",
                            Name = "Pumpa"
                        },
                        new
                        {
                            Id = 5,
                            GameId = 1,
                            Image = "images/Strawberries.jpg",
                            Name = "Jordgubbar"
                        },
                        new
                        {
                            Id = 6,
                            GameId = 1,
                            Image = "images/Fish.jpg",
                            Name = "Fisk"
                        },
                        new
                        {
                            Id = 7,
                            GameId = 2,
                            Image = "images/Beer.jpg",
                            Name = "Öl"
                        },
                        new
                        {
                            Id = 8,
                            GameId = 2,
                            Image = "images/Cocktail.jpg",
                            Name = "Cocktail"
                        },
                        new
                        {
                            Id = 9,
                            GameId = 2,
                            Image = "images/Crafted_beer.jpg",
                            Name = "Crafted öl"
                        },
                        new
                        {
                            Id = 10,
                            GameId = 2,
                            Image = "images/Red_Wine.jpg",
                            Name = "Rött vin"
                        },
                        new
                        {
                            Id = 11,
                            GameId = 2,
                            Image = "images/Wine.jpg",
                            Name = "Vin"
                        },
                        new
                        {
                            Id = 12,
                            GameId = 3,
                            Image = "images/Bird.jpg",
                            Name = "Fågel"
                        },
                        new
                        {
                            Id = 13,
                            GameId = 3,
                            Image = "images/Cat.jpg",
                            Name = "Katt"
                        },
                        new
                        {
                            Id = 14,
                            GameId = 3,
                            Image = "images/Cows.jpg",
                            Name = "Ko"
                        },
                        new
                        {
                            Id = 15,
                            GameId = 3,
                            Image = "images/Lion.jpg",
                            Name = "Lejon"
                        },
                        new
                        {
                            Id = 16,
                            GameId = 3,
                            Image = "images/Monkeys.jpg",
                            Name = "Apa"
                        },
                        new
                        {
                            Id = 17,
                            GameId = 3,
                            Image = "images/Wolf.jpg",
                            Name = "Varg"
                        },
                        new
                        {
                            Id = 18,
                            GameId = 4,
                            Image = "images/Exotic_car.jpg",
                            Name = "Cool bil"
                        },
                        new
                        {
                            Id = 19,
                            GameId = 4,
                            Image = "images/Pastawagon_car.jpg",
                            Name = "Pasta bilen"
                        },
                        new
                        {
                            Id = 20,
                            GameId = 4,
                            Image = "images/Racecar_car.jpg",
                            Name = "Racer bilen"
                        },
                        new
                        {
                            Id = 21,
                            GameId = 4,
                            Image = "images/SUV_car.jpg",
                            Name = "Stadsjeepen"
                        },
                        new
                        {
                            Id = 22,
                            GameId = 4,
                            Image = "images/Trackcar_car.jpg",
                            Name = "Ban bilen"
                        },
                        new
                        {
                            Id = 23,
                            GameId = 4,
                            Image = "images/Veteran_car.jpg",
                            Name = "Veteran bilen"
                        });
                });

            modelBuilder.Entity("MemoryMagi.Models.ResultModel", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("user_id");

                    b.Property<int>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("game_id");

                    b.Property<DateTime>("DatePlayed")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_played");

                    b.Property<bool>("Passed")
                        .HasColumnType("bit")
                        .HasColumnName("passed");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time")
                        .HasColumnName("time");

                    b.HasKey("UserId", "GameId", "DatePlayed");

                    b.HasIndex("GameId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("MemoryMagi.Models._2._0.AchievementModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("MemoryMagi.Models._2._0.UserAchievement", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("user_id");

                    b.Property<int>("AchievementId")
                        .HasColumnType("int")
                        .HasColumnName("achievement_id");

                    b.Property<DateOnly>("AchievementDate")
                        .HasColumnType("date")
                        .HasColumnName("achievement_date");

                    b.HasKey("UserId", "AchievementId");

                    b.HasIndex("AchievementId");

                    b.ToTable("UserAchievements");
                });

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

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

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
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

            modelBuilder.Entity("MemoryMagi.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("MemoryMagi.Models.AllowedUser", b =>
                {
                    b.HasOne("MemoryMagi.Models.GameModel", "Game")
                        .WithMany("AllowedUsers")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemoryMagi.Models.ApplicationUser", "User")
                        .WithMany("AllowedUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MemoryMagi.Models.GameModel", b =>
                {
                    b.HasOne("MemoryMagi.Models.CategoryModel", "Category")
                        .WithMany("Games")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemoryMagi.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("MemoryMagi.Models.DifficultyLevelModel", "DifficultyLevel")
                        .WithMany("Games")
                        .HasForeignKey("DifficultyLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("DifficultyLevel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MemoryMagi.Models.ItemModel", b =>
                {
                    b.HasOne("MemoryMagi.Models.GameModel", "Game")
                        .WithMany("Items")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("MemoryMagi.Models.ResultModel", b =>
                {
                    b.HasOne("MemoryMagi.Models.GameModel", "Game")
                        .WithMany("Results")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemoryMagi.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MemoryMagi.Models._2._0.UserAchievement", b =>
                {
                    b.HasOne("MemoryMagi.Models._2._0.AchievementModel", "Achievement")
                        .WithMany("UserAchievements")
                        .HasForeignKey("AchievementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MemoryMagi.Models.ApplicationUser", "User")
                        .WithMany("UserAchievements")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Achievement");

                    b.Navigation("User");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MemoryMagi.Models.CategoryModel", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("MemoryMagi.Models.DifficultyLevelModel", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("MemoryMagi.Models.GameModel", b =>
                {
                    b.Navigation("AllowedUsers");

                    b.Navigation("Items");

                    b.Navigation("Results");
                });

            modelBuilder.Entity("MemoryMagi.Models._2._0.AchievementModel", b =>
                {
                    b.Navigation("UserAchievements");
                });

            modelBuilder.Entity("MemoryMagi.Models.ApplicationUser", b =>
                {
                    b.Navigation("AllowedUsers");

                    b.Navigation("UserAchievements");
                });
#pragma warning restore 612, 618
        }
    }
}
