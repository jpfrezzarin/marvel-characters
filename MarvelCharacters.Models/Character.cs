﻿using System;
using System.Collections.Generic;
using MarvelCharacters.Models.Relationships;

namespace MarvelCharacters.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Modified { get; set; }
        public virtual ICollection<CharacterComic> CharacterComics { get; set; } = new HashSet<CharacterComic>();
    }
}
