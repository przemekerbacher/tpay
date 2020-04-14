using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;

namespace ObslugaTPay.Models.Card.Responses
{
    /// <summary>
    /// Register sale respond model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class RegisterSaleRespond
    {
        /// <summary>
        /// Api call result.
        /// </summary>
        public Result Result { get; set; }

        /// <summary>
        /// Transaction id in tpay.com system.
        /// </summary>
        public string SaleAuth { get; set; }

        /// <summary>
        /// Sign is calculated from cryptographic hash function set in Merchant’s Panel (default SHA-1): sha1(sale_auth + verification code) where + means concatenation.
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// Error code number if an error occurs or not present in response.
        /// </summary>
        public string ErrCode { get; set; }

        /// <summary>
        /// Error code description if an error occurs or not present in response. - see "Card Payments Rejection Codes" for more details.
        /// </summary>
        public string ErrDesc { get; set; }
    }
}
