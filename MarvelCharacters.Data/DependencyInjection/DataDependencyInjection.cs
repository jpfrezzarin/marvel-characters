using MarvelCharacters.Data;
using MarvelCharacters.Data.Context;
using MarvelCharacters.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MarvelCharacters.Data.DependencyInjection
{
    public static class DataDependencyInjection
    {
        public static IServiceCollection AddDataDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork<MarvelCharactersContext>>();

            return services;
        }
    }
}
