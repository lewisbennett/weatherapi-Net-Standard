using Newtonsoft.Json;

namespace WeatherAPI.NET.Entities
{
    public class AlertsEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the weather alerts, if any.
        /// </summary>
        [JsonProperty("alert")]
        public AlertEntity[] Alerts { get; set; }
        #endregion
    }
}
