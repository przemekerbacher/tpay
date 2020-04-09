using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ChargebackResponse
    {
        [DataMember]
        public Result Result { get; set; }
        [DataMember]
        public TransactionErrorCodes? Err{ get; set; }
        [DataMember]
        public float? Amount { get; set; }
    }
}
