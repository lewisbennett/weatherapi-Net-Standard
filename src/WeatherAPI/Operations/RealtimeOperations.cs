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
        public virtual Task<CurrentEntity> GetCurrentAsync(CancellationToken cancellationToken = default)
        {
            return ((IRealtimeOperations)this).GetCurrentAsync<CurrentEntity>(cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition using automatic location.
        /// </summary>
        public virtual Task<TCurrentEntity> GetCurrentAsync<TCurrentEntity>(CancellationToken cancellationToken = default)
            where TCurrentEntity : class
        {
            return ((IRealtimeOperations)this).GetCurrentAsync<TCurrentEntity>(new RequestEntity.Builder().Build(), cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<CurrentEntity> GetCurrentAsync(RequestEntity request, CancellationToken cancellationToken = default)
        {
            return ((IRealtimeOperations)this).GetCurrentAsync<CurrentEntity>(new RequestEntity.Builder().Build(), cancellationToken);
        }

        /// <summary>
        /// Gets the current weather condition.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<TCurrentEntity> GetCurrentAsync<TCurrentEntity>(RequestEntity request, CancellationToken cancellationToken = default)
            where TCurrentEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<TCurrentEntity>(HttpMethod.Get, "current.json", request.GetParameters(), null, cancellationToken);
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
