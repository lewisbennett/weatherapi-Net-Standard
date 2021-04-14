using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.NET.Entities;

namespace WeatherAPI.NET.Operations.Base
{
    public interface ISportsOperations : IOperations
    {
        #region Methods
        /// <summary>
        /// Gets local, upcoming sporting events using automatic location.
        /// </summary>
        Task<SportsResponseEntity> GetSportsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets local, upcoming sporting events using automatic location.
        /// </summary>
        Task<TSportsResponseEntity> GetSportsAsync<TSportsResponseEntity>(CancellationToken cancellationToken = default)
            where TSportsResponseEntity : class;

        /// <summary>
        /// Gets local, upcoming sporting events.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<SportsResponseEntity> GetSportsAsync(RequestEntity request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets local, upcoming sporting events.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<TSportsResponseEntity> GetSportsAsync<TSportsResponseEntity>(RequestEntity request, CancellationToken cancellationToken = default)
            where TSportsResponseEntity : class;
        #endregion
    }
}
