using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Domain.Models.Entities
{
    /// <summary>
    /// Representation of an Object returned by de statistic search methods using FindAsyncStatistic at RavenRepository
    /// this should return a list of TObject searched on database and the statistic information with pagination parameters as a unique result
    /// </summary>
    /// <typeparam name="T">object to be stored</typeparam>
    public class QueryStatisticListOfT<T>
    {
        /// <summary>
        /// Constructor for QueryStatisticListOfT with queryResults, offset, limit and totalElement params
        /// </summary>
        /// <param name="queryResults">Object list resut parameter</param>
        /// <param name="offset">Index of the resource requested by the query</param>
        /// <param name="limit">Number of resources to return in the result</param>
        /// <param name="totalElements">Total number of elements of the requested query without pagination </param>
        public QueryStatisticListOfT(List<T> queryResults, int offset, int limit, int totalElements)
        {
            QueryResults = queryResults;
            Offset = offset;
            Limit = limit;
            TotalElements = totalElements;
        }

        /// <summary>
        /// Object List to be stored
        /// </summary>
        public List<T> QueryResults { get; private set; }

        /// <summary>
        /// Index of the resource requested by the query
        /// </summary>
        public int Offset { get; private set; }

        /// <summary>
        /// Number of resources to return in the result
        /// </summary>
        public int Limit { get; private set; }

        /// <summary>
        /// Total number of elements of the requested query without pagination 
        /// </summary>
        public int TotalElements { get; private set; }
    }
}
