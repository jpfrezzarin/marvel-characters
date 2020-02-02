using MarvelCharacters.Data.Interfaces;
using MarvelCharacters.Models;
using MarvelCharacters.Business;
using MarvelCharacters.Business.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelCharacters.Business.Test
{
    [TestClass]
    public class CharacterServiceUnitTest
    {
        private readonly Mock<IUnitOfWork> _unitOfWork;
        private readonly Mock<IRepository<Character>> _characterRepository;

        private readonly ICharacterService _characterService;

        public CharacterServiceUnitTest()
        {
            _unitOfWork = new Mock<IUnitOfWork>();
            _characterRepository = new Mock<IRepository<Character>>();

            _unitOfWork.Setup(unitOfWork => unitOfWork.GetRepository<Character>()).Returns(_characterRepository.Object);

            _characterService = new CharacterService(_unitOfWork.Object);
        }

        [TestMethod]
        public async Task Get_HasNoCharacter_ShouldReturnAnEmptyList()
        {
            _characterRepository.Setup(repo => repo.GetAll(null)).ReturnsAsync(new List<Character>());

            var result = await _characterService.GetAll();

            Assert.AreEqual(result.Count(), 0);
        }

        [TestMethod]
        public async Task Get_HasOneCharacter_ShouldReturnAListWithOneCharacter()
        {
            var spider = new Character { Name = "Spider-Man", Description = "Spider-Man" };
            _characterRepository.Setup(repo => repo.GetAll(null)).ReturnsAsync(new List<Character> { spider });

            var result = await _characterService.GetAll();

            Assert.AreEqual(result.Count(), 1);
        }

        [TestMethod]
        public async Task Get_HasMoreThanOneCharacter_ShouldReturnAListWithMoreThanOneCharacter()
        {
            var spider = new Character { Name = "Spider-Man", Description = "Spider-Man" };
            var iron = new Character { Name = "Iron-Man", Description = "Iron-Man" };
            var captain = new Character { Name = "Captain America", Description = "Captain America" };
            var thor = new Character { Name = "Thor", Description = "Thor" };
            _characterRepository.Setup(repo => repo.GetAll(null)).ReturnsAsync(new List<Character> { spider, iron, captain, thor });

            var result = await _characterService.GetAll();

            Assert.AreEqual(result.Count(), 4);
        }

        [TestMethod]
        public async Task Get_ExistingCharacter_ShouldReturnTheExistingCharacter()
        {
            var spider = new Character { Id = 1, Name = "Spider-Man", Description = "Spider-Man" };
            _characterRepository.Setup(repo => repo.Get(spider.Id)).ReturnsAsync(spider);

            var result = await _characterService.Get(spider.Id);

            Assert.AreEqual(spider.Id, result.Id);
        }

        [TestMethod]
        public async Task Get_NotExistingCharacter_ShouldThrowKeyNotFoundException()
        {
            await Assert.ThrowsExceptionAsync<KeyNotFoundException>(async () => await _characterService.Get(0));
        }
    }
}
