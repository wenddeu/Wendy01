using System;
using System.Linq;

namespace UN.EntityFramework.Extensions.Pagination
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> TakePageResult<T>(this IQueryable<T> query, IPageQuery pageData)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            if (pageData == null)
            {
                throw new ArgumentNullException(nameof(pageData));
            }

            if (pageData.PageNr <= 0)
            {
                throw new ArgumentException(nameof(IPageQuery.PageNr) + " should be equal and greater than 1.");
            }

            if (pageData.PageSize <= 0)
            {
                throw new ArgumentException("Invalid page size.");
            }

            return query.Skip((pageData.PageNr - 1) * pageData.PageSize).Take(pageData.PageSize);
        }
    }
}
