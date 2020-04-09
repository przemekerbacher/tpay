using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BlikResponse
    {
        [DataMember]
        public Result Result { get; set; }
        [DataMember]
        public List<BlikAliasResponse> AvailableUserApps { get; set; }
        [DataMember]

        public TransactionErrorCodes? Err { get; set; }
    }
}
