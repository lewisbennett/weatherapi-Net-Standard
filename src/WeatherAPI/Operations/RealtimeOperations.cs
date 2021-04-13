using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.Base;
using WeatherAPI.Entities;
using WeatherAPI.Operations.Base;

namespace WeatherAPI.Operations
{
    public class RealtimeOperations : BaseOperations, IRealtimeOperations
    {
        #region Public Methods
        /// <summary>
        /// Gets the current weather condition using automatic location.
        /// </summary>
        public virtual Task<RealtimeResponseEntity> GetCurrentAsync(CancellationToken cancellationToken = default)
        {
            return ((IRealtimeOperations)this).GetCurrentAsync<RealtimeResponseEntity>(cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition using automatic location.
        /// </summary>
        public virtual Task<TRealtimeResponseEntity> GetCurrentAsync<TRealtimeResponseEntity>(CancellationToken cancellationToken = default)
            where TRealtimeResponseEntity : class
        {
            return ((IRealtimeOperations)this).GetCurrentAsync<TRealtimeResponseEntity>(false, cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition using automatic location.
        /// </summary>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        public virtual Task<RealtimeResponseEntity> GetCurrentAsync(bool includeAirQualityData, CancellationToken cancellationToken = default)
        {
            return ((IRealtimeOperations)this).GetCurrentAsync<RealtimeResponseEntity>(includeAirQualityData, cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition using automatic location.
        /// </summary>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        public virtual Task<TRealtimeResponseEntity> GetCurrentAsync<TRealtimeResponseEntity>(bool includeAirQualityData, CancellationToken cancellationToken = default)
            where TRealtimeResponseEntity : class
        {
            return ((IRealtimeOperations)this).GetCurrentAsync<TRealtimeResponseEntity>(RequestQuery.CreateFromAutoIP(), includeAirQualityData, cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        public virtual Task<RealtimeResponseEntity> GetCurrentAsync(RequestQuery query, CancellationToken cancellationToken = default)
        {
            return ((IRealtimeOperations)this).GetCurrentAsync<RealtimeResponseEntity>(query, cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        public virtual Task<TRealtimeResponseEntity> GetCurrentAsync<TRealtimeResponseEntity>(RequestQuery query, CancellationToken cancellationToken = default)
            where TRealtimeResponseEntity : class
        {
            return ((IRealtimeOperations)this).GetCurrentAsync<TRealtimeResponseEntity>(query, false, cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        public virtual Task<RealtimeResponseEntity> GetCurrentAsync(RequestQuery query, bool includeAirQualityData, CancellationToken cancellationToken = default)
        {
            return ((IRealtimeOperations)this).GetCurrentAsync<RealtimeResponseEntity>(query, includeAirQualityData, cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        public virtual Task<TRealtimeResponseEntity> GetCurrentAsync<TRealtimeResponseEntity>(RequestQuery query, bool includeAirQualityData, CancellationToken cancellationToken = default)
            where TRealtimeResponseEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<TRealtimeResponseEntity>(HttpMethod.Get, "current.json", null, cancellationToken, query.LanguageQueryParameter, query.QueryQueryParameter, $"aqi={(includeAirQualityData ? "yes" : "no")}");
        }
        #endregion

        #region Constructors
        public RealtimeOperations(IApiRequestor apiRequestor)
            : base(apiRequestor)
        {
        }
        #endregion
    }
}
