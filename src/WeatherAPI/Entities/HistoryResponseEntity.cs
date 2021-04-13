using Newtonsoft.Json;

namespace WeatherAPI.Entities
{
    public class HistoryResponseEntity
    {
        #region Properties
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
