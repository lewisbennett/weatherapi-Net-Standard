using Newtonsoft.Json;
using System;

namespace WeatherAPI.Entities
{
    public class CurrentEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the amount of cloud coverage, as a percentage (0-100%).
        /// </summary>
        [JsonProperty("cloud")]
        public int CloudCover { get; set; }

        /// <summary>
        /// Gets or sets the weather condition information.
        /// </summary>
        [JsonProperty("condition")]
        public ConditionEntity Condition { get; set; }

        /// <summary>
        /// Gets or sets the "feels like" temperature, in Celcius.
        /// </summary>
        [JsonProperty("feelslike_c")]
        public float FeelsLikeC { get; set; }

        /// <summary>
        /// Gets or sets the "feels like" temperature, in Fahrenheit.
        /// </summary>
        [JsonProperty("feelslike_f")]
        public float FeelsLikeF { get; set; }

        /// <summary>
        /// Gets or sets the wind gust, in kilometers per hour.
        /// </summary>
        [JsonProperty("gust_kph")]
        public float GustKPH { get; set; }

        /// <summary>
        /// Gets or sets the wind gust, in miles per hour.
        /// </summary>
        [JsonProperty("gust_mph")]
        public float GustMPH { get; set; }

        /// <summary>
        /// Gets or sets the humidity, as a percentage (0-100%).
        /// </summary>
        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        /// <summary>
        /// Gets or sets whether it is daytime or nighttime.
        /// </summary>
        [JsonProperty("is_day")]
        public bool IsDay { get; set; }

        /// <summary>
        /// Gets or sets the local time when the real time data was updated.
        /// </summary>
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }
        
        /// <summary>
        /// Gets or sets the local time when the real time data was updated, in unix time.
        /// </summary>
        [JsonProperty("last_updated_epoch")]
        public long LastUpdatedEpoch { get; set; }

        /// <summary>
        /// Gets or sets the amount of precipitation, in inches.
        /// </summary>
        [JsonProperty("precip_in")]
        public float PrecipitationIN { get; set; }

        /// <summary>
        /// Gets or sets the amount of precipitation, in millimeters.
        /// </summary>
        [JsonProperty("precip_mm")]
        public float PrecipitationMM { get; set; }

        /// <summary>
        /// Gets or sets the pressure, in inches.
        /// </summary>
        [JsonProperty("pressure_in")]
        public float PressureIN { get; set; }

        /// <summary>
        /// Gets or sets the pressure, in millibars.
        /// </summary>
        [JsonProperty("pressure_mb")]
        public float PressureMB { get; set; }

        /// <summary>
        /// Gets or sets the temperature, in Celcius.
        /// </summary>
        [JsonProperty("temp_c")]
        public float TemperatureC { get; set; }

        /// <summary>
        /// Gets or sets the temperature, in Fahrenheit.
        /// </summary>
        [JsonProperty("temp_f")]
        public float TemperatureF { get; set; }

        /// <summary>
        /// Gets or sets the UV index.
        /// </summary>
        [JsonProperty("uv")]
        public float UV { get; set; }

        /// <summary>
        /// Gets or sets the wind direction, as interpreted on a 16 point compass (for example: NNW = north north west).
        /// </summary>
        [JsonProperty("wind_dir")]
        public string WindDirectionC { get; set; }

        /// <summary>
        /// Gets or sets the wind direction, in degrees.
        /// </summary>
        [JsonProperty("wind_degree")]
        public float WindDirectionD { get; set; }

        /// <summary>
        /// Gets or sets the wind speed, in kilometers per hour.
        /// </summary>
        [JsonProperty("wind_kph")]
        public float WindKPH { get; set; }

        /// <summary>
        /// Gets or sets the wind speed, in miles per hour.
        /// </summary>
        [JsonProperty("wind_mph")]
        public float WindMPH { get; set; }
        #endregion
    }
}
