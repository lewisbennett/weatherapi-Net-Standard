using Newtonsoft.Json;

namespace WeatherAPI.Entities
{
    public class TimeZoneResponseEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the location information.
        /// </summary>
        [JsonProperty("location")]
        public LocationEntity Location { get; set; }
        #endregion
    }
}
