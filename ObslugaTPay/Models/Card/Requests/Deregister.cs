using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;

namespace ObslugaTPay.Models.Card.Requests
{
    /// <summary>
    /// Deregister model.
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Deregister
    {
        /// <summary>
        /// Client token.
        /// </summary>
        public string CliAuth { get; set; }

        /// <summary>
        /// Language for 3DS gateway.
        /// </summary>
        public CardLanguage Language { get; set; }

        /// <summary>
        /// API password.
        /// </summary>
        public string ApiPassword { get; set; }

        /// <summary>
        /// Sign is calculated from cryptographic hash function set in Merchant’s Panel (default SHA-1): hash_alg (method + cli_auth + language + verification code) where + means concatenation.
        /// </summary>
        public string Sign { get; set; }
    }
}
