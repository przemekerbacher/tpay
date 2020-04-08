using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetResponse
    {
        [DataMember]
        public Result Result { get; set; }
        public Status? Status { get; set; }
        public ErrorCode? ErrorCode { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? PaymentTime { get; set; }
        public DateTime? ChargebackTime { get; set; }
        public int Channel { get; set; }
        public int TestMode { get; set; }
        public float Amount { get; set; }
        public float AmouuntPaid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public TransactionErrorCodes? Err { get; set; }

    }
}
