using Newtonsoft.Json;

namespace WeatherAPI.NET.Entities
{
    public class AstronomyResponseEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the astronomy information for the day.
        /// </summary>
        [JsonProperty("astronomy")]
        public AstronomyEntity Astronomy { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [JsonProperty("location")]
        public LocationEntity Location { get; set; }
        #endregion
    }
}
