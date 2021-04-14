using Newtonsoft.Json;
using System;

namespace WeatherAPI.NET.Entities
{
    public class AlertEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the areas concerned, separated by semicolons (;).
        /// </summary>
        [JsonProperty("areas")]
        public string Areas { get; set; }

        /// <summary>
        /// Gets or sets the alert category.
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the alert certainty.
        /// </summary>
        [JsonProperty("certainty")]
        public string Certainty { get; set; }

        /// <summary>
        /// Gets or sets the alert description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date/time that the alert is effective from.
        /// </summary>
        [JsonProperty("effective")]
        public DateTime Effective { get; set; }

        /// <summary>
        /// Gets or sets the alert event.
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// Gets or sets when the alert expires.
        /// </summary>
        [JsonProperty("expires")]
        public DateTime Expires { get; set; }

        /// <summary>
        /// Gets or sets the alert headline.
        /// </summary>
        [JsonProperty("headline")]
        public string Headline { get; set; }

        /// <summary>
        /// Gets or sets the alert instruction(s).
        /// </summary>
        [JsonProperty("instruction")]
        public string Instruction { get; set; }

        /// <summary>
        /// Gets or sets the type of alert.
        /// </summary>
        [JsonProperty("msgtype")]
        public string MessageType { get; set; }

        /// <summary>
        /// Gets or sets the alert note.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets the alert severity.
        /// </summary>
        [JsonProperty("severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the urgency of the alert.
        /// </summary>
        [JsonProperty("urgency")]
        public string Urgency { get; set; }
        #endregion
    }
}
