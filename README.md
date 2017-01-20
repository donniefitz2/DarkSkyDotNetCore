# DarkSkyDotNetCore
This is a client library for accessing the Dark Sky web API using .Net Core and C#.

This library is based on [the one created by @f0xy](https://github.com/f0xy/forecast.io-csharp) with some changes to support async calls and .Net Core.

#Usage#
Simply download the code (it's not on Nuget yet), reference it and you can call the [Dark Sky API](https://darksky.net/dev/) as outlined below. You must provide your Dark Sky API key with each call and provide latitude and longitude coordinates for forcast location.

```c#
  var apiKey = "your-dark-sky-api-key";

  var request = new ForecastRequest(apiKey, 33.518133f, -111.963043f, Unit.us);
  var response = await request.GetAsync();

 ```
This call will return a ```ForecastResponse``` for the current date and time that contains all of the data that the Dark Sky API offers.

You can optionally filter the data in the request by using the ```Exclude[]``` filters as well as include more options in the request by using the ```Extend[]``` options. The constructor also provides an overload to get the forecast for a specific date. There are also some handy extension methods for dealing with the returned data.

A console application is included that gives an example of using the client and it will run on Windows, macOS and Linux.


