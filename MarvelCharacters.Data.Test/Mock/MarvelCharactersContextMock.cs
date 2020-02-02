using MarvelCharacters.Models;
using Microsoft.EntityFrameworkCore;

namespace MarvelCharacters.Data.Test.Mock
{
    public class MarvelCharactersContextMock : DbContext
    {
        public DbSet<Character> Characters { get; set; }
    }
}
