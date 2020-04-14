using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ObslugaTPay.Models.Card.Requests
{
    /// <summary>
    /// Sale model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Sale
    {
        /// <summary>
        /// Client token.
        /// </summary>
        public string CliAuth { get; set; }

        /// <summary>
        /// Transaction id in tpay.com system
        /// </summary>
        public string SaleAuth { get; set; }

        /// <summary>
        /// API password.
        /// </summary>
        public string ApiPasword { get; set; }

        /// <summary>
        /// Request sign is calculated from cryptographic hash function set in Merchant’s Panel (default SHA-1): hash_alg (method + cli_auth + sale_auth + verification code); where + means concatenation. Passed cli_auth has to match with cli_auth used while creating sale in presale method.
        /// </summary>
        public string Sign { get; set; }
    }
}
