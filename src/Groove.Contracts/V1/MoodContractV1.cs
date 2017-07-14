//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class MoodContractV1
    {
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }
    }
}