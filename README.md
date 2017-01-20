# DarkSkyDotNetCore
This is a client library for accessing the Dark Sky web API using .Net Core and C#.

This library is based on [the one created by @f0xy](https://github.com/f0xy/forecast.io-csharp) with some changes to support async calls and .Net Core.

#Usage#
Simply download the code (it's not on Nuget yet), reference it and you can call the Dark Sky API as outlined below. You must provide your Dark Sky API key with each call and provide latitude and longitude coordinates for forcast location.

```c#
  var apiKey = "your-forecast-api-key";

  var request = new ForecastRequest(apiKey, 33.518133f, -111.963043f, Unit.us);
  var response = await request.GetAsync();

  return response;
 ```
This call will return a ```ForecastResponse``` for the current date and time that contains all of the data that the Dark Sky API offers.

You can optionally filter the data returned by using the ```Exclude[]``` filters as well as include more options using the ```Extend[]``` options. The constructor also provides an overload to get the forecast for a specific date.


