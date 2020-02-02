﻿using System;

namespace MarvelCharacters.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Modified { get; set; }
        public string ResourceUri 
        { 
            get 
            {
                return $"/characters/{this.Id}";
            } 
        }
    }
}
