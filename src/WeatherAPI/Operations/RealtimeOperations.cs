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
            return ((IRealtimeOperations)this).GetCurrentAsync<TRealtimeResponseEntity>(new RealtimeRequestEntity(), cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<RealtimeResponseEntity> GetCurrentAsync(RealtimeRequestEntity request, CancellationToken cancellationToken = default)
        {
            return ((IRealtimeOperations)this).GetCurrentAsync<RealtimeResponseEntity>(request, cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<TRealtimeResponseEntity> GetCurrentAsync<TRealtimeResponseEntity>(RealtimeRequestEntity request, CancellationToken cancellationToken = default)
            where TRealtimeResponseEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<TRealtimeResponseEntity>(HttpMethod.Get, "current.json", request.GetQueryParameters(), null, cancellationToken);
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
