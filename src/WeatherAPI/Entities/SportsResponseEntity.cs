using Newtonsoft.Json;

namespace WeatherAPI.Entities
{
    public class SportsResponseEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the cricket events taking place, if any.
        /// </summary>
        [JsonProperty("cricket")]
        public SportsEntity[] Cricket { get; set; }

        /// <summary>
        /// Gets or sets the football events taking place, if any.
        /// </summary>
        [JsonProperty("football")]
        public SportsEntity[] Football { get; set; }

        /// <summary>
        /// Gets or sets the golf events taking place, if any.
        /// </summary>
        [JsonProperty("golf")]
        public SportsEntity[] Golf { get; set; }
        #endregion
    }
}
