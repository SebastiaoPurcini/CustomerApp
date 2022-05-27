using System.Text.Json.Serialization;

namespace CustomerApp.Core.Models
{
    public class State
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Name { get; set; }

        [JsonPropertyName("sigla")]
        public string Initial { get; set; }
    }
}
