using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ForecastNetCore.Model
{
    public class Minutely
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("data")]
        public List<MinuteForecast> Data { get; set; }
    }
}
