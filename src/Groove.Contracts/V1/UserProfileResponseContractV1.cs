//---------------------------
// Copyright (c) Peter Innes
//---------------------------

using Newtonsoft.Json;

namespace Groove.Contracts.V1
{
    [JsonObject]
    public sealed class UserProfileResponseContractV1
    {
        [JsonProperty(PropertyName = "Collection")]
        public CollectionStateContractV1 Collection { get; set; }

        [JsonProperty(PropertyName = "Culture")]
        public string Culture { get; set; }

        [JsonProperty(PropertyName = "Error")]
        public ErrorContractV1 Error { get; set; }

        [JsonProperty(PropertyName = "HasSubscription")]
        public bool HasSubscription { get; set; }

        [JsonProperty(PropertyName = "IsSubscriptionAvailableForPurchase")]
        public bool IsSubscriptionAvailableForPurchase { get; set; }

        [JsonProperty(PropertyName = "Subscription")]
        public SubscriptionStateContractV1 Subscription { get; set; }
    }
}