using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MarvelCharacters.Data.Interfaces
{
	public interface IRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> where = null); 
        Task<TEntity> Get(int id);
    }
}
