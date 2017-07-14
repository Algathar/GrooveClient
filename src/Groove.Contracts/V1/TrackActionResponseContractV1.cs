//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class TrackActionResponseContractV1
    {
        readonly List<TrackActionResultContractV1> trackActionResults = new List<TrackActionResultContractV1>();

        [JsonProperty(PropertyName = "Error")]
        public ErrorContractV1 Error { get; set; }

        [JsonProperty(PropertyName = "TrackActionResults")]
        public IList<TrackActionResultContractV1> TrackActionResults { get { return this.trackActionResults; } }
    }
}