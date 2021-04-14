using System;
using WeatherAPI.NET.Base;
using WeatherAPI.NET.Operations;
using WeatherAPI.NET.Operations.Base;

namespace WeatherAPI.NET
{
    public class WeatherAPIClient : BaseApiClient, IWeatherApiClient
    {
        #region Fields
        private readonly IAstronomyOperations _astronomyOperations;
        private readonly IForecastOperations _forecastOperations;
        private readonly IHistoryOperations _historyOperations;
        private readonly IIPLookupOperations _ipLookupOperations;
        private readonly IRealtimeOperations _realtimeOperations;
        private readonly ISearchOperations _searchOperations;
        private readonly ISportsOperations _sportsOperations;
        private readonly ITimeZoneOperations _timeZoneOperations;
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
        /// Gets the history API operations.
        /// </summary>
        public IHistoryOperations History => _historyOperations;

        /// <summary>
        /// Gets the IP address lookup operations.
        /// </summary>
        public IIPLookupOperations IPLookup => _ipLookupOperations;

        /// <summary>
        /// Gets the realtime API operations.
        /// </summary>
        public IRealtimeOperations Realtime => _realtimeOperations;

        /// <summary>
        /// Gets the search API operations.
        /// </summary>
        public ISearchOperations Search => _searchOperations;

        /// <summary>
        /// Gets the sports API operations;
        /// </summary>
        public ISportsOperations Sports => _sportsOperations;

        /// <summary>
        /// Gets the time zone API operations.
        /// </summary>
        public ITimeZoneOperations TimeZones => _timeZoneOperations;
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

        protected virtual IHistoryOperations ConstructHistoryOperations()
        {
            return new HistoryOperations(this);
        }

        protected virtual IIPLookupOperations ConstructIPLookupOperations()
        {
            return new IPLookupOperations(this);
        }

        protected virtual IRealtimeOperations ConstructRealtimeOperations()
        {
            return new RealtimeOperations(this);
        }

        protected virtual ISearchOperations ConstructSearchOperations()
        {
            return new SearchOperations(this);
        }

        protected virtual ISportsOperations ConstructSportsOperations()
        {
            return new SportsOperations(this);
        }

        protected virtual ITimeZoneOperations ConstructTimeZoneOperations()
        {
            return new TimeZoneOperations(this);
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new WeatherAPI.NET API client with an optional custom base URI.
        /// </summary>
        /// <param name="apiKey">Your WeatherAPI.NET API key.</param>
        /// <param name="baseApiUri">The base URI to use for the API, or null for default.</param>
        public WeatherAPIClient(string apiKey, Uri baseApiUri = null)
            : base(apiKey, baseApiUri)
        {
            _astronomyOperations = ConstructAstronomyOperations();
            _forecastOperations = ConstructForecastOperations();
            _historyOperations = ConstructHistoryOperations();
            _ipLookupOperations = ConstructIPLookupOperations();
            _realtimeOperations = ConstructRealtimeOperations();
            _searchOperations = ConstructSearchOperations();
            _sportsOperations = ConstructSportsOperations();
            _timeZoneOperations = ConstructTimeZoneOperations();
        }
        #endregion
    }
}
