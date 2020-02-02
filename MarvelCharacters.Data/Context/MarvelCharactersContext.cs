using MarvelCharacters.Data.Configuration;
using MarvelCharacters.Models;
using Microsoft.EntityFrameworkCore;

namespace MarvelCharacters.Data.Context
{
    public class MarvelCharactersContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public MarvelCharactersContext(DbContextOptions<MarvelCharactersContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CharacterConfiguration());

            InitializeData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void InitializeData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    Id = 1,
                    Name = "Spider-Man",
                    Description = "Spider-Man is a fictional superhero created by writer-editor Stan Lee and writer-artist Steve Ditko. He first appeared in the anthology comic book Amazing Fantasy #15 (August 1962) in the Silver Age of Comic Books",
                    Modified = System.DateTime.Now
                },
                new Character
                {
                    Id = 2,
                    Name = "Iron Man",
                    Description = "Iron Man is a fictional superhero appearing in American comic books published by Marvel Comics. The character was co-created by writer and editor Stan Lee, developed by scripter Larry Lieber, and designed by artists Don Heck and Jack Kirby. The character made his first appearance in Tales of Suspense #39 (cover dated March 1963), and received his own title in Iron Man #1 (May 1968)",
                    Modified = System.DateTime.Now
                },
                new Character
                {
                    Id = 3,
                    Name = "Captain America",
                    Description = "Captain America is a fictional superhero appearing in American comic books published by Marvel Comics. Created by cartoonists Joe Simon and Jack Kirby, the character first appeared in Captain America Comics #1 (cover dated March 1941) from Timely Comics, a predecessor of Marvel Comics",
                    Modified = System.DateTime.Now
                },
                new Character
                {
                    Id = 4,
                    Name = "Thor",
                    Description = "Thor Odinson is a fictional superhero appearing in American comic books published by Marvel Comics. The character, which is based on the Norse deity of the same name, is the Asgardian god of thunder who possesses the enchanted hammer, Mjolnir, which grants him the ability to fly and manipulate weather amongst his other superhuman attributes.",
                    Modified = System.DateTime.Now
                }
            );
        }
    }
}
