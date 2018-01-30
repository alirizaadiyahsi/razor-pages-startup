using System;
using System.Collections.Generic;

namespace BaseProjectTemplate.EntityFramework.PagedList
{
    public class PagedList<T> : List<T>
    {
        private const int DefaultPageIndex = 0;
        private const int DefaultPageSize = 0;

        public int PageIndex { get; }
        public int TotalPages { get; }

        public PagedList(
            IEnumerable<T> items,
            int count,
            int pageIndex = DefaultPageIndex,
            int pageSize = DefaultPageSize
            )
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            AddRange(items);
        }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;
    }
}
