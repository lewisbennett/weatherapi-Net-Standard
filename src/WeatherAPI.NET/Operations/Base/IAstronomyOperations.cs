using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.NET.Entities;

namespace WeatherAPI.NET.Operations.Base
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
        /// <param name="request">The request configuration.</param>
        Task<AstronomyResponseEntity> GetAstronomyAsync(RequestEntity request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the current astronomy information.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<TAstronomyResponseEntity> GetAstronomyAsync<TAstronomyResponseEntity>(RequestEntity request, CancellationToken cancellationToken = default)
            where TAstronomyResponseEntity : class;
        #endregion
    }
}
