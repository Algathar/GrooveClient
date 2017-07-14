//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class ContentItemContractV1
    {
        [JsonProperty(PropertyName = "Album")]
        public AlbumContractV1 Album { get; set; }

        [JsonProperty(PropertyName = "Artist")]
        public ArtistContractV1 Artist { get; set; }

        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }
    }
}