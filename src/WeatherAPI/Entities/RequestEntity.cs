using WeatherAPI.Entities.Base;

namespace WeatherAPI.Entities
{
    public class RequestEntity : BaseRequestEntity
    {
        public class Builder : BaseRequestEntityBuilder<RequestEntity>
        {
        }
    }
}
