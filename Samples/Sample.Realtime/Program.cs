using System;
using System.Threading.Tasks;
using WeatherAPI;
using WeatherAPI.Entities;

namespace Sample.Realtime
{
    public static class Program
    {
        public static async Task Main()
        {
            // Create a new WeatherAPI API client with API key.
            var weatherApiClient = new WeatherAPIClient(Environment.GetEnvironmentVariable("API_KEY"));

            var currentWeather = await weatherApiClient.Realtime.GetCurrentAsync().ConfigureAwait(false);

            Console.WriteLine($"The weather in {currentWeather.Location.Name}, {currentWeather.Location.Country} is {currentWeather.Current.TemperatureC} degrees C and {currentWeather.Current.Condition.Description}!");

            var request = new RequestEntity.Builder()
                .WithCityName("London")
                .Build();

            var londonWeather = await weatherApiClient.Realtime.GetCurrentAsync(request).ConfigureAwait(false);

            Console.WriteLine($"The weather in {londonWeather.Location.Name}, {londonWeather.Location.Country} is {londonWeather.Current.TemperatureC} degrees C and {londonWeather.Current.Condition.Description}!");

            // Keeps the console window open at the end of the program.
            Console.ReadLine();
        }
    }
}
