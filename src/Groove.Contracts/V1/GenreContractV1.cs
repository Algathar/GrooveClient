//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class GenreContractV1
    {
        [JsonProperty(PropertyName = "HasEditorialPlaylists")]
        public bool HasEditorialPlaylists { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "ParentName")]
        public string ParentName { get; set; }
    }
}