
using Newtonsoft.Json;

using RestSharp.Deserializers;

namespace PlexSharp.Models
{
    public class PlexUserRequest
    {
        [JsonProperty("user")]
        public UserRequest User { get; set; }
    }

    public class UserRequest
    {
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}