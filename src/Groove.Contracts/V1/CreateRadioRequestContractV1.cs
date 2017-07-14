//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class CreateRadioRequestContractV1
    {
        readonly List<SeedContractV1> seeds = new List<SeedContractV1>();

        [JsonProperty(PropertyName = "Seeds")]
        public IList<SeedContractV1> Seeds { get { return this.seeds; } }
    }
}