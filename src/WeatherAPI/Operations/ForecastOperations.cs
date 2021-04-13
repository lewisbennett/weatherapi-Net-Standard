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
        #region Methods
        /// <summary>
        /// Gets the forecast using automatic location.
        /// </summary>
        public virtual Task<ForecastEntity> GetForecastAsync(CancellationToken cancellationToken = default)
        {
            return ((IForecastOperations)this).GetForecastAsync<ForecastEntity>(cancellationToken);
        }

        /// <summary>
        /// Gets the forecast using automatic location.
        /// </summary>
        public virtual Task<TForecastEntity> GetForecastAsync<TForecastEntity>(CancellationToken cancellationToken = default)
            where TForecastEntity : class
        {
            return ((IForecastOperations)this).GetForecastAsync<TForecastEntity>(RequestQuery.CreateFromAutoIP(), cancellationToken);
        }

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        public virtual Task<ForecastEntity> GetForecastAsync(RequestQuery query, CancellationToken cancellationToken = default)
        {
            return ((IForecastOperations)this).GetForecastAsync<ForecastEntity>(query, cancellationToken);
        }

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="query">The request configuration.</param>
        public virtual Task<TForecastEntity> GetForecastAsync<TForecastEntity>(RequestQuery query, CancellationToken cancellationToken = default)
            where TForecastEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<TForecastEntity>(HttpMethod.Get, "forecast.json", null, cancellationToken, query.LanguageQueryParameter, query.QueryQueryParameter);
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
