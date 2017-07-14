//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class PlaylistActionResponseContractV1
    {
        [JsonProperty(PropertyName = "Error")]
        public ErrorContractV1 Error { get; set; }

        [JsonProperty(PropertyName = "PlaylistActionResult")]
        public PlaylistActionResultContractV1 PlaylistActionResult { get; set; }
    }
}