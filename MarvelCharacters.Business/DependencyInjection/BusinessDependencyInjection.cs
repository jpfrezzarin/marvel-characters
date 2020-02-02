using MarvelCharacters.Business;
using MarvelCharacters.Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MarvelCharacters.Business.DependencyInjection
{
    public static class BusinessDependencyInjection
    {
        public static IServiceCollection AdBusinessDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<ICharacterService, CharacterService>();

            return services;
        }
    }
}
