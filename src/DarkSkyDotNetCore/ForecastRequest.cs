using DarkSkyDotNetCore.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DarkSkyDotNetCore
{
    public class ForecastRequest
    {
        private readonly string _apiKey;
        private readonly string _latitude;
        private readonly string _longitude;
        private readonly string _unit;
        private readonly string _exclude;
        private readonly string _extend;
        private readonly string _time;
        private string _apiCallsMade;
        private string _apiResponseTime;

        private const string CurrentForecastUrl = "https://api.darksky.net/forecast/{0}/{1},{2}?units={3}&extend={4}&exclude={5}";
        private const string PeriodForecastUrl = "https://api.darksky.net/forecast/{0}/{1},{2},{3}?units={4}&extend={5}&exclude={6}";

        public ForecastRequest(string apiKey, float latF, float longF, Unit unit, Extend[] extend = null, Exclude[] exclude = null)
        {
            _apiKey = apiKey;
            _latitude = latF.ToString(CultureInfo.InvariantCulture);
            _longitude = longF.ToString(CultureInfo.InvariantCulture);
            _unit = Enum.GetName(typeof(Unit), unit);
            _extend = (extend != null) ? RequestFormatter.FormatExtendString(extend) : "";
            _exclude = (exclude != null) ? RequestFormatter.FormatExcludeString(exclude) : "";
        }

        public ForecastRequest(string apiKey, float latF, float longF, DateTime time, Unit unit, Extend[] extend = null, Exclude[] exclude = null)
        {
            _apiKey = apiKey;
            _latitude = latF.ToString(CultureInfo.InvariantCulture);
            _longitude = longF.ToString(CultureInfo.InvariantCulture);
            _time = time.ToUTCString();
            _unit = Enum.GetName(typeof(Unit), unit);
            _extend = (extend != null) ? RequestFormatter.FormatExtendString(extend) : "";
            _exclude = (exclude != null) ? RequestFormatter.FormatExcludeString(exclude) : "";
        }

        public async Task<ForecastResponse> GetAsync()
        {
            var url = (_time == null) ? String.Format(CurrentForecastUrl, _apiKey, _latitude, _longitude, _unit, _extend, _exclude) :
                String.Format(PeriodForecastUrl, _apiKey, _latitude, _longitude, _time, _unit, _extend, _exclude);

            HttpResponseMessage response;
            string forecast;
            ForecastResponse forecastIOData = new ForecastResponse();

            HttpClientHandler handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            };

            var client = new HttpClient(handler);

            response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                forecast = await response.Content.ReadAsStringAsync();
                string formattedForecast = RequestFormatter.FormatResponse(forecast);

                _apiResponseTime = response.Headers.GetValues("X-Response-Time").FirstOrDefault();
                _apiCallsMade = response.Headers.GetValues("X-Forecast-API-Calls").FirstOrDefault();

                await Task.Factory.StartNew(() =>
                {

                    forecastIOData = JsonConvert.DeserializeObject<ForecastResponse>(formattedForecast);
                    //set the unit the call was made with so we can format strings for imperial vs metric
                    forecastIOData.Unit = _unit;
                });
            }
            else
            {
                forecastIOData.Error = response.StatusCode.ToString();
            }

            return forecastIOData;
        }
    }
}
