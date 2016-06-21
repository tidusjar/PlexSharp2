using Newtonsoft.Json;

namespace PlexSharp.Models
{
    public class PlexAccountWrapper
    {
        [JsonProperty(PropertyName = "user")]
        public PlexAccount PlexAccount { get; set; }
    }
}