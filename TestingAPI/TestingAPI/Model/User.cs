using Newtonsoft.Json;

namespace TestingAPI
{
    public class User
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
