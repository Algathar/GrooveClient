//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class PlaylistActionContractV1
    {
        readonly List<TrackActionContractV1> trackActions = new List<TrackActionContractV1>();

        [JsonProperty(PropertyName = "CollectionStateToken")]
        public string CollectionStateToken { get; set; }

        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "InsertBeforeTrackId")]
        public string InsertBeforeTrackId { get; set; }

        [JsonProperty(PropertyName = "IsPublished")]
        public bool? IsPublished { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "TrackActions")]
        public IList<TrackActionContractV1> TrackActions { get { return this.trackActions; } }
    }
}