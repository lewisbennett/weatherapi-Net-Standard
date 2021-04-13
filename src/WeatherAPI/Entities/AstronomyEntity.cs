using Newtonsoft.Json;

namespace WeatherAPI.Entities
{
    public class AstronomyEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the astronomy information.
        /// </summary>
        [JsonProperty("astro")]
        public AstroEntity Astro { get; set; }
        #endregion
    }
}
