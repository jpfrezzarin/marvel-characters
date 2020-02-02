using MarvelCharacters.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarvelCharacters.Business.Interfaces
{
    public interface ICharacterService
    {
        Task<IEnumerable<Character>> GetAll();
        Task<Character> Get(int id);
    }
}
