using WeatherAPI.Entities.Base;

namespace WeatherAPI
{
    public static class Extensions
    {
        #region Public Methods
        /// <summary>
        /// Configures the request to use automatic IP location.
        /// </summary>
        public static TRequestEntity WithAutoIP<TRequestEntity>(this TRequestEntity requestEntity)
            where TRequestEntity : BaseRequestEntity
        {
            requestEntity.Query = "auto:ip";

            return requestEntity;
        }

        /// <summary>
        /// Configures the request to use a city name to determine location.
        /// </summary>
        /// <param name="cityName">The city name.</param>
        public static TRequestEntity WithCityName<TRequestEntity>(this TRequestEntity requestEntity, string cityName)
            where TRequestEntity : BaseRequestEntity
        {
            requestEntity.Query = cityName;

            return requestEntity;
        }

        /// <summary>
        /// Configures the request to use an International Air Transport Association 3 digit airport code to determine location.
        /// </summary>
        /// <param name="iata">The 3 digit airport code.</param>
        public static TRequestEntity WithIATA<TRequestEntity>(this TRequestEntity requestEntity, string iata)
            where TRequestEntity : BaseRequestEntity
        {
            if (!string.IsNullOrWhiteSpace(iata))
                requestEntity.Query = "iata:" + iata;

            return requestEntity;
        }

        /// <summary>
        /// Configures the request to use an IP address to determine location.
        /// </summary>
        /// <param name="ipAddress">The IP address.</param>
        public static TRequestEntity WithIPAddress<TRequestEntity>(this TRequestEntity requestEntity, string ipAddress)
            where TRequestEntity : BaseRequestEntity
        {
            requestEntity.Query = ipAddress;

            return requestEntity;
        }

        /// <summary>
        /// Configures the request to return human-readable text in a specific language.
        /// </summary>
        /// <param name="language">The language code.</param>
        public static TRequestEntity WithLanguage<TRequestEntity>(this TRequestEntity requestEntity, string language)
            where TRequestEntity : BaseRequestEntity
        {
            requestEntity.Language = language;

            return requestEntity;
        }

        /// <summary>
        /// Configures the request to use longitude and latitude to determine location.
        /// </summary>
        /// <param name="longitude">The longitude.</param>
        /// <param name="latitude">The latitude.</param>
        public static TRequestEntity WithLogitudeLatitude<TRequestEntity>(this TRequestEntity requestEntity, float longitude, float latitude)
            where TRequestEntity : BaseRequestEntity
        {
            requestEntity.Query = $"{longitude},{latitude}";

            return requestEntity;
        }

        /// <summary>
        /// Configures the request to use a METAR code to determine location.
        /// </summary>
        /// <param name="metar">The META code.</param>
        public static TRequestEntity WithMETAR<TRequestEntity>(this TRequestEntity requestEntity, string metar)
            where TRequestEntity : BaseRequestEntity
        {
            if (!string.IsNullOrWhiteSpace(metar))
                requestEntity.Query = "metar:" + metar;

            return requestEntity;
        }

        /// <summary>
        /// Configures the request to use a Canadian postal code to determine location.
        /// </summary>
        /// <param name="postalCode">The postal code.</param>
        public static TRequestEntity WithPostalCode<TRequestEntity>(this TRequestEntity requestEntity, string postalCode)
            where TRequestEntity : BaseRequestEntity
        {
            requestEntity.Query = postalCode;

            return requestEntity;
        }

        /// <summary>
        /// Configures the request to use a UK postcode to determine location.
        /// </summary>
        /// <param name="postcode">The postcode.</param>
        public static TRequestEntity WithPostcode<TRequestEntity>(this TRequestEntity requestEntity, string postcode)
            where TRequestEntity : BaseRequestEntity
        {
            requestEntity.Query = postcode;

            return requestEntity;
        }

        /// <summary>
        /// Configures the request to use a US ZIP code to determine location.
        /// </summary>
        /// <param name="zip">The ZIP code.</param>
        public static TRequestEntity WithZIP<TRequestEntity>(this TRequestEntity requestEntity, int zip)
            where TRequestEntity : BaseRequestEntity
        {
            requestEntity.Query = zip.ToString();

            return requestEntity;
        }
        #endregion
    }
}
