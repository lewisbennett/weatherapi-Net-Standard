using WeatherAPI.Operations.Base;

namespace WeatherAPI.Base
{
    public interface IWeatherApiClient : IApiRequestor
    {
        #region Properties
        /// <summary>
        /// Gets the astronomy API operations.
        /// </summary>
        IAstronomyOperations Astronomy { get; }

        /// <summary>
        /// Gets the forecast API operations.
        /// </summary>
        IForecastOperations Forecast { get; }

        /// <summary>
        /// Gets the history API operations.
        /// </summary>
        IHistoryOperations History { get; }

        /// <summary>
        /// Gets the IP address lookup operations.
        /// </summary>
        IIPLookupOperations IPLookup { get; }

        /// <summary>
        /// Gets the realtime API operations.
        /// </summary>
        IRealtimeOperations Realtime { get; }

        /// <summary>
        /// Gets the sports API operations.
        /// </summary>
        ISportsOperations Sports { get; }

        /// <summary>
        /// Gets the time zone API operations.
        /// </summary>
        ITimeZoneOperations TimeZones { get; }
        #endregion
    }
}
