using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GamesAPI.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GamesContext>>()))
            {
                if (context.Games.Any())
                {
                    return;   // DB has been seeded
                }

                context.Games.AddRange(
                    new Game
                    {
                        Name = "Red Dead Redemption 2",
                        Description = "Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game’s vast and atmospheric world also provides the foundation for a brand new online multiplayer experience. America, 1899. The end of the Wild West era has begun.",
                        ReleaseDate = DateTime.Parse("2018-10-26"),
                        Rating = 8
                    },
                    new Game
                    {
                        Name = "Journey",
                        Description = "An exotic adventure with a more serious tone, Journey presents TGCs unique vision of an online adventure experience. Awakening in an unknown world, the player walks, glides, and flies through a vast and awe-inspiring landscape, while discovering the history of an ancient, mysterious civilization along the way. ",
                        ReleaseDate = DateTime.Parse("2015-7-21"),
                        Rating = 8
                    },
                    new Game
                    {
                        Name = "Persona 5",
                        Description = "Beneath the veneer of typical urban high school life, a group of teenagers mask their mysterious alter egos, their \"phantom thief\" side. Who are they? Why are they dressed as such? What are their motives? And... why are they being pursued?",
                        ReleaseDate = DateTime.Parse("2017-4-4"),
                        Rating = 9
                    },
                    new Game
                    {
                        Name = "Undertale",
                        Description = "Welcome to UNDERTALE. In this RPG, you control a human who falls underground into the world of monsters. Now you must find your way out... or stay trapped forever. ",
                        ReleaseDate = DateTime.Parse("2017-8-15"),
                        Rating = 6
                    },
                    new Game
                    {
                        Name = "Shadow of the Colossus",
                        Description = "Tales speak of an ancient realm where Colossi roam the majestic landscape. Bound to the land, these creatures hold a key to a mystical power of revival – a power you must obtain to bring a loved one back to life.",
                        ReleaseDate = DateTime.Parse("2018-2-6"),
                        Rating = 8
                    },
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
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
