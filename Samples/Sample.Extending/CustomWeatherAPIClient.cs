using WeatherAPI;
using WeatherAPI.Operations.Base;

namespace Sample.Extending
{
    public class CustomWeatherAPIClient : WeatherAPIClient
    {
        protected override IAstronomyOperations ConstructAstronomyOperations()
        {
            // Return our custom operations instead.
            return new CustomAstronomyOperations(this);
        }

        /// <summary>
        /// Creates a new custom WeatherAPI API client.
        /// </summary>
        /// <param name="apiKey">Your WeatherAPI API key.</param>
        public CustomWeatherAPIClient(string apiKey)
            : base(apiKey, null)
        {
        }
    }
}
