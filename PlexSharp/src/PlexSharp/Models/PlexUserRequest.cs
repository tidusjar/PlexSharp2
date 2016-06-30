
using Newtonsoft.Json;

using RestSharp.Deserializers;

namespace PlexSharp.Models
{
    public class PlexUserRequest
    {
        [DeserializeAs(Name= "user")]
        public UserRequest User { get; set; }
    }

    public class UserRequest
    {
        [DeserializeAs(Name = "login")]
        public string Login { get; set; }
        [DeserializeAs(Name = "password")]
        public string Password { get; set; }
    }
}