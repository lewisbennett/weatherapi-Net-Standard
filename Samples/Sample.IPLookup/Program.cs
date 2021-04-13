using System;
using System.Threading.Tasks;
using WeatherAPI;

namespace Sample.IPLookup
{
    public static class Program
    {
        public const string IPAddress = "";

        public static async Task Main()
        {
            // Create a new WeatherAPI API client with API key.
            var weatherApiClient = new WeatherAPIClient(Environment.GetEnvironmentVariable("API_KEY"));

            var ipLookup = await weatherApiClient.IPLookup.LookIPAddressAsync(IPAddress).ConfigureAwait(false);

            var stringFormat = "The IP address is located within {0}, {1}, {2}.";

            Console.WriteLine(string.Format(stringFormat, ipLookup.City, ipLookup.Country, ipLookup.Continent));

            // Keeps the console window open at the end of the program.
            Console.ReadLine();
        }
    }
}
