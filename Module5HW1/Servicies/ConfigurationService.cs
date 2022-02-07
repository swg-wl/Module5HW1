using System.Text.Json;
using System.Text.Json.Serialization;
using Module5HW1.Models;

namespace Module5HW1.Servicies
{
    public class ConfigurationService
    {
        public Configuration Load()
        {
            var result = JsonSerializer.Deserialize<Configuration>("Configuration.json");
            return result;
        }
    }
}
