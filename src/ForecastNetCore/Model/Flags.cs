using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ForecastNetCore.Model
{
    public class Flags
    {
        [JsonProperty("sources")]
        public List<string> Sources { get; set; }
        [JsonProperty("isd_stations")]
        public List<string> ISDStations { get; set; }
        [JsonProperty("lamp_stations")]
        public List<string> LampStations { get; set; }
        [JsonProperty("metar_stations")]
        public List<string> MetarStations { get; set; }
        [JsonProperty("darksky_stations")]
        public List<string> DarkskyStations { get; set; }
        [JsonProperty("units")]
        public string Units { get; set; }
    }
}
