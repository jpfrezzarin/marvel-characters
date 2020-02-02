using MarvelCharacters.Data.Interfaces;
using MarvelCharacters.Data.Test.Mock;
using MarvelCharacters.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MarvelCharacters.Data.Test
{
    [TestClass]
    public class UnitOfWorkUnitTest
    {
        private readonly Mock<MarvelCharactersContextMock> _context;

        private readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkUnitTest()
        {
            _context = new Mock<MarvelCharactersContextMock>();

            _unitOfWork = new UnitOfWork<MarvelCharactersContextMock>(_context.Object);
        }

        [TestMethod]
        public void GetRepository_CharacterRepository_ShouldReturnInstanceOfCharacterRepository()
        {
            var result = _unitOfWork.GetRepository<Character>();

            Assert.IsInstanceOfType(result, typeof(IRepository<Character>));
        }
    }
}
