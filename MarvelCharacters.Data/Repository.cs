using System;
using System.Linq;
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

        public IQueryable<TEntity> Get() 
        {
            return _db.AsQueryable<TEntity>();
        }

        public TEntity Get(int id)
        {
			return _db.Find(id);         
        }

        public TEntity Create(TEntity entity)
        {
            _db.Add(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }
    }
}
