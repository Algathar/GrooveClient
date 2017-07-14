//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class PlaylistActionResultContractV1
    {
        readonly List<TrackActionResultContractV1> trackActions = new List<TrackActionResultContractV1>();

        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "IsPublished")]
        public bool? IsPublished { get; set; }

        [JsonProperty(PropertyName = "IsReadOnly")]
        public bool? IsReadOnly { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "TrackActions")]
        public IList<TrackActionResultContractV1> TrackActions { get { return this.trackActions; } }
    }
}