using System;
using System.Threading.Tasks;
using WeatherAPI.NET;

namespace Sample.Sports
{
    public static class Program
    {
        public static async Task Main()
        {
            // Create a new WeatherAPI API client with API key.
            var weatherApiClient = new WeatherAPIClient(Environment.GetEnvironmentVariable("API_KEY"));

            var sports = await weatherApiClient.Sports.GetSportsAsync().ConfigureAwait(false);

            if (sports.Cricket == null || sports.Cricket.Length < 1)
                Console.WriteLine("There aren't currently any cricket events available.");

            else
            {
                Console.WriteLine($"Found {sports.Cricket.Length} cricket events:");

                foreach (var cricket in sports.Cricket)
                    Console.WriteLine($"{cricket.Match}, {cricket.Start}");   
            }

            Console.WriteLine();

            if (sports.Football == null || sports.Football.Length < 1)
                Console.WriteLine("There aren't currently any football events available.");

            else
            {
                Console.WriteLine($"Found {sports.Football.Length} football events:");

                foreach (var football in sports.Football)
                    Console.WriteLine($"{football.Match}, {football.Start}");
            }

            Console.WriteLine();

            if (sports.Golf == null || sports.Golf.Length < 1)
                Console.WriteLine("There aren't currently any golf events available.");

            else
            {
                Console.WriteLine($"Found {sports.Golf.Length} golf events:");

                foreach (var golf in sports.Golf)
                    Console.WriteLine($"{golf.Match}, {golf.Start}");
            }

            // Keeps the console window open at the end of the program.
            Console.ReadLine();
        }
    }
}
