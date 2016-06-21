using Newtonsoft.Json;

namespace PlexSharp.Models
{
    public class PlexAccount
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "authenticationToken")]
        public string AuthToken { get; set; }
    }
}
