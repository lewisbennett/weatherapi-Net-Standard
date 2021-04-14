using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.NET.Base;
using WeatherAPI.NET.Entities;
using WeatherAPI.NET.Operations.Base;

namespace WeatherAPI.NET.Operations
{
    public class HistoryOperations : BaseOperations, IHistoryOperations
    {
        #region Public Methods
        /// <summary>
        /// Gets historical weather forecast data.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<HistoryResponseEntity> GetHistoryAsync(HistoryRequestEntity request, CancellationToken cancellationToken = default)
        {
            return ((IHistoryOperations)this).GetHistoryAsync<HistoryResponseEntity>(request, cancellationToken);
        }

        /// <summary>
        /// Gets historical weather forecast data.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<THistoryResponseEntity> GetHistoryAsync<THistoryResponseEntity>(HistoryRequestEntity request, CancellationToken cancellationToken = default)
            where THistoryResponseEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<THistoryResponseEntity>(HttpMethod.Get, "history.json", request.GetQueryParameters(), null, cancellationToken);
        }
        #endregion

        #region Constructors
        public HistoryOperations(IApiRequestor apiRequestor)
            : base(apiRequestor)
        {
        }
        #endregion
    }
}
