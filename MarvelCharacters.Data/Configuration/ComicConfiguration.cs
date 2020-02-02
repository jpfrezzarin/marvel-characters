using MarvelCharacters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MarvelCharacters.Data.Configuration
{
    class ComicConfiguration : IEntityTypeConfiguration<Comic>
    {
        public void Configure(EntityTypeBuilder<Comic> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(500);
        }
    }
}
