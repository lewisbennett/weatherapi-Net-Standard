using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.Entities;

namespace WeatherAPI.Operations.Base
{
    public interface IForecastOperations : IOperations
    {
        #region Methods
        /// <summary>
        /// Gets the forecast using automatic location.
        /// </summary>
        Task<ForecastResponseEntity> GetForecastAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the forecast using automatic location.
        /// </summary>
        Task<TForecastResponseEntity> GetForecastAsync<TForecastResponseEntity>(CancellationToken cancellationToken = default)
            where TForecastResponseEntity : class;

        /// <summary>
        /// Gets the forecast using automatic location.
        /// </summary>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        Task<ForecastResponseEntity> GetForecastAsync(bool includeAirQualityData, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the forecast using automatic location.
        /// </summary>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        Task<TForecastResponseEntity> GetForecastAsync<TForecastResponseEntity>(bool includeAirQualityData, CancellationToken cancellationToken = default)
            where TForecastResponseEntity : class;

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        Task<ForecastResponseEntity> GetForecastAsync(RequestEntity query, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        Task<TForecastResponseEntity> GetForecastAsync<TForecastResponseEntity>(RequestEntity query, CancellationToken cancellationToken = default)
            where TForecastResponseEntity : class;

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        Task<ForecastResponseEntity> GetForecastAsync(RequestEntity query, bool includeAirQualityData, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        Task<TForecastResponseEntity> GetForecastAsync<TForecastResponseEntity>(RequestEntity query, bool includeAirQualityData, CancellationToken cancellationToken = default)
            where TForecastResponseEntity : class;
        #endregion
    }
}
