using MarvelCharacters.Data.Interfaces;
using MarvelCharacters.Models;
using MarvelCharacters.Business.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MarvelCharacters.Business
{
    public class CharacterService : ICharacterService
    {
        private readonly IRepository<Character> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CharacterService(IUnitOfWork unitOfWork)
        {
            _repository = unitOfWork.GetRepository<Character>();
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Character> Get()
        {
            return _repository.Get().ToList();
        }

        public Character Get(int id)
        {
            return _repository.Get(id) ??
                throw new KeyNotFoundException("This hero didn't save the world yet...");
        }
    }
}
