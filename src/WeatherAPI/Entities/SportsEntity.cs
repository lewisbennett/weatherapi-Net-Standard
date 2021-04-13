using Newtonsoft.Json;
using System;

namespace WeatherAPI.Entities
{
    public class SportsEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the country in which the sporting event is taking place.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the match taking place.
        /// </summary>
        [JsonProperty("match")]
        public string Match { get; set; }

        /// <summary>
        /// Gets or sets the region in which  the sporting event is taking place.
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the stadium/venue of the sporting event.
        /// </summary>
        [JsonProperty("stadium")]
        public string Stadium { get; set; }

        /// <summary>
        /// Gets or sets the start of the sporting event.
        /// </summary>
        [JsonProperty("start")]
        public DateTime Start { get; set; }

        /// <summary>
        /// Gets or sets the name of the tournament taking place.
        /// </summary>
        [JsonProperty("tournament")]
        public string Tournament { get; set; }
        #endregion
    }
}
