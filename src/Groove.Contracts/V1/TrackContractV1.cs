//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class TrackContractV1
    {
        readonly List<ContributorContractV1> artists = new List<ContributorContractV1>();
        readonly List<string> genres = new List<string>();
        readonly Dictionary<string, string> otherIds = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        readonly List<string> rights = new List<string>();
        readonly List<string> subgenres = new List<string>();

        [JsonProperty(PropertyName = "Album")]
        public AlbumContractV1 Album { get; set; }

        [JsonProperty(PropertyName = "Artists")]
        public IList<ContributorContractV1> Artists { get { return this.artists; } }

        [JsonProperty(PropertyName = "CompatibleSources")]
        public string CompatibleSources { get; set; }

        [JsonProperty(PropertyName = "Duration")]
        public TimeSpan? Duration { get; set; }

        [JsonProperty(PropertyName = "Genres")]
        public IList<string> Genres { get { return this.genres; } }

        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "IsExplicit")]
        public bool? IsExplicit { get; set; }

        [JsonProperty(PropertyName = "Link")]
        public string Link { get; set; }

        [JsonProperty(PropertyName = "OtherIds")]
        public IDictionary<string, string> OtherIds { get { return this.otherIds; } }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "ReleaseDate")]
        public DateTime? ReleaseDate { get; set; }

        [JsonProperty(PropertyName = "Rights")]
        public IList<string> Rights { get { return this.rights; } }

        [JsonProperty(PropertyName = "Source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "Subgenres")]
        public IList<string> Subgenres { get { return this.subgenres; } }

        [JsonProperty(PropertyName = "Subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty(PropertyName = "TrackNumber")]
        public int? TrackNumber { get; set; }
    }
}