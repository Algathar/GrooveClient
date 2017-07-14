//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class ErrorContractV1
    {
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "ErrorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }
    }
}