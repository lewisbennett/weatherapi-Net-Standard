using System;

namespace WeatherAPI.Entities
{
    public class RequestEntity
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
        public RequestEntity WithAutoIP()
        {
            _query = "auto:ip";

            return this;
        }

        /// <summary>
        /// Configures the request query to use a city name to determine location.
        /// </summary>
        /// <param name="cityName">The city name.</param>
        public RequestEntity WithCityName(string cityName)
        {
            _query = cityName;

            return this;
        }

        /// <summary>
        /// Configures the request query to use an International Air Transport Association 3 digit airport code to determine location.
        /// </summary>
        /// <param name="iata">The 3 digit airport code.</param>
        public RequestEntity WithIATA(string iata)
        {
            if (!string.IsNullOrWhiteSpace(iata))
                _query = "iata:" + iata;

            return this;
        }

        /// <summary>
        /// Configures the request query to use an IP address to determine location.
        /// </summary>
        /// <param name="ipAddress">The IP address.</param>
        public RequestEntity WithIPAddress(string ipAddress)
        {
            _query = ipAddress;

            return this;
        }

        /// <summary>
        /// Configures the request query to return human-readable text in a specific language.
        /// </summary>
        /// <param name="language">The language code.</param>
        public RequestEntity WithLanguage(string language)
        {
            _language = language;

            return this;
        }

        /// <summary>
        /// Configures the request query to use longitude and latitude to determine location.
        /// </summary>
        /// <param name="longitude">The longitude.</param>
        /// <param name="latitude">The latitude.</param>
        public RequestEntity WithLogitudeLatitude(float longitude, float latitude)
        {
            _query = $"{longitude},{latitude}";

            return this;
        }

        /// <summary>
        /// Configures the request query to use a METAR code to determine location.
        /// </summary>
        /// <param name="metar">The META code.</param>
        public RequestEntity WithMETAR(string metar)
        {
            if (!string.IsNullOrWhiteSpace(metar))
                _query = "metar:" + metar;

            return this;
        }

        /// <summary>
        /// Configures the request query to use a Canadian postal code to determine location.
        /// </summary>
        /// <param name="postalCode">The postal code.</param>
        public RequestEntity WithPostalCode(string postalCode)
        {
            _query = postalCode;

            return this;
        }

        /// <summary>
        /// Configures the request query to use a UK postcode to determine location.
        /// </summary>
        /// <param name="postcode">The postcode.</param>
        public RequestEntity WithPostcode(string postcode)
        {
            _query = postcode;

            return this;
        }

        /// <summary>
        /// Configures the request query to use a US ZIP code to determine location.
        /// </summary>
        /// <param name="zip">The ZIP code.</param>
        public RequestEntity WithZIP(int zip)
        {
            _query = zip.ToString();

            return this;
        }
        #endregion

        #region Constructors
        // Disable public constructing, force to use static constructors.
        private RequestEntity()
        {
        }
        #endregion

        #region Public Static Methods
        /// <summary>
        /// Creates a request query based on automatic IP location.
        /// </summary>
        public static RequestEntity CreateFromAutoIP()
        {
            return new RequestEntity().WithAutoIP();
        }

        /// <summary>
        /// Creates a request query based on a city name to determine location.
        /// </summary>
        /// <param name="cityName">The city name.</param>
        public static RequestEntity CreateFromCityName(string cityName)
        {
            return new RequestEntity().WithCityName(cityName);
        }

        /// <summary>
        /// Creates a request query based on an International Air Transport Association 3 digit airport code to determine location.
        /// </summary>
        /// <param name="iata">The 3 digit airport code.</param>
        public static RequestEntity CreateFromIATA(string iata)
        {
            return new RequestEntity().WithIATA(iata);
        }

        /// <summary>
        /// Creates a request query based on an IP address to determine location.
        /// </summary>
        /// <param name="ipAddress">The IP address.</param>
        public static RequestEntity CreateFromIPAddress(string ipAddress)
        {
            return new RequestEntity().WithIPAddress(ipAddress);
        }

        /// <summary>
        /// Creates a request query based on longitude and latitude to determine location.
        /// </summary>
        /// <param name="longitude">The longitude.</param>
        /// <param name="latitude">The latitude.</param>
        public static RequestEntity CreateFromLongitudeLatitude(float longitude, float latitude)
        {
            return new RequestEntity().WithLogitudeLatitude(longitude, latitude);
        }

        /// <summary>
        /// Creates a request query based on a METAR code to determine location.
        /// </summary>
        /// <param name="metar">The META code.</param>
        public static RequestEntity CreateFromMETAR(string metar)
        {
            return new RequestEntity().WithMETAR(metar);
        }

        /// <summary>
        /// Creates a request query based on a Canadian postal code to determine location.
        /// </summary>
        /// <param name="postalCode">The postal code.</param>
        public static RequestEntity CreateFromPostalCode(string postalCode)
        {
            return new RequestEntity().WithPostalCode(postalCode);
        }

        /// <summary>
        /// Creates a request query based on a UK postcode to determine location.
        /// </summary>
        /// <param name="postcode">The postcode.</param>
        public static RequestEntity CreateFromPostcode(string postcode)
        {
            return new RequestEntity().WithPostcode(postcode);
        }

        /// <summary>
        /// Creates a request query based on a US ZIP code to determine location.
        /// </summary>
        /// <param name="zip">The ZIP code.</param>
        public static RequestEntity CreateFromZIP(int zip)
        {
            return new RequestEntity().WithZIP(zip);
        }
        #endregion
    }
}
