using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MarvelCharacters.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MarvelCharacters.Data
{
    public class UnitOfWork<TContext> : IDisposable, IUnitOfWork where TContext : DbContext
    {
        private TContext _context;
        private Dictionary<Type, object> _repositories;
        private bool _disposed = false;

        public UnitOfWork(TContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

		public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories == null) _repositories = new Dictionary<Type, object>();
            var type = typeof(TEntity);
            if (!_repositories.ContainsKey(type)) _repositories[type] = new Repository<TEntity>(_context);
            return (IRepository<TEntity>)_repositories[type];
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.DisposeAsync();
                }

                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
