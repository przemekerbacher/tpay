using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Report
    {
        [DataMember]
        public DateTime FromDate { get; set; }
        [DataMember]
        public DateTime ToDate { get; set; }
        [DataMember]
        public string ApiPassword { get; set; }
    }
}
