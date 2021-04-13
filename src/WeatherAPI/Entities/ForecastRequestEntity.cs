using System;
using System.Collections.Generic;
using WeatherAPI.Entities.Base;

namespace WeatherAPI.Entities
{
    public class ForecastRequestEntity : BaseRequestEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the number of days to get the forecast for.
        /// </summary>
        public int? Days { get; internal set; }

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
        public ForecastRequestEntity WithAirQualityData(bool includeAirQualityData)
        {
            IncludeAirQualityData = includeAirQualityData;

            return this;
        }

        /// <summary>
        /// Configures the request to get the forecast up to a specific date. Maximum of 10 days in the future.
        /// </summary>
        /// <param name="dateTime">The future date to get the forecast up until.</param>
        public ForecastRequestEntity WithDate(DateTime? dateTime)
        {
            return WithDays(dateTime?.Date.Subtract(DateTime.Today).Days);
        }

        /// <summary>
        /// Configures the request to get the forecast for a specific number of days. Minimum 1, maximum 10.
        /// </summary>
        /// <param name="days">The number of days to get the forecast for, or null.</param>
        public ForecastRequestEntity WithDays(int? days)
        {
            Days = days;

            return this;
        }

        /// <summary>
        /// Configures the request to get the forecast up to a specific date, in unix time. Maximum of 10 days in the future.
        /// </summary>
        /// <param name="dateTime">The future date to get the forecast up until.</param>
        public ForecastRequestEntity WithUnixDate(long? unixDate)
        {
            return unixDate.HasValue ? WithDate(new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(unixDate.Value)) : this;
        }
        #endregion

        #region Protected Methods
        protected override void AddQueryParameters(List<string> queryParameters)
        {
            base.AddQueryParameters(queryParameters);

            if (IncludeAirQualityData)
                queryParameters.Add("aqi=yes");

            if (Days.HasValue)
                queryParameters.Add($"days={Days.Value}");
        }

        protected override void ValidateConfiguration()
        {
            base.ValidateConfiguration();

            if (Days.HasValue && (Days.Value < 1 || Days.Value > 10))
                throw new IndexOutOfRangeException("Forecast must be between 1 and 10 days in the future.");
        }
        #endregion
    }
}
