using System.Text.Json.Serialization;

public class SingleUser
{
    [JsonPropertyName("data")]
    public User Data { get; set; }

    [JsonPropertyName("support")]
    public Support Support { get; set; }
}