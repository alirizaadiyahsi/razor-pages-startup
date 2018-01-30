using System.Threading.Tasks;
using BaseProjectTemplate.EntityFramework.Repositories;

namespace BaseProjectTemplate.EntityFramework.Uow
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        Task<int> SaveChangesAsync();
    }
}
