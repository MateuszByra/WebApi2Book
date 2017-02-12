using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2Book.Data
{
    public class QueryResult<T>
    {
        public int TotalItemCount { get; private set; }
        public int TotalPageCount { get { return ResultsPagingUtility.CalculatePageCount(TotalItemCount, PageSize); } }
        public IEnumerable<T> QueriedItems { get; private set; }
        public int PageSize { get; private set; }

        public QueryResult(IEnumerable<T> queriedItems, int totalItemCount, int pageSize)
        {
            PageSize = pageSize;
            TotalItemCount = totalItemCount;
            QueriedItems = queriedItems;
        }
    }
}
