using MarvelCharacters.Models;
using MarvelsCharacters.Api.Models;
using System.Linq;

namespace MarvelsCharacters.Api.Mapper
{
    public static class ComicMapperExtension
    {
        public static ComicViewModel ToViewModel(this Comic comic)
        {
            return new ComicViewModel
            {
                Id = comic.Id,
                Title = comic.Title,
                Description = comic.Description,
                Modified = comic.Modified,
                Characters = new ColletionViewModel<CharacterViewModel>
                {
                    Available = comic.CharacterComics.Count,
                    Items = comic.CharacterComics.Select(c => new CharacterViewModel
                    {
                        Id = c.Character.Id,
                        Name = c.Character.Name
                    })
                }
            };
        }
    }
}
