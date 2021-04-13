using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.Base;
using WeatherAPI.Entities;
using WeatherAPI.Operations.Base;

namespace WeatherAPI.Operations
{
    public class ForecastOperations : BaseOperations, IForecastOperations
    {
        #region Public Methods
        /// <summary>
        /// Gets the forecast using automatic location.
        /// </summary>
        public virtual Task<ForecastResponseEntity> GetForecastAsync(CancellationToken cancellationToken = default)
        {
            return ((IForecastOperations)this).GetForecastAsync<ForecastResponseEntity>(cancellationToken);
        }

        /// <summary>
        /// Gets the forecast using automatic location.
        /// </summary>
        public virtual Task<TForecastResponseEntity> GetForecastAsync<TForecastResponseEntity>(CancellationToken cancellationToken = default)
            where TForecastResponseEntity : class
        {
            return ((IForecastOperations)this).GetForecastAsync<TForecastResponseEntity>(RequestEntity.CreateFromAutoIP(), cancellationToken);
        }

        /// <summary>
        /// Gets the forecast using automatic location.
        /// </summary>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        public virtual Task<ForecastResponseEntity> GetForecastAsync(bool includeAirQualityData, CancellationToken cancellationToken = default)
        {
            return ((IForecastOperations)this).GetForecastAsync<ForecastResponseEntity>(includeAirQualityData, cancellationToken);
        }

        /// <summary>
        /// Gets the forecast using automatic location.
        /// </summary>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        public virtual Task<TForecastResponseEntity> GetForecastAsync<TForecastResponseEntity>(bool includeAirQualityData, CancellationToken cancellationToken = default)
            where TForecastResponseEntity : class
        {
            return ((IForecastOperations)this).GetForecastAsync<TForecastResponseEntity>(RequestEntity.CreateFromAutoIP(), includeAirQualityData, cancellationToken);
        }

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        public virtual Task<ForecastResponseEntity> GetForecastAsync(RequestEntity query, CancellationToken cancellationToken = default)
        {
            return ((IForecastOperations)this).GetForecastAsync<ForecastResponseEntity>(query, cancellationToken);
        }

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        public virtual Task<TForecastResponseEntity> GetForecastAsync<TForecastResponseEntity>(RequestEntity query, CancellationToken cancellationToken = default)
            where TForecastResponseEntity : class
        {
            return ((IForecastOperations)this).GetForecastAsync<TForecastResponseEntity>(query, false, cancellationToken);
        }

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        public virtual Task<ForecastResponseEntity> GetForecastAsync(RequestEntity query, bool includeAirQualityData, CancellationToken cancellationToken = default)
        {
            return ((IForecastOperations)this).GetForecastAsync<ForecastResponseEntity>(query, includeAirQualityData, cancellationToken);
        }

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        public virtual Task<TForecastResponseEntity> GetForecastAsync<TForecastResponseEntity>(RequestEntity query, bool includeAirQualityData, CancellationToken cancellationToken = default)
            where TForecastResponseEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<TForecastResponseEntity>(HttpMethod.Get, "forecast.json", null, cancellationToken, query.LanguageQueryParameter, query.QueryQueryParameter, $"aqi={(includeAirQualityData ? "yes" : "no")}");
        }
        #endregion

        #region Constructors
        public ForecastOperations(IApiRequestor apiRequestor)
            : base(apiRequestor)
        {
        }
        #endregion
    }
}
