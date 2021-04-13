using WeatherAPI.Entities.Base;

namespace WeatherAPI.Entities
{
    public class ForecastRequestEntity : BaseRequestEntity
    {
        public class Builder : RealtimeRequestEntity.Builder
        {
        }
    }
}
