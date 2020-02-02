using MarvelCharacters.Models.Relationships;
using System;
using System.Collections.Generic;

namespace MarvelCharacters.Models
{
    public class Comic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Modified { get; set; }
        public virtual ICollection<CharacterComic> CharacterComics { get; set; } = new HashSet<CharacterComic>();
    }
}
