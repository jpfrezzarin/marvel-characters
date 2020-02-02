using MarvelCharacters.Models.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarvelCharacters.Data.Configuration.Relationships
{
    class CharacterComicConfiguration : IEntityTypeConfiguration<CharacterComic>
    {
        public void Configure(EntityTypeBuilder<CharacterComic> builder)
        {
            builder.HasKey(p => new { p.CharacterId, p.ComicId });

            builder
                .HasOne(p => p.Character)
                .WithMany(p => p.CharacterComics)
                .HasForeignKey(p => p.CharacterId);

            builder
                .HasOne(p => p.Comic)
                .WithMany(p => p.CharacterComics)
                .HasForeignKey(p => p.ComicId);
        }
    }
}
