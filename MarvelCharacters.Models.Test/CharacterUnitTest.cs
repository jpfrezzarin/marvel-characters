using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarvelCharacters.Models.Test
{
    [TestClass]
    public class CharacterUnitTest
    {
        private readonly Character _character;

        public CharacterUnitTest()
        {
            _character = new Character
            {
                Id = 1,
                Name = "UnitTest",
                Description = "UnitTest",
                Modified = DateTime.Now
            };
        }

        [TestMethod]
        public void Character_PropertyId_IsIntType()
        {
            Assert.IsInstanceOfType(_character.Id, typeof(int));
        }

        [TestMethod]
        public void Character_PropertyName_IsStringType()
        {
            Assert.IsInstanceOfType(_character.Name, typeof(string));
        }

        [TestMethod]
        public void Character_PropertyDescription_IsStringType()
        {
            Assert.IsInstanceOfType(_character.Description, typeof(string));
        }

        [TestMethod]
        public void Character_PropertyModified_IsIsTypeDateTimeType()
        {
            Assert.IsInstanceOfType(_character.Modified, typeof(DateTime));
        }
    }
}
