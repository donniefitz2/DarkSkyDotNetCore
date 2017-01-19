using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ForecastNetCore.Model
{
    public class DailyForecast
    {
        [JsonProperty("time")]
        public Int64 Time { get; set; }
        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("sunriseTime")]
        public Int64 SunriseTime { get; set; }
        [JsonProperty("sunsetTime")]
        public Int64 SunsetTime { get; set; }
        [JsonProperty("precipIntensity")]
        public float PrecipIntensity { get; set; }
        [JsonProperty("precipIntensityMax")]
        public float PrecipIntensityMax { get; set; }
        [JsonProperty("precipProbability")]
        public float PrecipProbability { get; set; }
        [JsonProperty("temperatureMin")]
        public float TemperatureMin { get; set; }
        [JsonProperty("temperatureMinTime")]
        public Int64 TemperatureMinTime { get; set; }
        [JsonProperty("temperatureMax")]
        public float TemperatureMax { get; set; }
        [JsonProperty("temperatureMaxTime")]
        public Int64 TemperatureMaxTime { get; set; }
        [JsonProperty("apparentTemperatureMin")]
        public float ApparentTemperatureMin { get; set; }
        [JsonProperty("apparentTemperatureMinTime")]
        public Int64 ApparentTemperatureMinTime { get; set; }
        [JsonProperty("apparentTemperatureMax")]
        public float ApparentTemperatureMax { get; set; }
        [JsonProperty("apparentTemperatureMaxTime")]
        public Int64 ApparentTemperatureMaxTime { get; set; }
        [JsonProperty("dewPoint")]
        public float DewPoint { get; set; }
        [JsonProperty("windSpeed")]
        public float WindSpeed { get; set; }
        [JsonProperty("windBearing")]
        public float WindBearing { get; set; }
        [JsonProperty("cloudCover")]
        public float CloudCover { get; set; }
        [JsonProperty("humidity")]
        public float Humidity { get; set; }
        [JsonProperty("pressure")]
        public float Pressure { get; set; }
        [JsonProperty("visibility")]
        public float Visibility { get; set; }
        [JsonProperty("ozone")]
        public float Ozone { get; set; }
        [JsonProperty("moonPhase")]
        public float MoonPhase { get; set; }
    }
}
