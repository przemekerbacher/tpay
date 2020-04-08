using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ReportResponse
    {
        [DataMember]
        public Result Result { get; set; }
        [DataMember]
        public string Report { get; set; }
        [DataMember]
        public TransactionErrorCodes Err { get; set; }
    }
}
