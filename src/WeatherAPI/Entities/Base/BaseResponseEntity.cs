using Newtonsoft.Json;

namespace WeatherAPI.Entities.Base
{
    public abstract class BaseResponseEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [JsonProperty("location")]
        public LocationEntity Location { get; set; }
        #endregion
    }
}
