#region Copyright
// /************************************************************************
//    Copyright (c) 2016 Jamie Rees
//    File: PlexSearch.cs
//    Created By: Jamie Rees
//   
//    Permission is hereby granted, free of charge, to any person obtaining
//    a copy of this software and associated documentation files (the
//    "Software"), to deal in the Software without restriction, including
//    without limitation the rights to use, copy, modify, merge, publish,
//    distribute, sublicense, and/or sell copies of the Software, and to
//    permit persons to whom the Software is furnished to do so, subject to
//    the following conditions:
//   
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//   
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
//    LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
//    OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
//    WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//  ************************************************************************/
#endregion
using System.Collections.Generic;

using Newtonsoft.Json;

namespace PlexSharp.Models
{
    public class Part
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }
        [JsonProperty(PropertyName = "file")]
        public string File { get; set; }
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }
        [JsonProperty(PropertyName = "audioProfile")]
        public string AudioProfile { get; set; }
        [JsonProperty(PropertyName = "container")]
        public string Container { get; set; }
        [JsonProperty(PropertyName = "videoProfile")]
        public string VideoProfile { get; set; }
        [JsonProperty(PropertyName = "has64bitOffsets")]
        public string Has64bitOffsets { get; set; }
        [JsonProperty(PropertyName = "hasChapterTextStream")]
        public string HasChapterTextStream { get; set; }
        [JsonProperty(PropertyName = "optimizedForStreaming")]
        public string OptimizedForStreaming { get; set; }
    }
    
    public class Media
    {
        [JsonProperty(PropertyName = "Part")]
        public Part Part { get; set; }
        [JsonProperty(PropertyName = "videoResolution")]
        public string VideoResolution { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }
        [JsonProperty(PropertyName = "bitrate")]
        public string Bitrate { get; set; }
        [JsonProperty(PropertyName = "width")]
        public string Width { get; set; }
        [JsonProperty(PropertyName = "height")]
        public string Height { get; set; }
        [JsonProperty(PropertyName = "aspectRatio")]
        public string AspectRatio { get; set; }
        [JsonProperty(PropertyName = "audioChannels")]
        public string AudioChannels { get; set; }
        [JsonProperty(PropertyName = "audioCodec")]
        public string AudioCodec { get; set; }
        [JsonProperty(PropertyName = "videoCodec")]
        public string VideoCodec { get; set; }
        [JsonProperty(PropertyName = "container")]
        public string Container { get; set; }
        [JsonProperty(PropertyName = "videoFrameRate")]
        public string VideoFrameRate { get; set; }
        [JsonProperty(PropertyName = "audioProfile")]
        public string AudioProfile { get; set; }
        [JsonProperty(PropertyName = "videoProfile")]
        public string VideoProfile { get; set; }
        [JsonProperty(PropertyName = "optimizedForStreaming")]
        public string OptimizedForStreaming { get; set; }
        [JsonProperty(PropertyName = "has64bitOffsets")]
        public string Has64bitOffsets { get; set; }
    }
    
    public class Genre
    {
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
    }
    public class Writer
    {
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
    }
    
    public class Director
    {
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
    }
    
    public class Country
    {
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
    }
    
    public class Role
    {
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
    }
    
    public class Video
    {
        public string ProviderId { get; set; }
        [JsonProperty(PropertyName = "guid")]
        public string Guid { get; set; }
        [JsonProperty(PropertyName = "Media")]
        public List<Media> Media { get; set; }
        [JsonProperty(PropertyName = "Genre")]
        public List<Genre> Genre { get; set; }
        [JsonProperty(PropertyName = "Writer")]
        public List<Writer> Writer { get; set; }
        [JsonProperty(PropertyName = "Director")]
        public Director Director { get; set; }
        [JsonProperty(PropertyName = "Country")]
        public Country Country { get; set; }
        [JsonProperty(PropertyName = "Role")]
        public List<Role> Role { get; set; }
        [JsonProperty(PropertyName = "allowSync")]
        public string AllowSync { get; set; }
        [JsonProperty(PropertyName = "librarySectionID")]
        public string LibrarySectionID { get; set; }
        [JsonProperty(PropertyName = "librarySectionTitle")]
        public string LibrarySectionTitle { get; set; }
        [JsonProperty(PropertyName = "librarySectionUUID")]
        public string LibrarySectionUUID { get; set; }
        [JsonProperty(PropertyName = "personal")]
        public string Personal { get; set; }
        [JsonProperty(PropertyName = "sourceTitle")]
        public string SourceTitle { get; set; }
        [JsonProperty(PropertyName = "ratingKey")]
        public string RatingKey { get; set; }
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "studio")]
        public string Studio { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "contentRating")]
        public string ContentRating { get; set; }
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
        [JsonProperty(PropertyName = "rating")]
        public string Rating { get; set; }
        [JsonProperty(PropertyName = "audienceRating")]
        public string AudienceRating { get; set; }
        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }
        [JsonProperty(PropertyName = "tagline")]
        public string Tagline { get; set; }
        [JsonProperty(PropertyName = "thumb")]
        public string Thumb { get; set; }
        [JsonProperty(PropertyName = "art")]
        public string Art { get; set; }
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }
        [JsonProperty(PropertyName = "originallyAvailableAt")]
        public string OriginallyAvailableAt { get; set; }
        [JsonProperty(PropertyName = "addedAt")]
        public string AddedAt { get; set; }
        [JsonProperty(PropertyName = "updatedAt")]
        public string UpdatedAt { get; set; }
        [JsonProperty(PropertyName = "audienceRatingImage")]
        public string AudienceRatingImage { get; set; }
        [JsonProperty(PropertyName = "chapterSource")]
        public string ChapterSource { get; set; }
        [JsonProperty(PropertyName = "ratingImage")]
        public string RatingImage { get; set; }
        [JsonProperty(PropertyName = "titleSort")]
        public string TitleSort { get; set; }
        [JsonProperty(PropertyName = "parentRatingKey")]
        public string ParentRatingKey { get; set; }
        [JsonProperty(PropertyName = "grandparentRatingKey")]
        public string GrandparentRatingKey { get; set; }
        [JsonProperty(PropertyName = "grandparentKey")]
        public string GrandparentKey { get; set; }
        [JsonProperty(PropertyName = "parentKey")]
        public string ParentKey { get; set; }
        [JsonProperty(PropertyName = "grandparentTitle")]
        public string GrandparentTitle { get; set; }
        [JsonProperty(PropertyName = "index")]
        public string Index { get; set; }
        [JsonProperty(PropertyName = "parentIndex")]
        public string ParentIndex { get; set; }
        [JsonProperty(PropertyName = "parentThumb")]
        public string ParentThumb { get; set; }
        [JsonProperty(PropertyName = "grandparentThumb")]
        public string GrandparentThumb { get; set; }
        [JsonProperty(PropertyName = "grandparentArt")]
        public string GrandparentArt { get; set; }
        [JsonProperty(PropertyName = "viewCount")]
        public string ViewCount { get; set; }
        [JsonProperty(PropertyName = "lastViewedAt")]
        public string LastViewedAt { get; set; }
        [JsonProperty(PropertyName = "grandparentTheme")]
        public string GrandparentTheme { get; set; }
    }
    
    public class Provider
    {
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
    public class Directory1
    {
        public string ProviderId { get; set; }
        [JsonProperty(PropertyName = "guid")]
        public string Guid { get; set; }
        [JsonProperty(PropertyName = "Genre")]
        public List<Genre> Genre { get; set; }
        [JsonProperty(PropertyName = "Role")]
        public List<Role> Role { get; set; }
        [JsonProperty(PropertyName = "allowSync")]
        public string AllowSync { get; set; }
        [JsonProperty(PropertyName = "librarySectionID")]
        public string LibrarySectionID { get; set; }
        [JsonProperty(PropertyName = "librarySectionTitle")]
        public string LibrarySectionTitle { get; set; }
        [JsonProperty(PropertyName = "librarySectionUUID")]
        public string LibrarySectionUUID { get; set; }
        [JsonProperty(PropertyName = "personal")]
        public string Personal { get; set; }
        [JsonProperty(PropertyName = "sourceTitle")]
        public string SourceTitle { get; set; }
        [JsonProperty(PropertyName = "ratingKey")]
        public string RatingKey { get; set; }
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        [JsonProperty(PropertyName = "studio")]
        public string Studio { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "contentRating")]
        public string ContentRating { get; set; }
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
        [JsonProperty(PropertyName = "index")]
        public string Index { get; set; }
        [JsonProperty(PropertyName = "rating")]
        public string Rating { get; set; }
        [JsonProperty(PropertyName = "viewCount")]
        public string ViewCount { get; set; }
        [JsonProperty(PropertyName = "lastViewedAt")]
        public string LastViewedAt { get; set; }
        [JsonProperty(PropertyName = "year")]
        public string Year { get; set; }
        [JsonProperty(PropertyName = "thumb")]
        public string Thumb { get; set; }
        [JsonProperty(PropertyName = "art")]
        public string Art { get; set; }
        [JsonProperty(PropertyName = "banner")]
        public string Banner { get; set; }
        [JsonProperty(PropertyName = "theme")]
        public string Theme { get; set; }
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }
        [JsonProperty(PropertyName = "originallyAvailableAt")]
        public string OriginallyAvailableAt { get; set; }
        [JsonProperty(PropertyName = "leafCount")]
        public string LeafCount { get; set; }
        [JsonProperty(PropertyName = "viewedLeafCount")]
        public string ViewedLeafCount { get; set; }
        [JsonProperty(PropertyName = "childCount")]
        public string ChildCount { get; set; }
        [JsonProperty(PropertyName = "addedAt")]
        public string AddedAt { get; set; }
        [JsonProperty(PropertyName = "updatedAt")]
        public string UpdatedAt { get; set; }
        [JsonProperty(PropertyName = "parentTitle")]
        public string ParentTitle { get; set; }
    }

    
    public class PlexSearch
    {

        [JsonProperty(PropertyName = "Directory")]
        public List<Directory1> Directory { get; set; }
        [JsonProperty(PropertyName = "Video")]
        public List<Video> Video { get; set; }
        [JsonProperty(PropertyName = "Provider")]
        public List<Provider> Provider { get; set; }
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        [JsonProperty(PropertyName = "mediaTagPrefix")]
        public string MediaTagPrefix { get; set; }
        [JsonProperty(PropertyName = "mediaTagVersion")]
        public string MediaTagVersion { get; set; }
    }

    public class PlexSearchWrapper
    {
        
        [JsonProperty("MediaContainer")]
        public PlexSearch PlexSearch { get; set; }
    }
}