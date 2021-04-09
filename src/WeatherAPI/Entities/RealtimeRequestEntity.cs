using WeatherAPI.Entities.Base;

namespace WeatherAPI.Entities
{
    public class RealtimeRequestEntity : BaseRequestEntity
    {
        public class Builder : BaseRequestEntityBuilder<RealtimeRequestEntity>
        {
            #region Properties
            /// <summary>
            /// Gets whether the request should include air quality data.
            /// </summary>
            public bool GetAirQualityData { get; internal set; }
            #endregion

            #region Internal Methods
            /// <summary>
            /// Configures the request.
            /// </summary>
            /// <param name="request">The request.</param>
            internal override void ConfigureRequest(RealtimeRequestEntity request)
            {
                base.ConfigureRequest(request);

                if (GetAirQualityData)
                    request.AddParameter("aqi=yes");
            }
            #endregion
        }
    }
}
