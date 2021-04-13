using Newtonsoft.Json;
using System;

namespace WeatherAPI.Entities
{
    public class IPLookupEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the city for where the IP address is located.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the continent for where the IP address is located.
        /// </summary>
        [JsonProperty("continent_name")]
        public string Continent { get; set; }

        /// <summary>
        /// Gets or sets the contintent code for where the IP address is located.
        /// </summary>
        [JsonProperty("continent_code")]
        public string ContinentCode { get; set; }

        /// <summary>
        /// Gets or sets the country for where the IP address is located.
        /// </summary>
        [JsonProperty("country_name")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the country code for where the IP address is located.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the geoname ID for where the IP address is located.
        /// </summary>
        [JsonProperty("geoname_id")]
        public long GeonameID { get; set; }

        /// <summary>
        /// Gets or sets the looked up IP address.
        /// </summary>
        [JsonProperty("ip")]
        public string IPAddress { get; set; }

        /// <summary>
        /// Gets or sets whether the IP address is located within Europe.
        /// </summary>
        [JsonProperty("is_eu")]
        public bool IsEU { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [JsonProperty("lat")]
        public float Latitude { get; set; }

        /// <summary>
        /// Gets or sets the local time.
        /// </summary>
        [JsonProperty("localtime")]
        public DateTime LocalTime { get; set; }

        /// <summary>
        /// Gets or sets the local time, in unix time. 
        /// </summary>
        [JsonProperty("localtime_epoch")]
        public long LocalTimeEpoch { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonProperty("lon")]
        public float Longitude { get; set; }

        /// <summary>
        /// Gets or sets the region for where the IP address is located.
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the time zone ID, in TZDB format.
        /// </summary>
        [JsonProperty("tz_id")]
        public string TimeZoneID { get; set; }

        /// <summary>
        /// Gets or sets the IP type ('ipv4' or 'ipv6').
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        #endregion
    }
}
