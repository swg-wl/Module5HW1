using System.Text.Json.Serialization;

namespace Module5HW1.Models
{
    public class SingleResource
    {
        [JsonPropertyName("data")]
        public User Data { get; set; }

        [JsonPropertyName("support")]
        public Support Support { get; set; }
    }
}
