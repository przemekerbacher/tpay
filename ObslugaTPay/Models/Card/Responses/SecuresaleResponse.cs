using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System;

namespace ObslugaTPay.Models.Card.Responses
{
    /// <summary>
    /// Securasale response model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SecuresaleResponse
    {
        /// <summary>
        /// Transaction link
        /// </summary>
        [JsonProperty("3ds_url")]
        public string Url3ds { get; set; }

        /// <summary>
        /// Api call result.
        /// </summary>
        public Result Result { get; set; }

        /// <summary>
        /// This parameter is present in response and included in sign calculation only when the merchant account is in test mode.
        /// </summary>
        public string TestMode { get; set; }

        /// <summary>
        /// Transaction id in tpay.com system.
        /// </summary>
        public string SaleAuth { get; set; }

        /// <summary>
        /// Client token.
        /// </summary>
        public string CliAuth { get; set; }

        /// <summary>
        /// Transaction currency in ISO numeric format.
        /// </summary>
        public int Currency { get; set; }

        /// <summary>
        /// Transaction amount casted to float/
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Date of payment.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Can be correct or declined.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Acquirer (Elavon / eService) rejection code - see "Card Payments Rejection Codes" for more details.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Card number last 4 digits - for example ****1234.
        /// </summary>
        public string Card { get; set; }

        /// <summary>
        /// sign is calculated from cryptographic hash function set in Merchant panel (default SHA-1) hash_alg(test_mode + sale_auth + cli_auth + card + currency + amount + date + status + verification code).
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// Error code number if an error occurs or not present in response.
        /// </summary>
        public string ErrCode { get; set; }

        /// <summary>
        /// Error code description if an error occurs or not present in response. - see "Card Payments Rejection Codes" for more details
        /// </summary>
        public string ErrDesc { get; set; }
    }
}
