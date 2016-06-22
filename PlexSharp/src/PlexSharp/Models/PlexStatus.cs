using System.Collections.Generic;

using Newtonsoft.Json;

namespace PlexSharp.Models
{
    public class PlexStatusWrapper
    {
        [JsonProperty("MediaContainer")]
        public PlexStatus PlexStatus { get; set; }
    }

    public class Directory
    {
        [JsonProperty(PropertyName = "count")]
        public string Count { get; set; }
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string type { get; set; }
    }
    
    public class PlexStatus
    {
        [JsonProperty(PropertyName = "Directory")]
        public List<Directory> Directory { get; set; }
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }
        [JsonProperty(PropertyName = "allowCameraUpload")]
        public string AllowCameraUpload { get; set; }
        [JsonProperty(PropertyName = "allowChannelAccess")]
        public string AllowChannelAccess { get; set; }
        [JsonProperty(PropertyName = "allowMediaDeletion")]
        public string AllowMediaDeletion { get; set; }
        [JsonProperty(PropertyName = "allowSync")]
        public string AllowSync { get; set; }
        [JsonProperty(PropertyName = "backgroundProcessing")]
        public string BackgroundProcessing { get; set; }
        [JsonProperty(PropertyName = "certificate")]
        public string Certificate { get; set; }
        [JsonProperty(PropertyName = "companionProxy")]
        public string CompanionProxy { get; set; }
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }
        [JsonProperty(PropertyName = "machineIdentifier")]
        public string MachineIdentifier { get; set; }
        [JsonProperty(PropertyName = "multiuser")]
        public string Multiuser { get; set; }
        [JsonProperty(PropertyName = "myPlex")]
        public string MyPlex { get; set; }
        [JsonProperty(PropertyName = "myPlexMappingState")]
        public string MyPlexMappingState { get; set; }
        [JsonProperty(PropertyName = "myPlexSigninState")]
        public string MyPlexSigninState { get; set; }
        [JsonProperty(PropertyName = "myPlexSubscription")]
        public string MyPlexSubscription { get; set; }
        [JsonProperty(PropertyName = "myPlexUsername")]
        public string MyPlexUsername { get; set; }
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }
        [JsonProperty(PropertyName = "platformVersion")]
        public string PlatformVersion { get; set; }
        [JsonProperty(PropertyName = "requestParametersInCookie")]
        public string RequestParametersInCookie { get; set; }
        [JsonProperty(PropertyName = "sync")]
        public string Sync { get; set; }
        [JsonProperty(PropertyName = "transcoderActiveVideoSessions")]
        public string TranscoderActiveVideoSessions { get; set; }
        [JsonProperty(PropertyName = "transcoderAudio")]
        public string TranscoderAudio { get; set; }
        [JsonProperty(PropertyName = "transcoderLyrics")]
        public string TranscoderLyrics { get; set; }
        [JsonProperty(PropertyName = "transcoderPhoto")]
        public string TranscoderPhoto { get; set; }
        [JsonProperty(PropertyName = "transcoderSubtitles")]
        public string TranscoderSubtitles { get; set; }
        [JsonProperty(PropertyName = "transcoderVideo")]
        public string TranscoderVideo { get; set; }
        [JsonProperty(PropertyName = "transcoderVideoBitrates")]
        public string TranscoderVideoBitrates { get; set; }
        [JsonProperty(PropertyName = "transcoderVideoQualities")]
        public string TranscoderVideoQualities { get; set; }
        [JsonProperty(PropertyName = "transcoderVideoResolutions")]
        public string TranscoderVideoResolutions { get; set; }
        [JsonProperty(PropertyName = "updatedAt")]
        public string UpdatedAt { get; set; }
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
    }
}
