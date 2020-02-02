using MarvelCharacters.Models;
using MarvelsCharacters.Api.Models;
using System.Linq;

namespace MarvelsCharacters.Api.Mapper
{
    public static class CharactersMapperExtension
    {
        public static CharacterViewModel ToViewModel(this Character character)
        {
            return new CharacterViewModel
            {
                Id = character.Id,
                Name = character.Name,
                Description = character.Description,
                Modified = character.Modified,
                ResourceUri = $"/characters/{character.Id}",
                Comics = new ColletionViewModel<ComicViewModel>
                {
                    Available = character.CharacterComics.Count,
                    CollectionUri = $"/characters/{character.Id}/comics",
                    Items = character.CharacterComics.Select(c => new ComicViewModel
                    {
                        Id = c.Comic.Id,
                        Title = c.Comic.Title
                    })
                }
            };
        }
    }
}
