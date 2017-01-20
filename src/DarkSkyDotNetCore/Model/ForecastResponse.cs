using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace DarkSkyDotNetCore.Model
{
    public class ForecastResponse
    {
        public string Unit { get; set; }
        [JsonProperty("latitude")]
        public float Latitude { get; set; }
        [JsonProperty("longitude")]
        public float Longitude { get; set; }
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("offset")]
        public float Offset { get; set; }
        [JsonProperty("currently")]
        public Currently Currently { get; set; }
        [JsonProperty("minutely")]
        public Minutely Minutely { get; set; }
        [JsonProperty("hourly")]
        public Hourly Hourly { get; set; }
        [JsonProperty("daily")]
        public Daily Daily { get; set; }
        [JsonProperty("alerts")]
        public List<Alert> Alerts { get; set; }
        [JsonProperty("flags")]
        public Flags Flags { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
