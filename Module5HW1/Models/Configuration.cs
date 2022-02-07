using System.Text.Json.Serialization;

namespace Module5HW1.Models
{
    public class Configuration
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
