using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace BaseProjectTemplate.EntityFramework.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {

    }
}
