using Newtonsoft.Json;

namespace WeatherAPI.Entities
{
    public class ForecastResponseEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the weather alerts, if any.
        /// </summary>
        [JsonProperty("alerts")]
        public AlertsEntity Alerts { get; set; }

        /// <summary>
        /// Gets or sets the current weather information for the location.
        /// </summary>
        [JsonProperty("current")]
        public CurrentEntity Current { get; set; }

        /// <summary>
        /// Gets or sets the forecast for the location.
        /// </summary>
        [JsonProperty("forecast")]
        public ForecastEntity Forecast { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [JsonProperty("location")]
        public LocationEntity Location { get; set; }
        #endregion
    }
}
