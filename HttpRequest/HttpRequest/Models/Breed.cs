using Newtonsoft.Json;

namespace HttpRequest.Models
{
    public class Breed
    {
        [JsonProperty("weight")]
        public Weight Weight { get; set; }

        [JsonProperty("height")]
        public Height Height { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bred_for")]
        public string BredFor { get; set; }

        [JsonProperty("breed_group")]
        public string BreedGroup { get; set; }

        [JsonProperty("life_span")]
        public string LifeSpan { get; set; }

        [JsonProperty("temperament")]
        public string Temperament { get; set; }

        [JsonProperty("reference_image_id")]
        public string ReferenceImageId { get; set; }
    }
}
