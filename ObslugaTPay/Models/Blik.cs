using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Blik
    {
        public string Title { get; set; }
        public int? Code { get; set; }
        public string ApiPassword { get; set; }
        public Alias Alias { get; set; }
    }
}
