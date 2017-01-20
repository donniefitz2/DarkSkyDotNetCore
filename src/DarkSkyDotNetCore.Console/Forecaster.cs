using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DarkSkyDotNetCore;
using DarkSkyDotNetCore.Model;

namespace DarkSkyDotNetCore.Console
{
    internal class Forecaster
    {
        internal async Task<ForecastResponse> GetCurrentForecast(string apiKey, float lat = 33.518133f, float lon = -111.963043f, Unit unit = Unit.us)
        {
            var request = new ForecastRequest(apiKey, lat, lon, unit);

            return await request.GetAsync();
        }

        internal void PrintCurrentForecast(ForecastResponse response)
        {
            System.Console.WriteLine($"Current Forecast For: {response.Latitude} Latitude, {response.Longitude} Longitude:");
            System.Console.WriteLine();
            System.Console.WriteLine("============================Currently========================");
            System.Console.WriteLine($"Current Time: {response.Currently.Time.ToDateTime().ToLocalTime()}");
            System.Console.WriteLine($"{response.Currently.Summary}");
            System.Console.WriteLine($"Feels like: {response.Currently.ApparentTemperature.ToWholeNumber()} degrees");
            System.Console.WriteLine($"Actual Temperature: {response.Currently.Temperature.ToWholeNumber()} degrees");
            System.Console.WriteLine($"Humidity: {response.Currently.Humidity.ToPercentString()}");
            System.Console.WriteLine($"Pressure: {response.Currently.Pressure}");

            if (response.Alerts != null && response.Alerts.Count > 0)
            {
                System.Console.WriteLine("============================Alerts===========================");
                foreach (var alert in response.Alerts)
                {
                    System.Console.WriteLine(alert.Title);
                }
            }
        }

        internal void PrintHourlyForecast(ForecastResponse response)
        {
            System.Console.WriteLine("=============================Hourly==========================");
            System.Console.WriteLine();
            
            for(int i=0; i < 11; i++)
            {
                System.Console.WriteLine($"{response.Hourly.Data[i].Time.ToDateTime().ToLocalTime().ToString("hh:mm tt")} - {response.Hourly.Data[i].Summary} and {response.Hourly.Data[i].Temperature.ToWholeNumber()} degrees");
            }
        }

        internal void PrintDailyForecast(ForecastResponse response)
        {
            System.Console.WriteLine("=============================Daily==========================");
            System.Console.WriteLine();

            foreach(var day in response.Daily.Data)
            {
                System.Console.WriteLine($"{day.Time.ToDateTime().ToLocalTime().ToString("dddd")} - {day.Summary} A high of {day.TemperatureMax.ToWholeNumber()} degrees and a low of {day.TemperatureMin.ToWholeNumber()} degrees");
            }
        }
    }
}
