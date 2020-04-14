using Newtonsoft.Json;
using System.Collections.Generic;

namespace ObslugaTPay.Models.Card.Requests
{
    /// <summary>
    /// Visacheckout Finish Summary Data model
    /// </summary>
    [JsonObject]
    public class VisacheckoutFinishSummaryData
    {
        [JsonProperty("paymentRequest")]
        public ICollection<PaymentRequest> PaymentRequest{ get; set; }

        [JsonProperty("riskData")]
        public ICollection<RiskData> RiskData { get; set; }

        [JsonProperty("partialShippingAddress")]
        public ICollection<PartialShippingAddress> PartialShippingAddress { get; set; }
    }
}