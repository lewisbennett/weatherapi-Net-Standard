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
        /// Gets the current weather condition using automatic location.
        /// </summary>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        Task<RealtimeResponseEntity> GetCurrentAsync(bool includeAirQualityData, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the current weather condition using automatic location.
        /// </summary>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        Task<TRealtimeResponseEntity> GetCurrentAsync<TRealtimeResponseEntity>(bool includeAirQualityData, CancellationToken cancellationToken = default)
            where TRealtimeResponseEntity : class;

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        Task<RealtimeResponseEntity> GetCurrentAsync(RequestQuery query, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        Task<TRealtimeResponseEntity> GetCurrentAsync<TRealtimeResponseEntity>(RequestQuery query, CancellationToken cancellationToken = default)
            where TRealtimeResponseEntity : class;

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        Task<RealtimeResponseEntity> GetCurrentAsync(RequestQuery query, bool includeAirQualityData, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        Task<TRealtimeResponseEntity> GetCurrentAsync<TRealtimeResponseEntity>(RequestQuery query, bool includeAirQualityData, CancellationToken cancellationToken = default)
            where TRealtimeResponseEntity : class;
        #endregion
    }
}
