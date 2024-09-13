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
                            Name = "Djur"
                        },
                        new
                        {
                            Id = 3,
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
                            Id = 3,
                            CategoryId = 2,
                            DifficultyLevelId = 2,
                            GameType = "public",
                            Name = "Djur på bonnagården"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            DifficultyLevelId = 3,
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
                            Image = "https://img.freepik.com/free-vector/sticker-design-with-apple-isolated_1308-66383.jpg?t=st=1725441600~exp=1725445200~hmac=2b353ba4b82a3ad64efda6bf389b2541f080abace5c4b2650920cfd765f9e236&w=740",
                            Name = "Äpple"
                        },
                        new
                        {
                            Id = 2,
                            GameId = 1,
                            Image = "https://img.freepik.com/free-vector/spaghetti-pasta-with-bolognese-sauce_1308-115408.jpg?t=st=1725441659~exp=1725445259~hmac=cae2d1c081992be7f9b2697d6df20e9ffeb560de7546c7f8be2f602197921472&w=1380",
                            Name = "Pasta"
                        },
                        new
                        {
                            Id = 3,
                            GameId = 1,
                            Image = "https://img.freepik.com/premium-vector/drawing-pineapple-with-green-top-yellow-top_1166763-24137.jpg?w=740",
                            Name = "Ananas"
                        },
                        new
                        {
                            Id = 4,
                            GameId = 1,
                            Image = "https://img.freepik.com/free-vector/fresh-pumpkin-white-b_1308-39708.jpg?t=st=1725442167~exp=1725445767~hmac=906c103466192496ecf2b6a977843c6c7588c65e5eb49bb89ee2da4a571bbf55&w=826",
                            Name = "Pumpa"
                        },
                        new
                        {
                            Id = 5,
                            GameId = 1,
                            Image = "https://img.freepik.com/premium-vector/strawberry-clipart-vector-illustration-white-background_1280610-709.jpg?w=740",
                            Name = "Jordgubbar"
                        },
                        new
                        {
                            Id = 6,
                            GameId = 1,
                            Image = "https://img.freepik.com/premium-vector/cartoon-illustration-smiling-orange-white-clownfish_1216680-928.jpg?w=740",
                            Name = "Fisk"
                        },
                        new
                        {
                            Id = 12,
                            GameId = 3,
                            Image = "https://img.freepik.com/free-vector/hand-drawn-flat-design-robin-collection_23-2149145170.jpg?t=st=1725442349~exp=1725445949~hmac=e0c69eb898156b90b344b8315ad7f4c468d28130b0d358eb7ba220eafc748e98&w=740",
                            Name = "Fågel"
                        },
                        new
                        {
                            Id = 13,
                            GameId = 3,
                            Image = "https://img.freepik.com/premium-vector/cute-cat-collection-isolated-white-background_703032-4100.jpg?w=1380",
                            Name = "Katt"
                        },
                        new
                        {
                            Id = 14,
                            GameId = 3,
                            Image = "https://img.freepik.com/premium-vector/cartoon-illustration-brown-white-cow_1216680-373.jpg?w=740",
                            Name = "Ko"
                        },
                        new
                        {
                            Id = 15,
                            GameId = 3,
                            Image = "https://img.freepik.com/premium-vector/cute-lion-cartoon-white-background_29190-8567.jpg?w=740",
                            Name = "Lejon"
                        },
                        new
                        {
                            Id = 16,
                            GameId = 3,
                            Image = "https://img.freepik.com/free-vector/monkey-cartoon-character-sticker_1308-76562.jpg?t=st=1725442733~exp=1725446333~hmac=261a58dc78d31af291802ee3e0912fd5f2f294d1d32da3a27fb91b75c6f30dfe&w=740",
                            Name = "Apa"
                        },
                        new
                        {
                            Id = 17,
                            GameId = 3,
                            Image = "https://img.freepik.com/premium-vector/cartoon-dog-with-cartoon-face-word-wolf-it_1025542-56600.jpg?w=740",
                            Name = "Varg"
                        },
                        new
                        {
                            Id = 18,
                            GameId = 4,
                            Image = "https://img.freepik.com/premium-vector/red-car-with-license-plate-number-3_1128391-17709.jpg?w=740",
                            Name = "sport bil"
                        },
                        new
                        {
                            Id = 19,
                            GameId = 4,
                            Image = "https://img.freepik.com/free-vector/boy-driving-vintage-car-cartoon-design_1308-107242.jpg?t=st=1725453109~exp=1725456709~hmac=81d598da00b7fdb14f45c280734502f48e4d747188fd295ce35c102627bb0ad4&w=1800",
                            Name = "cabriolet bilen"
                        },
                        new
                        {
                            Id = 20,
                            GameId = 4,
                            Image = "https://img.freepik.com/premium-vector/indy-car-speeding-f1-racing-f1-sports-car-illustration-vector_280080-22.jpg?w=1380,",
                            Name = "Racer bilen"
                        },
                        new
                        {
                            Id = 21,
                            GameId = 4,
                            Image = "https://img.freepik.com/premium-vector/red-car-with-surfboard-top-it_1013341-387239.jpg?w=740",
                            Name = "Stadsjeepen"
                        },
                        new
                        {
                            Id = 22,
                            GameId = 4,
                            Image = "https://img.freepik.com/free-vector/black-sedan-car-isolated-white-background_1308-75583.jpg?t=st=1725452945~exp=1725456545~hmac=961c6db37d955480177b2eb6d6c6b7571efb30f5ff94d5fdd41dcc65c2c28521&w=1380",
                            Name = "Sedan bilen"
                        },
                        new
                        {
                            Id = 23,
                            GameId = 4,
                            Image = "https://img.freepik.com/free-vector/classic-green-vintage-car-illustration_1308-164648.jpg?t=st=1725452987~exp=1725456587~hmac=dc808c875da97d90cb4641fdebe8f6718e4ff0dab6cb8aab516ef3495ffdb0f8&w=1380",
                            Name = "Veteran bilen"
                        });
                });

            modelBuilder.Entity("MemoryMagi.Models.ResultModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DatePlayed")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_played");

                    b.Property<int>("GameId")
                        .HasColumnType("int")
                        .HasColumnName("game_id");

                    b.Property<bool>("Passed")
                        .HasColumnType("bit")
                        .HasColumnName("passed");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time")
                        .HasColumnName("time");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

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

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image-url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Achievements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Klara ditt första spel",
                            ImageUrl = "Achievement1Game.jpg",
                            Name = "Första steget!"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Klara totalt 5 spel",
                            ImageUrl = "Achievement5Game.jpg",
                            Name = "Lärling"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Klara total 20 spel",
                            ImageUrl = "Achievement20Game.jpg",
                            Name = "Magiker"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Klara total 100 spel",
                            ImageUrl = "Achievement100Game.jpg",
                            Name = "Magi Mästare"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Klara ett spel under 5 minuter",
                            ImageUrl = "Achievement3minGame.jpg",
                            Name = "Tidens lärling"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Klara ett spel under 1 minut",
                            ImageUrl = "Achievement60secGame.jpg",
                            Name = "Tidens Väktare"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Klara ett spel under 30 sekunder",
                            ImageUrl = "Achievement30secGame.jpg",
                            Name = "Tidens Härskare"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Klara ett spel med \"Lätt\" svårighetsgrad",
                            ImageUrl = "AchievementEasyGame.jpg",
                            Name = "Lärlingens Utmaning"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Klara ett spel med \"Medium\" svårighetsgrad",
                            ImageUrl = "AchievementMediumGame.jpg",
                            Name = "Trollkarlens Utmaning"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Klara ett spel med \"Svår\" svårighetsgrad",
                            ImageUrl = "AchievementHardGame.jpg",
                            Name = "Mästarens Utmaning"
                        });
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
