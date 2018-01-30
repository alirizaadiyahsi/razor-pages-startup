using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BaseProjectTemplate.EntityFramework.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext DbContext;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(DbContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            DbSet = DbContext.Set<TEntity>();
        }
    }
}