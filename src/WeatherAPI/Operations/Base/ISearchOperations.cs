using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.Entities;

namespace WeatherAPI.Operations.Base
{
    public interface ISearchOperations
    {
        #region Methods
        /// <summary>
        /// Searches for a location based on a query.
        /// </summary>
        /// <param name="query">The location query.</param>
        Task<SearchEntity> SearchAsync(string query, CancellationToken cancellationToken = default);

        /// <summary>
        /// Searches for a location based on a query.
        /// </summary>
        /// <param name="query">The location query.</param>
        Task<TSearchEntity> SearchAsync<TSearchEntity>(string query, CancellationToken cancellationToken = default);
        #endregion
    }
}
