using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;

namespace ObslugaTPay.Models.Card.Requests
{
    /// <summary>
    /// Visacheckout Prepare model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class VisacheckoutPreapare
    {
        /// <summary>
        /// API password.
        /// </summary>
        public string ApiPassword { get; set; }

        /// <summary>
        /// Visa Checkout Call Id.
        /// </summary>
        public string CallId { get; set; }

        /// <summary>
        /// language for 3DS gateway.
        /// </summary>
        public CardLanguage Language { get; set; }

        /// <summary>
        /// Sign is calculated from cryptographic hash function set in Merchant’s Panel (default SHA-1): hash_alg (method + call_id + language + verification code) where + means concatenation.
        /// </summary>
        public string Sign { get; set; }
    }
}
