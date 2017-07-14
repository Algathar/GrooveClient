//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class StreamResponseContractV1
    {
        [JsonProperty(PropertyName = "ContentType")]
        public string ContentType { get; set; }

        [JsonProperty(PropertyName = "Error")]
        public ErrorContractV1 Error { get; set; }

        [JsonProperty(PropertyName = "ExpiresOn")]
        public DateTime ExpiresOn { get; set; }

        [JsonProperty(PropertyName = "Url")]
        public string Url { get; set; }
    }
}