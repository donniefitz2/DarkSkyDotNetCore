using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkSkyDotNetCore.Console
{
    public class Program
    {
        private const string _apiKey = "";

        public static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(_apiKey))
            {
                System.Console.WriteLine("You must enter your Dark Sky API key. To get a key, go to: https://darksky.net/dev.");
                System.Console.ReadKey();
            }
            else
            {
                var forecaster = new Forecaster();
                var forecastResponse = forecaster.GetCurrentForecast(_apiKey).GetAwaiter().GetResult();

                forecaster.PrintCurrentForecast(forecastResponse);

                System.Console.WriteLine();
                System.Console.WriteLine("Hit any key to see the hourly forecast...");
                System.Console.ReadKey(true);

                forecaster.PrintHourlyForecast(forecastResponse);

                System.Console.WriteLine();
                System.Console.WriteLine("Hit any key to see the daily forecast...");
                System.Console.ReadKey(true);

                forecaster.PrintDailyForecast(forecastResponse);

                System.Console.ReadKey();
            }
        }
    }
}
