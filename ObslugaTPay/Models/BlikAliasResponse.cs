using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BlikAliasResponse
    {
        [DataMember]
        public string ApplicationName { get; set; }
        [DataMember]
        public string ApplicationCode { get; set; }
    }
}
