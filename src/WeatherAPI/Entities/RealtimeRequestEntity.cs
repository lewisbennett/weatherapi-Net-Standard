using System.Collections.Generic;
using WeatherAPI.Entities.Base;

namespace WeatherAPI.Entities
{
    public class RealtimeRequestEntity : BaseRequestEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets whether to include air quality data in the response.
        /// </summary>
        public bool IncludeAirQualityData { get; internal set; }
        #endregion

        #region Public Methods
        /// <summary>
        /// Configures the request to include or exclude air quality data.
        /// </summary>
        /// <param name="includeAirQualityData">Whether to include air quality data in the response.</param>
        public RealtimeRequestEntity WithAirQualityData(bool includeAirQualityData)
        {
            IncludeAirQualityData = includeAirQualityData;

            return this;
        }
        #endregion

        #region Protected Methods
        protected override void AddQueryParameters(List<string> queryParameters)
        {
            base.AddQueryParameters(queryParameters);

            if (IncludeAirQualityData)
                queryParameters.Add("aqi=yes");
        }
        #endregion
    }
}
