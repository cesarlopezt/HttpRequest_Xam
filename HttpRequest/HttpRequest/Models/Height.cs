using Newtonsoft.Json;

namespace HttpRequest.Models
{
    public class Height
    {
        [JsonProperty("imperial")]
        public string Imperial { get; set; }

        [JsonProperty("metric")]
        public string Metric { get; set; }
    }
}
