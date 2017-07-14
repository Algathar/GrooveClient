//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class PaginatedListContractV1<TItemContract>
    {
        readonly List<TItemContract> items = new List<TItemContract>();

        [JsonProperty(PropertyName = "ContinuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty(PropertyName = "Items")]
        public IList<TItemContract> Items { get { return this.items; } }

        [JsonProperty(PropertyName = "TotalItemCount")]
        public int TotalItemCount { get; set; }
    }
}