using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BaseProjectTemplate.EntityFramework.PagedList
{
    public static class PagedListExtensions
    {
        public static async Task<PagedList<T>> ToPagedListAsync<T>(
            this IQueryable<T> source,
            int pageIndex,
            int pageSize
        )
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            return new PagedList<T>(items, count, pageIndex, pageSize);
        }
    }
}