using MarvelCharacters.Data.Interfaces;
using MarvelCharacters.Models;
using MarvelCharacters.Business.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelCharacters.Business
{
    public class CharacterService : ICharacterService
    {
        private readonly IRepository<Character> _repository;

        public CharacterService(IUnitOfWork unitOfWork)
        {
            _repository = unitOfWork.GetRepository<Character>();
        }

        public async Task<IEnumerable<Character>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Character> Get(int id)
        {
            return await _repository.Get(id) ??
                throw new KeyNotFoundException("This hero didn't save the world yet...");
        }
    }
}
