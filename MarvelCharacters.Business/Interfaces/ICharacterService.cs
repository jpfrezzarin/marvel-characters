using MarvelCharacters.Models;
using System.Collections.Generic;

namespace MarvelCharacters.Business.Interfaces
{
    public interface ICharacterService
    {
        IEnumerable<Character> Get();
        Character Get(int id);
    }
}
