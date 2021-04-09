using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.Entities;

namespace WeatherAPI.Operations.Base
{
    public interface IRealtimeOperations : IOperations
    {
        #region Methods
        /// <summary>
        /// Gets the current weather condition using automatic location.
        /// </summary>
        Task<RealtimeResponseEntity> GetCurrentAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the current weather condition using automatic location.
        /// </summary>
        Task<TRealtimeResponseEntity> GetCurrentAsync<TRealtimeResponseEntity>(CancellationToken cancellationToken = default)
            where TRealtimeResponseEntity : class;

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<RealtimeResponseEntity> GetCurrentAsync(RealtimeRequestEntity request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<TRealtimeResponseEntity> GetCurrentAsync<TRealtimeResponseEntity>(RealtimeRequestEntity request, CancellationToken cancellationToken = default)
            where TRealtimeResponseEntity : class;
        #endregion
    }
}
