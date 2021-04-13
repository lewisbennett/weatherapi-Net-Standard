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

            var stringFormat = "The weather in {0}, {1} is {2} degrees C and {3}!";

            Console.WriteLine(string.Format(stringFormat, currentWeather.Location.Name, currentWeather.Location.Country, currentWeather.Current.TemperatureC, currentWeather.Current.Condition.Description));

            var request = new RealtimeRequestEntity()
                .WithAirQualityData(true)
                .WithCityName("London")
                .WithLanguage("fr");

            var londonWeather = await weatherApiClient.Realtime.GetCurrentAsync(request).ConfigureAwait(false);

            Console.WriteLine(string.Format(stringFormat, londonWeather.Location.Name, londonWeather.Location.Country, londonWeather.Current.TemperatureC, londonWeather.Current.Condition.Description));

            // Keeps the console window open at the end of the program.
            Console.ReadLine();
        }
    }
}
