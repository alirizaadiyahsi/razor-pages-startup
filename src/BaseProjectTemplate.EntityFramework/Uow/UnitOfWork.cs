using System;
using System.Threading.Tasks;
using BaseProjectTemplate.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BaseProjectTemplate.EntityFramework.Uow
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        public DbContext DbContext { get; }

        public UnitOfWork(DbContext context)
        {
            DbContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(DbContext);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await DbContext.SaveChangesAsync();
        }

        private bool _disposed;

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
            }

            _disposed = true;
        }
    }
}