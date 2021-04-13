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
        public virtual Task<TForecastEntity> GetForecastEntity<TForecastEntity>(CancellationToken cancellationToken = default)
            where TForecastEntity : class
        {
            return ((IForecastOperations)this).GetForecastAsync<TForecastEntity>(new ForecastRequestEntity.Builder().Build(), cancellationToken);
        }

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<ForecastEntity> GetForecastAsync(ForecastRequestEntity request, CancellationToken cancellationToken = default)
        {
            return ((IForecastOperations)this).GetForecastAsync<ForecastEntity>(request, cancellationToken);
        }

        /// <summary>
        /// Gets the forecast.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<TForecastEntity> GetForecastAsync<TForecastEntity>(ForecastRequestEntity request, CancellationToken cancellationToken = default)
            where TForecastEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<TForecastEntity>(HttpMethod.Get, "forecast.json", request.GetParameters(), null, cancellationToken);
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
