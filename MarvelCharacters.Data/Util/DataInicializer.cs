using MarvelCharacters.Models;
using MarvelCharacters.Models.Relationships;
using Microsoft.EntityFrameworkCore;
using System;

namespace MarvelCharacters.Data.Util
{
    static class DataInicializer
    {
        public static void InitializeData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    Id = 1,
                    Name = "Spider-Man",
                    Description = "Spider-Man is a fictional superhero created by writer-editor Stan Lee and writer-artist Steve Ditko. He first appeared in the anthology comic book Amazing Fantasy #15 (August 1962) in the Silver Age of Comic Books",
                    Modified = DateTime.Now
                },
                new Character
                {
                    Id = 2,
                    Name = "Iron Man",
                    Description = "Iron Man is a fictional superhero appearing in American comic books published by Marvel Comics. The character was co-created by writer and editor Stan Lee, developed by scripter Larry Lieber, and designed by artists Don Heck and Jack Kirby. The character made his first appearance in Tales of Suspense #39 (cover dated March 1963), and received his own title in Iron Man #1 (May 1968)",
                    Modified = DateTime.Now
                },
                new Character
                {
                    Id = 3,
                    Name = "Captain America",
                    Description = "Captain America is a fictional superhero appearing in American comic books published by Marvel Comics. Created by cartoonists Joe Simon and Jack Kirby, the character first appeared in Captain America Comics #1 (cover dated March 1941) from Timely Comics, a predecessor of Marvel Comics",
                    Modified = DateTime.Now
                },
                new Character
                {
                    Id = 4,
                    Name = "Thor",
                    Description = "Thor Odinson is a fictional superhero appearing in American comic books published by Marvel Comics. The character, which is based on the Norse deity of the same name, is the Asgardian god of thunder who possesses the enchanted hammer, Mjolnir, which grants him the ability to fly and manipulate weather amongst his other superhuman attributes.",
                    Modified = DateTime.Now
                }
            );

            modelBuilder.Entity<Comic>().HasData(
                new Comic
                {
                    Id = 1,
                    Title = "The Amazing Spider-Man",
                    Description = "The Amazing Spider-Man is an American comic book series published by Marvel Comics, featuring the fictional superhero Spider-Man as its main protagonist. Being in the mainstream continuity of the franchise, it began publication in 1963 as a monthly periodical and was published continuously, with a brief interruption in 1995, until its relaunch with a new numbering order in 1999. In 2003 the series reverted to the numbering order of the first volume.",
                    Modified = DateTime.Now
                },
                new Comic
                {
                    Id = 2,
                    Title = "The Avengers",
                    Description = "The Avengers are a fictional team of superheroes appearing in American comic books published by Marvel Comics. The team made its debut in The Avengers #1 (cover-dated Sept. 1963), created by writer-editor Stan Lee and artist/co-plotter Jack Kirby. The Avengers is Lee and Kirby's renovation of a previous superhero team, All-Winners Squad, who appeared in comic books series published by Marvel Comics' predecessor Timely Comics.",
                    Modified = DateTime.Now
                }
            );

            modelBuilder.Entity<CharacterComic>().HasData(
                new CharacterComic { CharacterId = 1, ComicId = 1 },
                new CharacterComic { CharacterId = 1, ComicId = 2 },
                new CharacterComic { CharacterId = 2, ComicId = 2 },
                new CharacterComic { CharacterId = 3, ComicId = 2 },
                new CharacterComic { CharacterId = 4, ComicId = 2 }
            );
        }
    }
}
