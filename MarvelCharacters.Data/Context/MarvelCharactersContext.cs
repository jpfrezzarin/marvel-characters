using MarvelCharacters.Data.Configuration;
using MarvelCharacters.Data.Configuration.Relationships;
using MarvelCharacters.Data.Util;
using MarvelCharacters.Models;
using MarvelCharacters.Models.Relationships;
using Microsoft.EntityFrameworkCore;

namespace MarvelCharacters.Data.Context
{
    public class MarvelCharactersContext : DbContext
    {
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Comic> Comics { get; set; }
        public virtual DbSet<CharacterComic> CharacterComics { get; set; }

        public MarvelCharactersContext(DbContextOptions<MarvelCharactersContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CharacterConfiguration());
            modelBuilder.ApplyConfiguration(new ComicConfiguration());
            modelBuilder.ApplyConfiguration(new CharacterComicConfiguration());

            DataInicializer.InitializeData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
