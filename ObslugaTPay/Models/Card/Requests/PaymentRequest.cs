using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ObslugaTPay.Models.Card.Requests
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class PaymentRequest
    {
        /// <summary>
        /// The currency with which to process the transaction.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Total of the payment including all amounts.
        /// </summary>
        public string Total { get; set; }

        /// <summary>
        /// Merchant's order ID associated with the payment.
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Description associated with the payment.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Subtotal of the payment.
        /// </summary>
        public string Subtotal { get; set; }

        /// <summary>
        /// Total of shipping and handling charges in the payment.
        /// </summary>
        public string ShippingHandling { get; set; }

        /// <summary>
        /// Total tax-related charges in the payment.
        /// </summary>
        public string Tax { get; set; }

        /// <summary>
        /// Total of discounts related to the payment. If provided, it is a positive value representing the amount to be deducted from the total.
        /// </summary>
        public string Discount { get; set; }

        /// <summary>
        /// Total gift-wrapping charges in the payment.
        /// </summary>
        public string GiftWrap { get; set; }

        /// <summary>
        /// Total uncategorized charges in the payment.
        /// </summary>
        public string Misc { get; set; }

        /// <summary>
        /// Promotion codes associated with the payment.
        /// </summary>
        public string PromoCode { get; set; }
    }
}