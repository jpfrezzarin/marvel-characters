namespace MarvelCharacters.Models.Relationships
{
    public class CharacterComic
    {
        public int CharacterId { get; set; }
        public int ComicId { get; set; }
        public virtual Character Character { get; set; }
        public virtual Comic Comic { get; set; }
    }
}
