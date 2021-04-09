using Newtonsoft.Json;
using WeatherAPI.Entities.Base;

namespace WeatherAPI.Entities
{
    public class RealtimeResponseEntity : BaseResponseEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the current weather information for the location.
        /// </summary>
        [JsonProperty("current")]
        public CurrentEntity Current { get; set; }
        #endregion
    }
}
