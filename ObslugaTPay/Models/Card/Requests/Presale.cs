using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;

namespace ObslugaTPay.Models.Card.Requests
{
    /// <summary>
    /// Presale model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Presale
    {
        /// <summary>
        /// Transaction description.
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Client token.
        /// </summary>
        public string CliAuth { get; set; }

        /// <summary>
        /// Transaction amount casted to float.
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// API password.
        /// </summary>
        public string ApiPassword { get; set; }

        /// <summary>
        /// Sign is calculated from cryptographic hash function set in Merchant’s Panel (default SHA-1): hash_alg (method + cli_auth + desc + amount + currency + order_id + language + verification code) where + means concatenation.
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// Transaction currency in ISO numeric format.
        /// </summary>
        public int Currency { get; set; }

        /// <summary>
        /// Merchant order ID used to recognise payment.
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Language for 3DS gateway.
        /// </summary>
        public CardLanguage Language { get; set; }
    }
}
