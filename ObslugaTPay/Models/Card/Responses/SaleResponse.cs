using ObslugaTPay.Models.Enums;
using System;

namespace ObslugaTPay.Models.Card.Responses
{
    /// <summary>
    /// Sale response model.
    /// </summary>
    public class SaleResponse
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
        /// Client token.
        /// </summary>
        public string CliAuth { get; set; }

        /// <summary>
        /// Transaction currency in ISO numeric format.
        /// </summary>
        public int Currency { get; set; }

        /// <summary>
        /// Transaction amount casted to float.
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Date of payment.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public SaleStatus? Status { get; set; }

        /// <summary>
        /// Acquirer (Elavon / eService) rejection code - see "Card Payments Rejection Codes" for more details
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Response sign = hash_alg(test_mode + sale_auth + cli_auth + currency + amount + date + status + reason + verification code)
        /// </summary>
        public string Sign { get; set; }
    }
}
