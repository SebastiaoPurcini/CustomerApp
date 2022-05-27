using System.Text.Json.Serialization;

namespace CustomerApp.Core.Models
{
    public class City
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("nome")]
        public string Name { get; set; }
    }
}
