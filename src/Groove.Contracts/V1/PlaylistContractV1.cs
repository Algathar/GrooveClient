//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class PlaylistContractV1
    {
        readonly Dictionary<string, string> otherIds = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        readonly List<TrackContractV1> tracks = new List<TrackContractV1>();

        [JsonProperty(PropertyName = "CollectionStateToken")]
        public string CollectionStateToken { get; set; }

        [JsonProperty(PropertyName = "CompatibleSources")]
        public string CompatibleSources { get; set; }

        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "IsPublished")]
        public bool IsPublished { get; set; }

        [JsonProperty(PropertyName = "IsReadOnly")]
        public bool IsReadOnly { get; set; }

        [JsonProperty(PropertyName = "Link")]
        public string Link { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "OtherIds")]
        public IDictionary<string, string> OtherIds { get { return this.otherIds; } }

        [JsonProperty(PropertyName = "Source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "TrackCount")]
        public int TrackCount { get; set; }

        [JsonProperty(PropertyName = "Tracks")]
        public PaginatedListContractV1<TrackContractV1> Tracks { get; set; }

        [JsonProperty(PropertyName = "UserIsOwner")]
        public bool UserIsOwner { get; set; }
    }
}