using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Create
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public AcceptTos AcceptTos { get; set; }
        [DataMember]
        public string ApiPassword { get; set; }
        [DataMember]
        public Online Online { get; set; }
        [DataMember]
        public byte Group { get; set; }
        [DataMember]
        public double Amount { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string CRC { get; set; }
        [DataMember]
        public string ResultUrl { get; set; }
        [DataMember]
        public string ResultEmail { get; set; }
        [DataMember]
        public string MerchantDescription { get; set; }
        [DataMember]
        public string CustomDescription { get; set; }
        [DataMember]
        public string ReturnUrl { get; set; }
        [DataMember]
        public string ReturnErrorUrl { get; set; }
        [DataMember]
        public string Language { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Zip { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]

        public string Phone { get; set; }
        [DataMember]

        public string ExprationDate { get; set; }
        [DataMember]

        public string TimeHash { get; set; }
        [DataMember]

        public string Md5sum { get; set; }
    }
}
