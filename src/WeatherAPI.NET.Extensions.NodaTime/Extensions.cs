using NodaTime;
using System;
using WeatherAPI.NET.Entities;

namespace WeatherAPI.NET.Extensions.NodaTime
{
    public static class Extensions
    {
        #region Public Methods
        /// <summary>
        /// Gets the local time when the real time data was updated as a <see cref="ZonedDateTime" />.
        /// </summary>
        /// <param name="inZoneLeniantly">Whether to use leniant or strict zone conversion.</param>
        public static ZonedDateTime GetZonedLastUpdated(this ForecastResponseEntity forecastResponseEntity, bool inZoneLeniantly = true)
        {
            return GetZonedDateTime(forecastResponseEntity.Current.LastUpdated, forecastResponseEntity.Location.TimeZoneID, inZoneLeniantly);
        }

        /// <summary>
        /// Gets the local time when the real time data was updated as a <see cref="ZonedDateTime" />.
        /// </summary>
        /// <param name="inZoneLeniantly">Whether to use leniant or strict zone conversion.</param>
        public static ZonedDateTime GetZonedLastUpdated(this RealtimeResponseEntity realtimeResponseEntity, bool inZoneLeniantly = true)
        {
            return GetZonedDateTime(realtimeResponseEntity.Current.LastUpdated, realtimeResponseEntity.Location.TimeZoneID, inZoneLeniantly);
        }

        /// <summary>
        /// Gets the local time as a <see cref="ZonedDateTime" />.
        /// </summary>
        /// <param name="inZoneLeniantly">Whether to use leniant or strict zone conversion.</param>
        public static ZonedDateTime GetZonedLocaltime(this LocationEntity locationEntity, bool inZoneLeniantly = true)
        {
            return GetZonedDateTime(locationEntity.LocalTime, locationEntity.TimeZoneID, inZoneLeniantly);
        }

        /// <summary>
        /// Gets the moonrise as a <see cref="ZonedDateTime" />.
        /// </summary>
        /// <param name="inZoneLeniantly">Whether to use leniant or strict zone conversion.</param>
        public static ZonedDateTime GetZonedMoonrise(this AstronomyResponseEntity astronomyResponseEntity, bool inZoneLeniantly = true)
        {
            return GetZonedDateTime(astronomyResponseEntity.Location.LocalTime.Year,
                astronomyResponseEntity.Location.LocalTime.Month,
                astronomyResponseEntity.Location.LocalTime.Day,
                astronomyResponseEntity.Astronomy.Astro.Moonrise.Hour,
                astronomyResponseEntity.Astronomy.Astro.Moonrise.Minute,
                astronomyResponseEntity.Astronomy.Astro.Moonrise.Second,
                astronomyResponseEntity.Location.TimeZoneID,
                inZoneLeniantly);
        }
        #endregion

        #region Private Methods
        private static ZonedDateTime GetZonedDateTime(DateTime dateTime, string timeZoneId, bool inZoneLeniantly)
        {
            return GetZonedDateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, timeZoneId, inZoneLeniantly);
        }

        private static ZonedDateTime GetZonedDateTime(int year, int month, int day, int hour, int minute, int second, string timeZoneId, bool inZoneLeniantly)
        {
            var localDateTime = new LocalDateTime(year, month, day, hour, minute, second);

            if (inZoneLeniantly)
                return localDateTime.InZoneLeniently(DateTimeZoneProviders.Tzdb[timeZoneId]);

            else
                return localDateTime.InZoneStrictly(DateTimeZoneProviders.Tzdb[timeZoneId]);
        }
        #endregion
    }
}
