using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    /// <summary>
    /// Chargeback response model
    /// </summary>
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ChargebackResponse
    {
        /// <summary>
        /// Request result (digit; 1 – correct, 0 - incorrect) Can be 1 or 0
        /// </summary>
        [DataMember]
        public Result Result { get; set; }

        /// <summary>
        /// <see cref="TransactionErrorCodes"/>
        /// </summary>
        [DataMember]
        public TransactionErrorCodes? Err{ get; set; }
    }
}
