using System.Threading.Tasks;

namespace MarvelCharacters.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        Task<int> SaveChanges();
    }
}
