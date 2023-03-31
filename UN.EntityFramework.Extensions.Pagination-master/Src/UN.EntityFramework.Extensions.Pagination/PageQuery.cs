using System;

namespace UN.EntityFramework.Extensions.Pagination
{
    public class PageQuery : IPageQuery
    {
        private int _PageSize;

        public int PageSize
        {
            get => _PageSize;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("_PageSize cannot be less or equal than 0.");
                }

                _PageSize = value;
            }
        }

        private int _PageNr;
        public int PageNr
        {
            get => _PageNr;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("PageNr cannot be less than 1.");
                }

                _PageNr = value;
            }
        }
    }
}
