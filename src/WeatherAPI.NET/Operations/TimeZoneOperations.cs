using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.NET.Base;
using WeatherAPI.NET.Entities;
using WeatherAPI.NET.Operations.Base;

namespace WeatherAPI.NET.Operations
{
    public class TimeZoneOperations : BaseOperations, ITimeZoneOperations
    {
        #region Public Methods
        /// <summary>
        /// Gets information about a time zone using automation location.
        /// </summary>
        public virtual Task<TimeZoneResponseEntity> GetTimeZoneAsync(CancellationToken cancellationToken = default)
        {
            return ((ITimeZoneOperations)this).GetTimeZoneAsync<TimeZoneResponseEntity>(cancellationToken);
        }

        /// <summary>
        /// Gets information about a time zone using automation location.
        /// </summary>
        public virtual Task<TTimeZoneResponseEntity> GetTimeZoneAsync<TTimeZoneResponseEntity>(CancellationToken cancellationToken = default)
            where TTimeZoneResponseEntity : class
        {
            return ((ITimeZoneOperations)this).GetTimeZoneAsync<TTimeZoneResponseEntity>(new RequestEntity(), cancellationToken);
        }

        /// <summary>
        /// Gets information about a time zone using automation location.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<TimeZoneResponseEntity> GetTimeZoneAsync(RequestEntity request, CancellationToken cancellationToken = default)
        {
            return ((ITimeZoneOperations)this).GetTimeZoneAsync<TimeZoneResponseEntity>(request, cancellationToken);
        }

        /// <summary>
        /// Gets information about a time zone using automation location.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        public virtual Task<TTimeZoneResponseEntity> GetTimeZoneAsync<TTimeZoneResponseEntity>(RequestEntity request, CancellationToken cancellationToken = default)
            where TTimeZoneResponseEntity : class
        {
            return ApiRequestor.RequestJsonSerializedAsync<TTimeZoneResponseEntity>(HttpMethod.Get, "timezone.json", request.GetQueryParameters(), null, cancellationToken);
        }
        #endregion

        #region Constructors
        public TimeZoneOperations(IApiRequestor apiRequestor)
            : base(apiRequestor)
        {
        }
        #endregion
    }
}
