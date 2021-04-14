using Newtonsoft.Json;

namespace WeatherAPI.NET.Entities
{
    public class SearchEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the result ID.
        /// </summary>
        [JsonProperty("id")]
        public long ID { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [JsonProperty("lat")]
        public float Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonProperty("lon")]
        public float Longitude { get; set; }

        /// <summary>
        /// Gets or sets the search result name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the location URL.
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }
        #endregion
    }
}
