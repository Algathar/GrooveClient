//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class SeedContractV1
    {
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }
    }
}