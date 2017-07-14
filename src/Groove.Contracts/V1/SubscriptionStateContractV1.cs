//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class SubscriptionStateContractV1
    {
        [JsonProperty(PropertyName = "EndDate")]
        public DateTime EndDate { get; set; }

        [JsonProperty(PropertyName = "Region")]
        public string Region { get; set; }

        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }
    }
}