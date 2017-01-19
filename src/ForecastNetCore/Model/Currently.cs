using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForecastNetCore.Model
{
    public class Currently
    {
        [JsonProperty("time")]
        public Int64 Time { get; set; }
        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("precipIntensity")]
        public float PrecipIntensity { get; set; }
        [JsonProperty("precipProbability")]
        public float PrecipProbability { get; set; }
        [JsonProperty("temperature")]
        public float Temperature { get; set; }
        [JsonProperty("ApparentTemperature")]
        public float ApparentTemperature { get; set; }
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
        [JsonProperty("nearestStormDistance")]
        public int NearestStormDistance { get; set; }
        [JsonProperty("nearestStormBearing")]
        public int NearestStormBearing { get; set; }
    }
}
