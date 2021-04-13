using System;
using WeatherAPI.Base;
using WeatherAPI.Operations;
using WeatherAPI.Operations.Base;

namespace WeatherAPI
{
    public class WeatherAPIClient : BaseApiClient, IWeatherApiClient
    {
        #region Fields
        private readonly IAstronomyOperations _astronomyOperations;
        private readonly IForecastOperations _forecastOperations;
        private readonly IRealtimeOperations _realtimeOperations;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the astronomy API operations.
        /// </summary>
        public IAstronomyOperations Astronomy => _astronomyOperations;

        /// <summary>
        /// Gets the forecast API operations.
        /// </summary>
        public IForecastOperations Forecast => _forecastOperations;

        /// <summary>
        /// Gets the realtime API operations.
        /// </summary>
        public IRealtimeOperations Realtime => _realtimeOperations;
        #endregion

        #region Protected Methods
        protected virtual IAstronomyOperations ConstructAstronomyOperations()
        {
            return new AstronomyOperations(this);
        }

        protected virtual IForecastOperations ConstructForecastOperations()
        {
            return new ForecastOperations(this);
        }

        protected virtual IRealtimeOperations ConstructRealtimeOperations()
        {
            return new RealtimeOperations(this);
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new WeatherAPI API client with an optional custom base URI.
        /// </summary>
        /// <param name="apiKey">Your WeatherAPI API key.</param>
        /// <param name="baseApiUri">The base URI to use for the API, or null for default.</param>
        public WeatherAPIClient(string apiKey, Uri baseApiUri = null)
            : base(apiKey, baseApiUri)
        {
            _astronomyOperations = ConstructAstronomyOperations();
            _forecastOperations = ConstructForecastOperations();
            _realtimeOperations = ConstructRealtimeOperations();
        }
        #endregion
    }
}
