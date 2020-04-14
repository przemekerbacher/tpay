using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System;

namespace ObslugaTPay.Models.Card.Responses
{
    /// <summary>
    /// Refund Reponse model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class RefunResponse
    {
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
        /// 
        /// </summary>
        public string SaleRef { get; set; }

        /// <summary>
        /// Transaction currency in ISO numeric format.
        /// </summary>
        public int Currency { get; set; }

        /// <summary>
        /// Transaction amount casted to float.
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Date of paymentPattern: YYYY-MM-DD HH:mm:ss.
        /// </summary>
        public DateTime Date{ get; set; }

        /// <summary>
        /// Can be correct or declined.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Acquirer (Elavon / eService) rejection code - see "Card Payments Rejection Codes" for more details.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Response sign = hash_alg(test_mode + sale_auth + sale_ref + order_id + cli_auth + card + currency + amount + date + status + reason + verification code).
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Card { get; set; }

        /// <summary>
        /// Client token.
        /// </summary>
        public string CliAuth { get; set; }

        /// <summary>
        /// Error code number if an error occurs or not present in response.
        /// </summary>
        public string ErrCode { get; set; }

    }
}
