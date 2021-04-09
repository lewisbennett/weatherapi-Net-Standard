using Newtonsoft.Json;

namespace WeatherAPI.Entities
{
    public class AirQualityDataEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the carbon monixide count, in μg/m3.
        /// </summary>
        [JsonProperty("co")]
        public float CarbonMonoxide { get; set; }

        /// <summary>
        /// Gets or sets the UK Defra index.
        /// </summary>
        [JsonProperty("gb-defra-index")]
        public int GBDefraIndex { get; set; }

        /// <summary>
        /// Gets or sets the nitrogen dioxide count, in μg/m3.
        /// </summary>
        [JsonProperty("no2")]
        public float NitrogenDioxide { get; set; }

        /// <summary>
        /// Gets or sets the ozone count, in μg/m3.
        /// </summary>
        [JsonProperty("o3")]
        public float Ozone { get; set; }

        /// <summary>
        /// Gets or sets the PM 10 (particles no larger than 10 micrometers) count, in μg/m3.
        /// </summary>
        [JsonProperty("pm10")]
        public float PM10 { get; set; }

        /// <summary>
        /// Gets or sets the PM 2.5 (particles no larger than 2.5 micrometers) count, in μg/m3.
        /// </summary>
        [JsonProperty("pm2_5")]
        public float PM25 { get; set; }

        /// <summary>
        /// Gets or sets the sulphur dioxide count, in μg/m3.
        /// </summary>
        [JsonProperty("so2")]
        public float SulphurDioxide { get; set; }

        /// <summary>
        /// Gets or sets the US EPA index.
        /// </summary>
        [JsonProperty("us-epa-index")]
        public int USEPAIndex { get; set; }
        #endregion
    }
}
