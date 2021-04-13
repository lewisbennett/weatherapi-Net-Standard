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
        Task<ForecastEntity> GetForecastAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the forecast using automatic location.
        /// </summary>
        Task<TForecastEntity> GetForecastAsync<TForecastEntity>(CancellationToken cancellationToken = default)
            where TForecastEntity : class;

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        Task<ForecastEntity> GetForecastAsync(RequestQuery query, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        Task<TForecastEntity> GetForecastAsync<TForecastEntity>(RequestQuery query, CancellationToken cancellationToken = default)
            where TForecastEntity : class;
        #endregion
    }
}
