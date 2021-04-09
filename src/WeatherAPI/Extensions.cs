using WeatherAPI.Entities;
using WeatherAPI.Entities.Base;

namespace WeatherAPI
{
    public static class Extensions
    {
        #region Public Methods
        /// <summary>
        /// Builds the request configuration.
        /// </summary>
        public static RequestEntity Build<TBuilder>(this TBuilder builder)
            where TBuilder : BaseRequestEntityBuilder
        {
            builder.CheckParameters();

            var request = new RequestEntity();

            builder.ConfigureRequest(request);

            return request;
        }

        /// <summary>
        /// Configures the builder to determine location automatically based on the originating IP address of the request.
        /// </summary>
        public static TBuilder WithAutoIP<TBuilder>(this TBuilder builder)
            where TBuilder : BaseRequestEntityBuilder
        {
            builder.Query = "auto:ip";

            return builder;
        }

        /// <summary>
        /// Configures the builder to use a city name to determine location.
        /// </summary>
        /// <param name="cityName">The city name.</param>
        public static TBuilder WithCityName<TBuilder>(this TBuilder builder, string cityName)
            where TBuilder : BaseRequestEntityBuilder
        {
            builder.Query = cityName;

            return builder;
        }

        /// <summary>
        /// Configures the builder to use an International Air Transport Association 3 digit airport code to determine location.
        /// </summary>
        /// <param name="iata">The 3 digit airport code.</param>
        public static TBuilder WithIATA<TBuilder>(this TBuilder builder, string iata)
            where TBuilder : BaseRequestEntityBuilder
        {
            if (!string.IsNullOrWhiteSpace(iata))
                builder.Query = "iata:" + iata;

            return builder;
        }

        /// <summary>
        /// Configures the builder to use an IP address to determine location.
        /// </summary>
        /// <param name="ipAddress">The IP address.</param>
        public static TBuilder WithIPAddress<TBuilder>(this TBuilder builder, string ipAddress)
            where TBuilder : BaseRequestEntityBuilder
        {
            builder.Query = ipAddress;

            return builder;
        }

        /// <summary>
        /// Configures the builder to request any human-readable text in a specific language.
        /// </summary>
        /// <param name="language">The language code.</param>
        public static TBuilder WithLanguage<TBuilder>(this TBuilder builder, string language)
            where TBuilder : BaseRequestEntityBuilder
        {
            builder.Language = language;

            return builder;
        }

        /// <summary>
        /// Configures the request to use longitude and latitude to determine location.
        /// </summary>
        /// <param name="longitude">The longitude.</param>
        /// <param name="latitude">The latitude.</param>
        public static TBuilder WithLongitudeLatitude<TBuilder>(this TBuilder builder, float longitude, float latitude)
            where TBuilder : BaseRequestEntityBuilder
        {
            builder.Query = $"{longitude},{latitude}";

            return builder;
        }

        /// <summary>
        /// Configures the builder to use a METAR code to determine location.
        /// </summary>
        /// <param name="metar">The META code.</param>
        public static TBuilder WithMETAR<TBuilder>(this TBuilder builder, string metar)
            where TBuilder : BaseRequestEntityBuilder
        {
            if (!string.IsNullOrWhiteSpace(metar))
                builder.Query = "metar:" + metar;

            return builder;
        }

        /// <summary>
        /// Configures the builder to use a UK postcode to determine location.
        /// </summary>
        /// <param name="postcode">The postcode.</param>
        public static TBuilder WithPostcode<TBuilder>(this TBuilder builder, string postcode)
            where TBuilder : BaseRequestEntityBuilder
        {
            builder.Query = postcode;

            return builder;
        }

        /// <summary>
        /// Configures the builder to use a Canadian postal code to determine location.
        /// </summary>
        /// <param name="postalCode">The postal code.</param>
        public static TBuilder WithPostalCode<TBuilder>(this TBuilder builder, string postalCode)
            where TBuilder : BaseRequestEntityBuilder
        {
            builder.Query = postalCode;

            return builder;
        }

        /// <summary>
        /// Configures the builder to use a US ZIP code to determine location.
        /// </summary>
        /// <param name="zip">The ZIP code.</param>
        public static TBuilder WithZIP<TBuilder>(this TBuilder builder, int zip)
            where TBuilder : BaseRequestEntityBuilder
        {
            builder.Query = zip.ToString();

            return builder;
        }
        #endregion
    }
}
