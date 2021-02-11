using Newtonsoft.Json;

namespace TestingAPI
{
    public class Company
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
