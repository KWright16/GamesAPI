using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GamesAPI.Models;
using GamesAPI.Controllers;

namespace GamesAPI.SQLite
{
    [TestClass]
    public class GamesControllerTests
    {
        [TestMethod]
        public async Task Get_returns_all_gamesAsync()
        {
            // In-memory database only exists while the connection is open
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            try
            {
                var options = new DbContextOptionsBuilder<GamesContext>()
                    .UseSqlite(connection)
                    .Options;

                // Create the schema in the database
                using (var context = new GamesContext(options))
                {
                    context.Database.EnsureCreated();
                }

                // Insert seed data into the database using one instance of the context
                using (var context = new GamesContext(options))
                {
                    context.Games.AddRange(
                    new Game
                    {
                        Name = "Rayman Ledgends",
                        Description = "There are several differences and new features in this PS4 version. In this version the textures of the game are more compressed, so you can see that the game’s graphics are clearer and more detailed than before. You will also see that there is no loading time when you enter or exit a level, which makes the navigation even faster and more enjoyable. ",
                        ReleaseDate = DateTime.Parse("2018-2-14"),
                        Rating = 8
                    },
                    new Game
                    {
                        Name = "Monster-Hunter: World",
                        Description = " In Monster Hunter: World you assume the role of a hunter venturing to a new continent where you track down and slay ferocious beasts in heart-pounding battles. ",
                        ReleaseDate = DateTime.Parse("2018-1-26"),
                        Rating = 7
                    },
                    new Game
                    {
                        Name = "Tetris Effect",
                        Description = " From deep beneath the ocean to the furthest reaches of outer space, Tetris Effect’s 30-plus stages are more than just backdrops; together with music, characters, and animations tailor-made for each level and triggered by your actions, they’re all meant to make you feel something",
                        ReleaseDate = DateTime.Parse("2018-11-09"),
                        Rating = 8
                    });
                    context.SaveChanges();
                }

                // Use a clean instance of the context to run the test
                using (var context = new GamesContext(options))
                {
                    var service = new GamesController(context);
                    var result = await service.GetGames();
                    Console.WriteLine(result);
                    Assert.AreEqual(3, result);
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
