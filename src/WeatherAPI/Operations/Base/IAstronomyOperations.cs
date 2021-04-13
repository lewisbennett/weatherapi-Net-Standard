using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.Entities;

namespace WeatherAPI.Operations.Base
{
    public interface IAstronomyOperations : IOperations
    {
        #region Methods
        /// <summary>
        /// Gets the current astronomy information using automatic location.
        /// </summary>
        Task<AstronomyResponseEntity> GetAstronomyAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the current astronomy information using automatic location.
        /// </summary>
        Task<TAstronomyResponseEntity> GetAstronomyAsync<TAstronomyResponseEntity>(CancellationToken cancellationToken = default)
            where TAstronomyResponseEntity : class;

        /// <summary>
        /// Gets the current astronomy information.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        Task<AstronomyResponseEntity> GetAstronomyAsync(RequestQuery query, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the current astronomy information.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        Task<TAstronomyResponseEntity> GetAstronomyAsync<TAstronomyResponseEntity>(RequestQuery query, CancellationToken cancellationToken = default)
            where TAstronomyResponseEntity : class;
        #endregion
    }
}
