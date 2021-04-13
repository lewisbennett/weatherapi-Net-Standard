using System;
using System.Threading.Tasks;
using WeatherAPI;

namespace Sample.Astronomy
{
    public static class Program
    {
        public static async Task Main()
        {
            // Create a new WeatherAPI API client with API key.
            var weatherApiClient = new WeatherAPIClient(Environment.GetEnvironmentVariable("API_KEY"));

            var request = RequestEntity.CreateFromCityName("London");

            var astronomyResponse = await weatherApiClient.Astronomy.GetAstronomyAsync(request).ConfigureAwait(false);

            var stringFormat = "Sunrise in {0}, {1} is {2}, and the moon phase is {3}.";

            Console.WriteLine(string.Format(stringFormat, astronomyResponse.Location.Name, astronomyResponse.Location.Country, astronomyResponse.Astronomy.Astro.Sunrise, astronomyResponse.Astronomy.Astro.MoonPhase));

            // Keeps the console window open at the end of the program.
            Console.ReadLine();
        }
    }
}
