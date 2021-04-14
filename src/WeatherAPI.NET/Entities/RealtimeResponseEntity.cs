using Newtonsoft.Json;

namespace WeatherAPI.NET.Entities
{
    public class RealtimeResponseEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the current weather information for the location.
        /// </summary>
        [JsonProperty("current")]
        public CurrentEntity Current { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [JsonProperty("location")]
        public LocationEntity Location { get; set; }
        #endregion
    }
}
