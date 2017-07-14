//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class TrackActionContractV1
    {
        [JsonProperty(PropertyName = "Action")]
        public string Action { get; set; }

        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }
    }
}