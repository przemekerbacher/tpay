using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    /// <summary>
    /// Refund transaction response model.
    /// </summary>
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class RefundTransactionRespose
    {
        /// <summary>
        /// Request result.
        /// </summary>
        [DataMember]
        public Result Result { get; set; }

        /// <summary>
        /// Chargebacks associated to transaction.
        /// </summary>
        [DataMember]
        public ICollection<ChargebackStatus> Chargebacks { get; set; }

        /// <summary>
        /// Error code.
        /// </summary>
        [DataMember]
        public TransactionErrorCodes? Err { get; set; }
    }
}
