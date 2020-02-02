using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MarvelCharacters.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MarvelCharacters.Data
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _db;

        public Repository(DbContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
            _db = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> where = null) 
        {
            if (where != null)
            {
                return await _db.Where(where).ToListAsync();
            }

            return await _db.ToListAsync();
        }

        public async Task<TEntity> Get(int id)
        {
			return await _db.FindAsync(id);         
        }
    }
}
