using System;
using System.Threading.Tasks;
using WeatherAPI;
using WeatherAPI.Entities;

namespace Sample.Forecast
{
    public static class Program
    {
        public static async Task Main()
        {
            // Create a new WeatherAPI API client with API key.
            var weatherApiClient = new WeatherAPIClient(Environment.GetEnvironmentVariable("API_KEY"));

            var request = new ForecastRequestEntity()
                .WithCityName("London")
                .WithAlerts(true)
                .WithDays(5);

            var forecastResponse = await weatherApiClient.Forecast.GetForecastAsync(request).ConfigureAwait(false);

            var stringFormat = "The forecast in {0}, {1} is:";

            Console.WriteLine(string.Format(stringFormat, forecastResponse.Location.Name, forecastResponse.Location.Country));

            foreach (var forecast in forecastResponse.Forecast.ForecastDay)
                Console.WriteLine($"{forecast.Date} - {forecast.Day.Condition.Description}");

            // Keeps the console window open at the end of the program.
            Console.ReadLine();
        }
    }
}
