using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ForecastNetCore.Model
{
    public class MinuteForecast
    {
        [JsonProperty("time")]
        public Int64 Time { get; set; }
        [JsonProperty("precipIntensity")]
        public float PrecipIntensity { get; set; }
    }
}
