#region Copyright statement
// --------------------------------------------------------------
// Copyright (C) 1999-2015 Exclaimer Ltd. All Rights Reserved.
// No part of this source file may be copied and/or distributed 
// without the express permission of a director of Exclaimer Ltd
// ---------------------------------------------------------------
#endregion
using System.Collections.Generic;

using Newtonsoft.Json;

namespace PlexSharp.Models
{
    public class PlexLibrariesWrapper
    {
        [JsonProperty("MediaContainer")]
        public PlexLibraries PlexLibraries { get; set; }
    }

    public class PlexLibraries
    {
        [JsonProperty("Directory")]
        public List<Directory> Directories { get; set; }
    }
    
    public partial class Location
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("path")]
        public string path { get; set; }
    }
}