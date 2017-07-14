//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class RadioResponseContractV1
    {
        readonly List<TrackContractV1> tracks = new List<TrackContractV1>();

        [JsonProperty(PropertyName = "SessionId")]
        public string SessionId { get; set; }

        [JsonProperty(PropertyName = "Tracks")]
        public IList<TrackContractV1> Tracks { get { return this.tracks; } }
    }
}