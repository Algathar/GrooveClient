//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class CollectionStateContractV1
    {
        [JsonProperty(PropertyName = "PlaylistCount")]
        public int PlaylistCount { get; set; }

        [JsonProperty(PropertyName = "RemainingPlaylistCount")]
        public int RemainingPlaylistCount { get; set; }

        [JsonProperty(PropertyName = "RemainingTrackCount")]
        public int RemainingTrackCount { get; set; }

        [JsonProperty(PropertyName = "Token")]
        public string Token { get; set; }

        [JsonProperty(PropertyName = "TrackCount")]
        public int TrackCount { get; set; }
    }
}