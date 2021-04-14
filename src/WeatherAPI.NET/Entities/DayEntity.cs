using Newtonsoft.Json;

namespace WeatherAPI.NET.Entities
{
    public class DayEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the average humidity, as a percentage (0-100%).
        /// </summary>
        [JsonProperty("avghumidity")]
        public float AverageHumidity { get; set; }

        /// <summary>
        /// Gets or sets the average temperature, in Celcius.
        /// </summary>
        [JsonProperty("avgtemp_c")]
        public float AverageTemperatureC { get; set; }

        /// <summary>
        /// Gets or sets the average temperature, in Fahrenheit.
        /// </summary>
        [JsonProperty("avgtemp_f")]
        public float AverageTemperatureF { get; set; }

        /// <summary>
        /// Gets or sets the average visibility, in kilometers.
        /// </summary>
        [JsonProperty("avgvis_km")]
        public float AverageVisibilityKm { get; set; }

        /// <summary>
        /// Gets or sets the average visibility, in miles.
        /// </summary>
        [JsonProperty("avgvis_miles")]
        public float AverageVisibilityMi { get; set; }

        /// <summary>
        /// Gets or sets the chance of rain, as a percentage (0-100%).
        /// </summary>
        [JsonProperty("daily_chance_of_rain")]
        public int ChanceOfRain { get; set; }

        /// <summary>
        /// Gets or sets the chance of snow, as a percentage (0-100%).
        /// </summary>
        [JsonProperty("daily_chance_of_snow")]
        public int ChanceOfSnow { get; set; }

        /// <summary>
        /// Gets or sets the weather condition information.
        /// </summary>
        [JsonProperty("condition")]
        public ConditionEntity Condition { get; set; }

        /// <summary>
        /// Gets or sets the maximum temperature, in Celcius.
        /// </summary>
        [JsonProperty("maxtemp_c")]
        public float MaximumTemperatureC { get; set; }

        /// <summary>
        /// Gets or sets the maximum temperature, in Fahrenheit.
        /// </summary>
        [JsonProperty("maxtemp_f")]
        public float MaximumTemperatureF { get; set; }

        /// <summary>
        /// Gets or sets the maximum wind speed, in kilometers per hour.
        /// </summary>
        [JsonProperty("maxwind_kph")]
        public float MaximumWindKPH { get; set; }

        /// <summary>
        /// Gets or sets the maximum wind speed, in miles per hour.
        /// </summary>
        [JsonProperty("maxwind_mph")]
        public float MaximumWindMPH { get; set; }

        /// <summary>
        /// Gets or sets the minimum temperature, in Celcius.
        /// </summary>
        [JsonProperty("mintemp_c")]
        public float MinimumTemperatureC { get; set; }

        /// <summary>
        /// Gets or sets the minimum temperature, in Fahrenheit.
        /// </summary>
        [JsonProperty("mintemp_f")]
        public float MinimumTemperatureF { get; set; }

        /// <summary>
        /// Gets or sets the total precipitation, in inches.
        /// </summary>
        public float TotalPrecipitationIN { get; set; }

        /// <summary>
        /// Gets or sets the total precipitation, in millimeters.
        /// </summary>
        [JsonProperty("totalprecip_mm")]
        public float TotalPrecipitationMM { get; set; }

        /// <summary>
        /// Gets or sets the UV index.
        /// </summary>
        [JsonProperty("uv")]
        public float UV { get; set; }

        /// <summary>
        /// Gets or sets whether it will rain.
        /// </summary>
        [JsonProperty("daily_will_it_rain")]
        public bool WillItRain { get; set; }

        /// <summary>
        /// Gets or sets whether it will snow.
        /// </summary>
        [JsonProperty("daily_will_it_snow")]
        public bool WillItSnow { get; set; }
        #endregion
    }
}
