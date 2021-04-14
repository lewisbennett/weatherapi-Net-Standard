using System;
using System.Threading.Tasks;
using WeatherAPI.NET;
using WeatherAPI.NET.Entities;

namespace Sample.History
{
    public static class Program
    {
        public static async Task Main()
        {
            // Create a new WeatherAPI API client with API key.
            var weatherApiClient = new WeatherAPIClient(Environment.GetEnvironmentVariable("API_KEY"));

            var request = new HistoryRequestEntity()
                .WithDate(DateTime.Now.AddDays(-5));

            var history = await weatherApiClient.History.GetHistoryAsync(request).ConfigureAwait(false);

            var stringFormat = "The forecast in {0}, {1} was:";

            Console.WriteLine(string.Format(stringFormat, history.Location.Name, history.Location.Country));

            foreach (var forecast in history.Forecast.ForecastDay)
                Console.WriteLine($"{forecast.Date} - {forecast.Day.Condition.Description}");

            // Keeps the console window open at the end of the program.
            Console.ReadLine();
        }
    }
}
