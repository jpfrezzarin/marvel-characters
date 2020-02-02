using System;

namespace MarvelsCharacters.Api.Models
{
    public class ComicViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Modified { get; set; }
        public string ResourceUri { get; set; }
        public ColletionViewModel<CharacterViewModel> Characters { get; set; }
    }
}
