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
        /// Gets the forecast.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<ForecastResponseEntity> GetForecastAsync(ForecastRequestEntity request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<TForecastResponseEntity> GetForecastAsync<TForecastResponseEntity>(ForecastRequestEntity request, CancellationToken cancellationToken = default)
            where TForecastResponseEntity : class;
        #endregion
    }
}
