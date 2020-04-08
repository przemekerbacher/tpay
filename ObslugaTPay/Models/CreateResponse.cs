using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateResponse
    {
        [DataMember]
        public string Err { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public double Amount { get; set; }
        [DataMember]
        public int AccountNumer { get; set; }
        [DataMember]
        public Online Online { get; set; }
        [DataMember]
        public string Url { get; set; }
        [DataMember]
        public string Desc { get; set; } 
        
    }
}
