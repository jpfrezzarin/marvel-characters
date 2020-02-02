using MarvelCharacters.Data.DependencyInjection;
using MarvelCharacters.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MarvelCharacters.Data.Test.DependencyInjection
{
    [TestClass]
    public class DataDependencyInjectionUnitTest
    {
        private readonly IServiceCollection _serviceCollection;

        public DataDependencyInjectionUnitTest()
        {
            _serviceCollection = new ServiceCollection();
        }

        [TestMethod]
        public void GetDependenciesInjection_Business_HaveAllDependencies()
        {
            var services = DataDependencyInjection.AddDataDependencyInjection(_serviceCollection);

            var unitOfWork = services.Any(s => s.ServiceType == typeof(IUnitOfWork));
            var haveAllDependencies = unitOfWork;

            Assert.IsTrue(haveAllDependencies);
        }
    }
}
