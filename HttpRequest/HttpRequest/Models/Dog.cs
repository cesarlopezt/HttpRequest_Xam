using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpRequest.Models
{
    public class Dog
    {
        [JsonProperty("breeds")]
        public List<Breed> Breeds { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
