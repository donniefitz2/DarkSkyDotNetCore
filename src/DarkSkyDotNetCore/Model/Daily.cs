using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DarkSkyDotNetCore.Model
{
    public class Daily
    {
        [JsonProperty("summary")]
        public string Summary { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("data")]
        public List<DailyForecast> Data { get; set; }
    }
}
