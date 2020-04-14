using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;

namespace ObslugaTPay.Models.Card.Requests
{
    /// <summary>
    /// Refund Model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Refund
    {
        /// <summary>
        /// Client token.
        /// </summary>
        public string CliAuth { get; set; }

        /// <summary>
        /// Transaction id in tpay.com system.
        /// </summary>
        public string SaleAuth { get; set; }


        /// <summary>
        /// Description
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Transaction currency in ISO numeric format.
        /// </summary>
        public int Curency { get; set; }

        /// <summary>
        /// Transaction amount casted to float.
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// language for 3DS gateway.
        /// </summary>
        public CardLanguage Language { get; set; }

        /// <summary>
        /// API password.
        /// </summary>
        public string ApiPassword { get; set; }

        /// <summary>
        /// Sign is calculated from cryptographic hash function set in Merchant’s Panel (default SHA-1): hash_alg (method + cli_auth + sale_auth + desc + amount + currency + language + verification code); where + means concatenation.
        /// </summary>
        public string Sign { get; set; }
    }
}
