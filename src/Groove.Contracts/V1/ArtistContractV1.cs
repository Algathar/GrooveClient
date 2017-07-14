//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class ArtistContractV1
    {
        readonly List<AlbumContractV1> albums = new List<AlbumContractV1>();
        readonly List<string> genres = new List<string>();
        readonly Dictionary<string, string> otherIds = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        readonly List<string> subgenres = new List<string>();
        readonly List<TrackContractV1> topTracks = new List<TrackContractV1>();

        [JsonProperty(PropertyName = "Albums")]
        public IList<AlbumContractV1> Albums { get { return this.albums; } }

        [JsonProperty(PropertyName = "Biography")]
        public string Biography { get; set; }

        [JsonProperty(PropertyName = "CompatibleSources")]
        public string CompatibleSources { get; set; }

        [JsonProperty(PropertyName = "Genres")]
        public IList<string> Genres { get { return this.genres; } }

        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "Link")]
        public string Link { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "OtherIds")]
        public IDictionary<string, string> OtherIds { get { return this.otherIds; } }

        [JsonProperty(PropertyName = "ReleaseDate")]
        public DateTime? ReleaseDate { get; set; }

        [JsonProperty(PropertyName = "Source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "Subgenres")]
        public IList<string> Subgenres { get { return this.subgenres; } }

        [JsonProperty(PropertyName = "Subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty(PropertyName = "TopTracks")]
        public IList<TrackContractV1> TopTracks { get { return this.topTracks; } }
    }
}