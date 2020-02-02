using System;

namespace MarvelsCharacters.Api.Models
{
    public class CharacterViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Modified { get; set; }
        public string ResourceUri { get; set; }
        public ColletionViewModel<ComicViewModel> Comics { get; set; }
    }
}
