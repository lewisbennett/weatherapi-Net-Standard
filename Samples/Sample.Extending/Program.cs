using System;
using System.Threading.Tasks;
using WeatherAPI;
using WeatherAPI.Entities;

namespace Sample.Extending
{
    public static class Program
    {
        public static async Task Main()
        {
            // Create a new CustomWeatherAPI API client with API key.
            var customWeatherApiClient = new CustomWeatherAPIClient(Environment.GetEnvironmentVariable("API_KEY"));

            var request = new RequestEntity()
                .WithCityName("London");

            await customWeatherApiClient.Astronomy.GetAstronomyAsync<CustomAstronomyEntity>(request).ConfigureAwait(false);

            // Keeps the console window open at the end of the program.
            Console.ReadLine();
        }
    }
}
