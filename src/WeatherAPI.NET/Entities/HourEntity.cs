using Newtonsoft.Json;
using System;

namespace WeatherAPI.NET.Entities
{
    public class HourEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the chance of rain, as a percentage (0-100%).
        /// </summary>
        [JsonProperty("chance_of_rain")]
        public int ChanceOfRain { get; set; }

        /// <summary>
        /// Gets or sets the chance of snow, as a percentage (0-100%).
        /// </summary>
        [JsonProperty("chance_of_snow")]
        public int ChanceOfSnow { get; set; }

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
        /// Gets or sets the dew point, in Celcius.
        /// </summary>
        [JsonProperty("dewpoint_c")]
        public float DewPointC { get; set; }

        /// <summary>
        /// Gets or sets the dew point, in Fahrenheit.
        /// </summary>
        [JsonProperty("dewpoint_f")]
        public float DewPointF { get; set; }

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
        /// Gets or sets the heat index, in Celcius.
        /// </summary>
        [JsonProperty("heatindex_c")]
        public float HeadIndexC { get; set; }

        /// <summary>
        /// Gets or sets the heat index, in Fahrenheit.
        /// </summary>
        [JsonProperty("heatindex_f")]
        public float HeadIndexF { get; set; }

        /// <summary>
        /// Gets or sets the humidity, as a percentage (0-100%).
        /// </summary>
        [JsonProperty("humidity")]
        public float Humidity { get; set; }

        /// <summary>
        /// Gets or sets whether it is daytime or nighttime.
        /// </summary>
        [JsonProperty("is_day")]
        public bool IsDay { get; set; }

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
        /// Gets or sets the time.
        /// </summary>
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets the time, in unix time.
        /// </summary>
        [JsonProperty("time_epoch")]
        public long TimeEpoch { get; set; }

        /// <summary>
        /// Gets or sets the UV index.
        /// </summary>
        [JsonProperty("uv")]
        public float UV { get; set; }

        /// <summary>
        /// gets or sets the visibility, in kilometers.
        /// </summary>
        [JsonProperty("vis_km")]
        public float VisibilityKm { get; set; }

        /// <summary>
        /// Gets or sets the visibility, in miles.
        /// </summary>
        [JsonProperty("vis_miles")]
        public float VisibilityMi { get; set; }

        /// <summary>
        /// Gets or sets whether it will rain.
        /// </summary>
        [JsonProperty("will_it_rain")]
        public bool WillItRain { get; set; }

        /// <summary>
        /// Gets or sets whether it will snow.
        /// </summary>
        [JsonProperty("will_it_snow")]
        public bool WillItSnow { get; set; }

        /// <summary>
        /// Gets or sets the wind chill temperature, in Celcius.
        /// </summary>
        [JsonProperty("windchill_c")]
        public float WindChillC { get; set; }

        /// <summary>
        /// Gets or sets the wind chill temperature, in Fahrenheit.
        /// </summary>
        [JsonProperty("windchill_f")]
        public float WindChillF { get; set; }

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
