using System;
using System.Threading.Tasks;
using WeatherAPI;

namespace Sample.Forecast
{
    public static class Program
    {
        public static async Task Main()
        {
            // Create a new WeatherAPI API client with API key.
            var weatherApiClient = new WeatherAPIClient(Environment.GetEnvironmentVariable("API_KEY"));

            var forecastResponse = await weatherApiClient.Forecast.GetForecastAsync().ConfigureAwait(false);

            var stringFormat = "The forecast in {0}, {1} is:";

            Console.WriteLine(string.Format(stringFormat, forecastResponse.Location.Name, forecastResponse.Location.Country));

            foreach (var forecast in forecastResponse.Forecast.ForecastDay)
                Console.WriteLine($"{forecast.Date} - {forecast.Day.Condition.Description}");

            // Keeps the console window open at the end of the program.
            Console.ReadLine();
        }
    }
}
