using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ChargebackStatus
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public float Amount { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}