using Newtonsoft.Json;
using System;

namespace WeatherAPI.Entities
{
    public class LocationEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the name of the country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [JsonProperty("lat")]
        public float Latitude { get; set; }

        /// <summary>
        /// Gets or sets the local time.
        /// </summary>
        [JsonProperty("localtime")]
        public DateTime LocalTime { get; set; }

        /// <summary>
        /// Gets or sets the local time, in unix time. 
        /// </summary>
        [JsonProperty("localtime_epoch")]
        public long LocalTimeEpoch { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonProperty("lon")]
        public float Longitude { get; set; }

        /// <summary>
        /// Gets or sets the location name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the location region/state, if any.
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the time zone ID, in TZDB format.
        /// </summary>
        [JsonProperty("tz_id")]
        public string TimeZoneID { get; set; }
        #endregion
    }
}
