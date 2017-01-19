using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ForecastNetCore.Model
{
    public class Alert
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("expires")]
        public Int64 Expires { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
