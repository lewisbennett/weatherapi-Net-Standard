using System;
using System.Threading.Tasks;
using WeatherAPI.NET;

namespace Sample.Search
{
    public static class Program
    {
        public const string SearchQuery = "lon";

        public static async Task Main()
        {
            // Create a new WeatherAPI API client with API key.
            var weatherApiClient = new WeatherAPIClient(Environment.GetEnvironmentVariable("API_KEY"));

            var searchResults = await weatherApiClient.Search.SearchAsync(SearchQuery).ConfigureAwait(false);

            if (searchResults != null && searchResults.Length > 0)
            {
                Console.WriteLine($"Search found {searchResults.Length} results for \"{SearchQuery}\":");

                foreach (var result in searchResults)
                    Console.WriteLine(result.Name);
            }
            else
                Console.WriteLine($"Search was not able to find any results for \"{SearchQuery}\".");

            // Keeps the console window open at the end of the program.
            Console.ReadLine();
        }
    }
}
