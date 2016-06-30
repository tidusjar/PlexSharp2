using System.Collections.Generic;

using Newtonsoft.Json;

namespace PlexSharp.Models
{
    public class PlexAuthentication
    {
        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("error")]
        public string Error { get; set; }
    }
    public class Subscription
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("plan")]
        public object Plan { get; set; }
        [JsonProperty("features")]
        public object Features { get; set; }
    }

    public class Roles
    {
        [JsonProperty("roles")]
        public List<object> RolesList { get; set; }
    }

    public class User
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("joined_at")]
        public string JoinedAt { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("authentication_token")]
        public string AuthenticationToken { get; set; }
        [JsonProperty("subscription")]
        public Subscription Subscription { get; set; }
        [JsonProperty("roles")]
        public Roles Roles { get; set; }
        [JsonProperty("entitlements")]
        public List<string> Entitlements { get; set; }
        [JsonProperty("confirmed_at")]
        public object ConfirmedAt { get; set; }
        [JsonProperty("forum_id")]
        public int ForumId { get; set; }
    }
}