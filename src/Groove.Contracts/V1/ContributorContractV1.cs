//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class ContributorContractV1
    {
        [JsonProperty(PropertyName = "Artist")]
        public ArtistContractV1 Artist { get; set; }

        [JsonProperty(PropertyName = "Role")]
        public string Role { get; set; }
    }
}