//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class ContentResponseContractV1
    {
        readonly List<ActivityContractV1> activities = new List<ActivityContractV1>();
        readonly List<AlbumContractV1> albums = new List<AlbumContractV1>();
        readonly List<ArtistContractV1> artists = new List<ArtistContractV1>();
        readonly List<GenreContractV1> catalogGenres = new List<GenreContractV1>();
        readonly List<MoodContractV1> moods = new List<MoodContractV1>();
        readonly List<PlaylistContractV1> playlists = new List<PlaylistContractV1>();
        readonly List<RadioContractV1> radios = new List<RadioContractV1>();
        readonly List<ContentItemContractV1> results = new List<ContentItemContractV1>();
        readonly List<TrackContractV1> tracks = new List<TrackContractV1>();

        [JsonProperty(PropertyName = "Activities")]
        public IList<ActivityContractV1> Activities { get { return this.activities; } }

        [JsonProperty(PropertyName = "Albums")]
        public IList<AlbumContractV1> Albums { get { return this.albums; } }

        [JsonProperty(PropertyName = "Artists")]
        public IList<ArtistContractV1> Artists { get { return this.artists; } }

        [JsonProperty(PropertyName = "CatalogGenres")]
        public IList<GenreContractV1> CatalogGenres { get { return this.catalogGenres; } }

        [JsonProperty(PropertyName = "Culture")]
        public string Culture { get; set; }

        [JsonProperty(PropertyName = "Error")]
        public ErrorContractV1 Error { get; set; }

        [JsonProperty(PropertyName = "Moods")]
        public IList<MoodContractV1> Moods { get { return this.moods; } }

        [JsonProperty(PropertyName = "Playlists")]
        public IList<PlaylistContractV1> Playlists { get { return this.playlists; } }

        [JsonProperty(PropertyName = "Radios")]
        public IList<RadioContractV1> Radios { get { return this.radios; } }

        [JsonProperty(PropertyName = "Results")]
        public IList<ContentItemContractV1> Results { get { return this.results; } }

        [JsonProperty(PropertyName = "Tracks")]
        public IList<TrackContractV1> Tracks { get { return this.tracks; } }
    }
}