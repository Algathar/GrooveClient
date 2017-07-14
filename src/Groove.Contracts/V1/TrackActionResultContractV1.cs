//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class TrackActionResultContractV1
    {
        [JsonProperty(PropertyName = "Error")]
        public ErrorContractV1 Error { get; set; }

        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "InputId")]
        public string InputId { get; set; }
    }
}