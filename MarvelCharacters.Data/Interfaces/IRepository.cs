using System.Linq;

namespace MarvelCharacters.Data.Interfaces
{
	public interface IRepository<TEntity>
    {
        IQueryable<TEntity> Get(); 
        TEntity Get(int id);
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
