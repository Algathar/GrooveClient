//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class RadioContractV1
    {
        readonly Dictionary<string, string> otherIds = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        [JsonProperty(PropertyName = "CompatibleSources")]
        public string CompatibleSources { get; set; }

        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "OtherIds")]
        public IDictionary<string, string> OtherIds { get { return this.otherIds; } }

        [JsonProperty(PropertyName = "Source")]
        public string Source { get; set; }
    }
}