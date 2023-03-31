using System.Collections.Generic;

namespace UN.EntityFramework.Extensions.Pagination
{
    /// <summary>
    /// This class can have result from your query.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedResult<T>
    {
        public int PageSize { get; set; }

        public int PageNr { get; set; }

        public int TotalItems { get; set; }

        public ICollection<T> PageResults { get; set; }
    }
}
