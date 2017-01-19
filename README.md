# ForecastDotNetCore
This is a client library for accessing the Forecast.IO web API using .Net Core and C#.

This library is based on [the one created by @f0xy](https://github.com/f0xy/forecast.io-csharp) with some changes to support async calls and .Net Core.

#Usage#
Simply download the code (it's not on Nuget yet), reference it and you can call the Foreacast API as outlined below:

```c#
private static async Task<ForecastResponse> CallForecast()
{
  var apiKey = "your-forecast-api-key";

  var request = new ForecastRequest(apiKey, 33.518133f, -111.963043f, Unit.us);
  var response = await request.GetAsync();

  return response;
}
 ```
