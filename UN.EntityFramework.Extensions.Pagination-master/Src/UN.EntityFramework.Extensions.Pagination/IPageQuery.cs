namespace UN.EntityFramework.Extensions.Pagination
{
    /// <summary>
    /// IPageQuery is the Pagination parameter for you List or EF Query. PageSize is upto your choice and PageNr should start from 1 or above.
    /// </summary>
    public interface IPageQuery
    {
        int PageSize { get; set; }

        int PageNr { get; set; }
    }
}
