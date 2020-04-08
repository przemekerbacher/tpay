using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Chargeback
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string ApiPassword { get; set; }
    }
}
