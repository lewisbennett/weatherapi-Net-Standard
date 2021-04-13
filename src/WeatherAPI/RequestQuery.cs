using System;

namespace WeatherAPI
{
    public class RequestQuery
    {
        #region Fields
        private string _language, _query;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the configured language as a query parameter.
        /// </summary>
        internal string LanguageQueryParameter => string.IsNullOrWhiteSpace(_language) ? string.Empty : $"lang={_language}";

        /// <summary>
        /// Gets the configured query as a query parameter.
        /// </summary>
        internal string QueryQueryParameter
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_query))
                    throw new InvalidOperationException("The location for the request is invalid.");

                return $"q={_query}";
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Configures the request query to use automatic IP location.
        /// </summary>
        public RequestQuery WithAutoIP()
        {
            _query = "auto:ip";

            return this;
        }

        /// <summary>
        /// Configures the request query to use a city name to determine location.
        /// </summary>
        /// <param name="cityName">The city name.</param>
        public RequestQuery WithCityName(string cityName)
        {
            _query = cityName;

            return this;
        }

        /// <summary>
        /// Configures the request query to use an International Air Transport Association 3 digit airport code to determine location.
        /// </summary>
        /// <param name="iata">The 3 digit airport code.</param>
        public RequestQuery WithIATA(string iata)
        {
            if (!string.IsNullOrWhiteSpace(iata))
                _query = "iata:" + iata;

            return this;
        }

        /// <summary>
        /// Configures the request query to use an IP address to determine location.
        /// </summary>
        /// <param name="ipAddress">The IP address.</param>
        public RequestQuery WithIPAddress(string ipAddress)
        {
            _query = ipAddress;

            return this;
        }

        /// <summary>
        /// Configures the request query to return human-readable text in a specific language.
        /// </summary>
        /// <param name="language">The language code.</param>
        public RequestQuery WithLanguage(string language)
        {
            _language = language;

            return this;
        }

        /// <summary>
        /// Configures the request query to use longitude and latitude to determine location.
        /// </summary>
        /// <param name="longitude">The longitude.</param>
        /// <param name="latitude">The latitude.</param>
        public RequestQuery WithLogitudeLatitude(float longitude, float latitude)
        {
            _query = $"{longitude},{latitude}";

            return this;
        }

        /// <summary>
        /// Configures the request query to use a METAR code to determine location.
        /// </summary>
        /// <param name="metar">The META code.</param>
        public RequestQuery WithMETAR(string metar)
        {
            if (!string.IsNullOrWhiteSpace(metar))
                _query = "metar:" + metar;

            return this;
        }

        /// <summary>
        /// Configures the request query to use a Canadian postal code to determine location.
        /// </summary>
        /// <param name="postalCode">The postal code.</param>
        public RequestQuery WithPostalCode(string postalCode)
        {
            _query = postalCode;

            return this;
        }

        /// <summary>
        /// Configures the request query to use a UK postcode to determine location.
        /// </summary>
        /// <param name="postcode">The postcode.</param>
        public RequestQuery WithPostcode(string postcode)
        {
            _query = postcode;

            return this;
        }

        /// <summary>
        /// Configures the request query to use a US ZIP code to determine location.
        /// </summary>
        /// <param name="zip">The ZIP code.</param>
        public RequestQuery WithZIP(int zip)
        {
            _query = zip.ToString();

            return this;
        }
        #endregion

        #region Constructors
        // Disable public constructing, force to use static constructors.
        private RequestQuery()
        {
        }
        #endregion

        #region Public Static Methods
        /// <summary>
        /// Creates a request query based on automatic IP location.
        /// </summary>
        public static RequestQuery CreateFromAutoIP()
        {
            return new RequestQuery().WithAutoIP();
        }

        /// <summary>
        /// Creates a request query based on a city name to determine location.
        /// </summary>
        /// <param name="cityName">The city name.</param>
        public static RequestQuery CreateFromCityName(string cityName)
        {
            return new RequestQuery().WithCityName(cityName);
        }

        /// <summary>
        /// Creates a request query based on an International Air Transport Association 3 digit airport code to determine location.
        /// </summary>
        /// <param name="iata">The 3 digit airport code.</param>
        public static RequestQuery CreateFromIATA(string iata)
        {
            return new RequestQuery().WithIATA(iata);
        }

        /// <summary>
        /// Creates a request query based on an IP address to determine location.
        /// </summary>
        /// <param name="ipAddress">The IP address.</param>
        public static RequestQuery CreateFromIPAddress(string ipAddress)
        {
            return new RequestQuery().WithIPAddress(ipAddress);
        }

        /// <summary>
        /// Creates a request query based on longitude and latitude to determine location.
        /// </summary>
        /// <param name="longitude">The longitude.</param>
        /// <param name="latitude">The latitude.</param>
        public static RequestQuery CreateFromLongitudeLatitude(float longitude, float latitude)
        {
            return new RequestQuery().WithLogitudeLatitude(longitude, latitude);
        }

        /// <summary>
        /// Creates a request query based on a METAR code to determine location.
        /// </summary>
        /// <param name="metar">The META code.</param>
        public static RequestQuery CreateFromMETAR(string metar)
        {
            return new RequestQuery().WithMETAR(metar);
        }

        /// <summary>
        /// Creates a request query based on a Canadian postal code to determine location.
        /// </summary>
        /// <param name="postalCode">The postal code.</param>
        public static RequestQuery CreateFromPostalCode(string postalCode)
        {
            return new RequestQuery().WithPostalCode(postalCode);
        }

        /// <summary>
        /// Creates a request query based on a UK postcode to determine location.
        /// </summary>
        /// <param name="postcode">The postcode.</param>
        public static RequestQuery CreateFromPostcode(string postcode)
        {
            return new RequestQuery().WithPostcode(postcode);
        }

        /// <summary>
        /// Creates a request query based on a US ZIP code to determine location.
        /// </summary>
        /// <param name="zip">The ZIP code.</param>
        public static RequestQuery CreateFromZIP(int zip)
        {
            return new RequestQuery().WithZIP(zip);
        }
        #endregion
    }
}
