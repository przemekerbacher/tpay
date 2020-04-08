using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class RefundTransactionRespose
    {
        [DataMember]
        public int Rsult { get; set; }
        [DataMember]
        public ICollection<ChargebackStatus> Chargebacks { get; set; }
    }
}
