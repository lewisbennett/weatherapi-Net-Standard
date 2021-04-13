using System;
using System.Collections.Generic;
using WeatherAPI.Entities.Base;

namespace WeatherAPI.Entities
{
    public class HistoryRequestEntity : BaseRequestEntity
    {
        #region Properties
        /// <summary>
        /// Gets the date to get history for.
        /// </summary>
        public DateTime? Date { get; internal set; }

        /// <summary>
        /// Gets the final date to get history for.
        /// </summary>
        public DateTime? EndDate { get; internal set; }

        /// <summary>
        /// Gets the hour to get the History for, if any.
        /// </summary>
        public int? Hour { get; internal set; }
        #endregion

        #region Public Methods
        /// <summary>
        /// Configures the request to get history for a specific date, after January 1st 2015 (01/01/2015).
        /// 
        /// Also serves as the initial date if configuring an end date for the request.
        /// </summary>
        /// <param name="date">The date to get the historic weather data for.</param>
        public HistoryRequestEntity WithDate(DateTime? date)
        {
            Date = date;

            return this;
        }

        /// <summary>
        /// Configures the request to get the history up to a specific date.
        /// 
        /// Requires date to also be configured.
        /// 
        /// The two dates must be within 30 days of each other, and the end date greater than the initial date.
        /// </summary>
        /// <param name="endDate">The future date to get the History up until.</param>
        public HistoryRequestEntity WithEndDate(DateTime? endDate)
        {
            EndDate = endDate;

            return this;
        }

        /// <summary>
        /// Configures the request to get the History for a specific hour.
        /// </summary>
        /// <param name="hour">The hour to get the History for.</param>
        public HistoryRequestEntity WithHour(int? hour)
        {
            Hour = hour;

            return this;
        }

        /// <summary>
        /// Configures the request to get the history for a specific date, in unix time, after January 1st 2015 (01/01/2015).
        /// 
        /// Also serves as the initial date if configuring an end date for the request.
        /// </summary>
        /// <param name="unixDate">The date to get the historic weather data for, in unix time.</param>
        public HistoryRequestEntity WithUnixDate(long? unixDate)
        {
            return unixDate.HasValue ? WithDate(new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(unixDate.Value)) : this;
        }

        /// <summary>
        /// Configures the request to get the history up to a specific date, in unix time.
        /// 
        /// Requires date to also be configured.
        /// 
        /// The two dates must be within 30 days of each other, and the end date greater than the initial date.
        /// </summary>
        /// <param name="unixEndDate">The future date to get the History up until, in unix time.</param>
        public HistoryRequestEntity WithUnixEndDate(long? unixEndDate)
        {
            return unixEndDate.HasValue ? WithEndDate(new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(unixEndDate.Value)) : this;
        }
        #endregion

        #region Protected Methods
        protected override void AddQueryParameters(List<string> queryParameters)
        {
            base.AddQueryParameters(queryParameters);

            if (Date.HasValue)
                queryParameters.Add($"dt={Date.Value:yyyy-MM-dd}");

            if (EndDate.HasValue)
                queryParameters.Add($"end_dt={EndDate.Value:yyyy-MM-dd}");

            if (Hour.HasValue)
                queryParameters.Add($"hour={Hour.Value}");
        }

        protected override void ValidateConfiguration()
        {
            base.ValidateConfiguration();

            // The weather API only provides historical data for dates after January 1st 2015, so check that both dates are greater.

            var queryDateTime = new DateTime(2015, 1, 1);

            if (Date.HasValue && Date.Value.Date < queryDateTime)
                throw new ArgumentOutOfRangeException("History date must be greater than January 1st 2015 (01/01/2015).");

            if (EndDate.HasValue)
            {
                if (EndDate.Value.Date < queryDateTime)
                    throw new ArgumentOutOfRangeException("History end date must be greater than January 1st 2015 (01/01/2015).");

                // If the initial date has been configured, check that end date is greater, and within 30 days.
                if (Date.HasValue)
                {
                    if (EndDate.Value.Date < Date.Value.Date)
                        throw new InvalidOperationException("History end date must be greater than initial date.");

                    else if (EndDate.Value.Date.Subtract(Date.Value.Date).Days > 30)
                        throw new ArgumentOutOfRangeException("History dates must be within 30 days of each other.");
                }
                // Otherwise, throw.
                else
                    throw new InvalidOperationException("History end date has been configured without an initial date.");
            }

            if (Hour.HasValue && (Hour.Value < 0 || Hour.Value > 23))
                throw new IndexOutOfRangeException("History hour value must be between 0 and 23.");
        }
        #endregion
    }
}
