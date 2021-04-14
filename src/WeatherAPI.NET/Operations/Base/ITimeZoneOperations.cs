using System.Threading;
using System.Threading.Tasks;
using WeatherAPI.NET.Entities;

namespace WeatherAPI.NET.Operations.Base
{
    public interface ITimeZoneOperations : IOperations
    {
        #region Methods
        /// <summary>
        /// Gets information about a time zone using automation location.
        /// </summary>
        Task<TimeZoneResponseEntity> GetTimeZoneAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets information about a time zone using automation location.
        /// </summary>
        Task<TTimeZoneResponseEntity> GetTimeZoneAsync<TTimeZoneResponseEntity>(CancellationToken cancellationToken = default)
            where TTimeZoneResponseEntity : class;

        /// <summary>
        /// Gets information about a time zone using automation location.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<TimeZoneResponseEntity> GetTimeZoneAsync(RequestEntity request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets information about a time zone using automation location.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<TTimeZoneResponseEntity> GetTimeZoneAsync<TTimeZoneResponseEntity>(RequestEntity request, CancellationToken cancellationToken = default)
            where TTimeZoneResponseEntity : class;
        #endregion
    }
}
