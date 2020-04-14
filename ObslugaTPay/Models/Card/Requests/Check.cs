using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ObslugaTPay.Models.Card.Requests
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Check
    {
        /// <summary>
        /// API password.
        /// </summary>
        public string ApiPassword { get; set; }
    }
}
