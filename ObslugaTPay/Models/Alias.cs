using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Alias
    {
        [DataMember]
        public string Value { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Key { get; set; }
    }
}
