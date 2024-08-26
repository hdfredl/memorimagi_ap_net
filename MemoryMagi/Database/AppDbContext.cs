﻿using MemoryMagi.Models;
using MemoryMagi.Models._2._0;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MemoryMagi.Database
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<UserItem> UserItems { get; set; }
        public DbSet<CategoryModel> Categories_2 { get; set; }
        public DbSet<GameModel> Games_2 { get; set; }

        public DbSet<ResultModel> Results_2 { get; set; }

        public DbSet<DifficultyLevelModel> DifficultyLevels_2 { get; set; }
        public DbSet<GameTypeModel> GameTypes_2 { get; set; }
        public DbSet<ItemModel> Items_2 { get; set; }
        public DbSet<AchievementModel> Achievements_2 { get; set; }
        public DbSet<UserAchievement> UserAchievements_2 { get; set; }
        public DbSet<AllowedUser> AllowedUsers_2 { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /// AVKOMMENTERAT - AVKOMMENTERA SENARE VID ANVÄNDNING

            modelBuilder.Entity<ItemModel>().HasData(
            // Category Id : 1 - Mat
            new ItemModel
            {
                Id = 1,
                Name = "Äpple",
                Image = "images/Apples.jpg",
                GameId = 1
            },
            new ItemModel
            {
                Id = 2,
                Name = "Pasta",
                Image = "images/Pasta.jpg",
                GameId = 1
            },
            new ItemModel
            {
                Id = 3,
                Name = "Ananas",
                Image = "images/Pineapple.jpg",
                GameId = 1
            },
            new ItemModel
            {
                Id = 4,
                Name = "Pumpa",
                Image = "images/Pumpkins.jpg",
                GameId = 1
            },
            new ItemModel
            {
                Id = 5,
                Name = "Jordgubbar",
                Image = "images/Strawberries.jpg",
                GameId = 1
            },
            new ItemModel
            {
                Id = 6,
                Name = "Fisk",
                Image = "images/Fish.jpg",
                GameId = 1
            },
            // GameId 2 : Alkohol
            new ItemModel
            {
                Id = 7,
                Name = "Öl",
                Image = "images/Beer.jpg",
                GameId = 2
            },
            new ItemModel
            {
                Id = 8,
                Name = "Cocktail",
                Image = "images/Cocktail.jpg",
                GameId = 2
            },
            new ItemModel
            {
                Id = 9,
                Name = "Crafted öl",
                Image = "images/Crafted_beer.jpg",
                GameId = 2
            },
            new ItemModel
            {
                Id = 10,
                Name = "Rött vin",
                Image = "images/Red_Wine.jpg",
                GameId = 2
            },
            new ItemModel
            {
                Id = 11,
                Name = "Vin",
                Image = "images/Wine.jpg",
                GameId = 2
            },
            // GameId 3: Djur
            new ItemModel
            {
                Id = 12,
                Name = "Fågel",
                Image = "images/Bird.jpg",
                GameId = 3
            },
            new ItemModel
            {
                Id = 13,
                Name = "Katt",
                Image = "images/Cat.jpg",
                GameId = 3
            },
            new ItemModel
            {
                Id = 14,
                Name = "Ko",
                Image = "images/Cows.jpg",
                GameId = 3
            },
            new ItemModel
            {
                Id = 15,
                Name = "Lejon",
                Image = "images/Lion.jpg",
                GameId = 3
            },
            new ItemModel
            {
                Id = 16,
                Name = "Apa",
                Image = "images/Monkeys.jpg",
                GameId = 3
            },
            new ItemModel
            {
                Id = 17,
                Name = "Varg",
                Image = "images/Wolf.jpg",
                GameId = 3
            },
            // GameId 4: Bilar
            new ItemModel
            {
                Id = 18,
                Name = "Cool bil",
                Image = "images/Exotic_car.jpg",
                GameId = 4
            },
            new ItemModel
            {
                Id = 19,
                Name = "Pasta bilen",
                Image = "images/Pastawagon_car.jpg",
                GameId = 4
            },
            new ItemModel
            {
                Id = 20,
                Name = "Racer bilen",
                Image = "images/Racecar_car.jpg",
                GameId = 4
            },
            new ItemModel
            {
                Id = 21,
                Name = "Stadsjeepen",
                Image = "images/SUV_car.jpg",
                GameId = 4
            },
            new ItemModel
            {
                Id = 22,
                Name = "Ban bilen",
                Image = "images/Trackcar_car.jpg",
                GameId = 4
            },
            new ItemModel
            {
                Id = 23,
                Name = "Veteran bilen",
                Image = "images/Veteran_car.jpg",
                GameId = 4
            });


            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel()
                {
                    Id = 1,
                    Name = "Frukt",
                    Image = "images/Veteran_car.jpg"
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "Alkohol",
                    Image = "images/Veteran_car.jpg"
                },
                new CategoryModel()
                {
                    Id = 3,
                    Name = "Djur",
                    Image = "images/Veteran_car.jpg"
                },
                new CategoryModel()
                {
                    Id = 4,
                    Name = "Bilar",
                    Image = "images/Veteran_car.jpg"
                }
            );

            modelBuilder.Entity<DifficultyLevelModel>().HasData(
                new DifficultyLevelModel
                {
                    Id = 1,
                    Name = "Lätt",
                    Level = 1,        // Easy 
                    NrOfCards = 4
                },
                new DifficultyLevelModel
                {
                    Id = 2,
                    Name = "Medium",
                    Level = 2,        // Medium
                    NrOfCards = 8
                },
                new DifficultyLevelModel
                {
                    Id = 3,
                    Name = "Svår",
                    Level = 3,        // Hard 
                    NrOfCards = 15
                }
            );

            modelBuilder.Entity<GameTypeModel>().HasData(
                new GameTypeModel
                {
                    Id = 1,
                    Name = "Public",
                    GameType = 1
                },
                new GameTypeModel
                {
                    Id = 2,
                    Name = "Private",
                    GameType = 2
                }
            );

            modelBuilder.Entity<GameModel>().HasData(
                new GameModel()
                {
                    Id = 1,
                    CategoryId = 1, // Frukt
                    DifficultyLevelId = 1, // Easy
                    GameTypeId = 1,
                    CreatedBy = null, // Replace with real ID
                },
                new GameModel()
                {
                    Id = 2,
                    CategoryId = 2, // Alkohol
                    DifficultyLevelId = 2, //Medium
                    GameTypeId = 1,
                    CreatedBy = null, // Replace with real ID
                },
                new GameModel()
                {
                    Id = 3,
                    CategoryId = 3, // Djur
                    DifficultyLevelId = 3, //Hard
                    GameTypeId = 1,
                    CreatedBy = null, // Replace with real ID
                },
                new GameModel()
                {
                    Id = 4,
                    CategoryId = 4, // Bilar
                    DifficultyLevelId = 1, //Easy
                    GameTypeId = 1,
                    CreatedBy = null, // Replace with real ID
                }
            );



            // hehe
        }
    }
}
