using Newtonsoft.Json;
using WeatherAPI.Entities.Base;

namespace WeatherAPI.Entities
{
    public class AstronomyResponseEntity : BaseResponseEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the astronomy information for the day.
        /// </summary>
        [JsonProperty("astronomy")]
        public AstronomyEntity Astronomy { get; set; }
        #endregion
    }
}
