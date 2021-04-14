using System;
using System.Threading.Tasks;
using WeatherAPI.NET;

namespace Sample.TimeZone
{
    public static class Program
    {
        public static async Task Main()
        {
            // Create a new WeatherAPI API client with API key.
            var weatherApiClient = new WeatherAPIClient(Environment.GetEnvironmentVariable("API_KEY"));

            var timeZone = await weatherApiClient.TimeZones.GetTimeZoneAsync().ConfigureAwait(false);

            var stringFormat = "The local time in {0}, {1} is {2}.";

            Console.WriteLine(string.Format(stringFormat, timeZone.Location.Name, timeZone.Location.Country, timeZone.Location.LocalTime));

            // Keeps the console window open at the end of the program.
            Console.ReadLine();
        }
    }
}
