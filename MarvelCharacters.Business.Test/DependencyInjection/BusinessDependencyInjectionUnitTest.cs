using MarvelCharacters.Business.DependencyInjection;
using MarvelCharacters.Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MarvelCharacters.Business.Test.DependencyInjection
{
    [TestClass]
    public class BusinessDependencyInjectionUnitTest
    {
        private readonly IServiceCollection _serviceCollection;

        public BusinessDependencyInjectionUnitTest()
        {
            _serviceCollection = new ServiceCollection();
        }

        [TestMethod]
        public void GetDependenciesInjection_Business_HaveAllDependencies()
        {
            var services = BusinessDependencyInjection.AdBusinessDependencyInjection(_serviceCollection);

            var characterService = services.Any(s => s.ServiceType == typeof(ICharacterService));
            var haveAllDependencies = characterService;

            Assert.IsTrue(haveAllDependencies);
        }
    }
}
