using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;

namespace ObslugaTPay.Models.Card.Requests
{
    /// <summary>
    /// Register sale model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class RegisterSale
    {
        /// <summary>
        /// Customer name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Customer email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Transaction description.
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Transaction amount casted to float.
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// API password.s
        /// </summary>
        public string ApiPassword { get; set; }

        /// <summary>
        /// Sign is calculated from cryptographic hash function set in Merchant’s Panel (default SHA-1): sha1(method + name + email + desc + amount + currency + order_id + onetimer + language + verification code) where + means concatenation.
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// Transaction currency in ISO numeric format.
        /// </summary>
        public int Currency { get; set; }

        /// <summary>
        /// Defines if customer wants to save his card for future use. If this parameter is sent, there will be no cli_auth parameter sent in system notificaion (see presale method).
        /// </summary>
        public string Onetimer { get; set; }

        /// <summary>
        /// Url to redirect customer in case of payment success.
        /// </summary>
        public string PowUrl { get; set; }

        /// <summary>
        /// Url to redirect customer in case of payment failure.
        /// </summary>
        public string PowUrlBlad { get; set; }

        /// <summary>
        /// Oerchant order ID used to recognise payment.
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Language for 3DS gateway.
        /// </summary>
        public CardLanguage Language { get; set; }
    }
}
