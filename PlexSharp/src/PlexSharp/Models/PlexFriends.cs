#region Copyright statement
// --------------------------------------------------------------
// Copyright (C) 1999-2015 Exclaimer Ltd. All Rights Reserved.
// No part of this source file may be copied and/or distributed 
// without the express permission of a director of Exclaimer Ltd
// ---------------------------------------------------------------
#endregion
using Newtonsoft.Json;

namespace PlexSharp.Models
{
    public class PlexFriendsWrapper
    {
        [JsonProperty("MediaContainer")]
        public PlexFriends PlexFriends { get; set; }
    }

    public class Server
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("serverId")]
        public string ServerId { get; set; }
        [JsonProperty("machineIdentifier")]
        public string MachineIdentifier { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("lastSeenAt")]
        public string LastSeenAt { get; set; }
        [JsonProperty("numLibraries")]
        public string NumLibraries { get; set; }
        [JsonProperty("owned")]
        public string Owned { get; set; }
    }


    public class UserFriends
    {
        [JsonProperty("Server")]
        public Server Server { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("recommendationsPlaylistId")]
        public string RecommendationsPlaylistId { get; set; }
        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }


    public class PlexFriends
    {
        [JsonProperty("User")]
        public UserFriends[] User { get; set; }
        [JsonProperty("friendlyName")]
        public string FriendlyName { get; set; }
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
        [JsonProperty("machineIdentifier")]
        public string MachineIdentifier { get; set; }
        [JsonProperty("totalSize")]
        public string TotalSize { get; set; }
        [JsonProperty("size")]
        public string Size { get; set; }
    }

}