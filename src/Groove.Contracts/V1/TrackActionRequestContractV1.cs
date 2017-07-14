//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class TrackActionRequestContractV1
    {
        readonly List<string> trackIds = new List<string>();

        [JsonProperty(PropertyName = "TrackIds")]
        public IList<string> TrackIds { get { return this.trackIds; } }
    }
}