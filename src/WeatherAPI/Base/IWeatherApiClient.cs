using WeatherAPI.Operations.Base;

namespace WeatherAPI.Base
{
    public interface IWeatherApiClient : IApiRequestor
    {
        #region Properties
        /// <summary>
        /// Gets the realtime API operations.
        /// </summary>
        IRealtimeOperations Realtime { get; }
        #endregion
    }
}
