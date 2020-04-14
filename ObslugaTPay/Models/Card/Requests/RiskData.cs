using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ObslugaTPay.Models.Card.Requests
{
    /// <summary>
    /// Risk Data model
    /// </summary>
    [JsonObject]
    public class RiskData
    {
        /// <summary>
        /// Address verification system response code.
        /// </summary>
        [JsonProperty("avsResponseCode")]
        public string AvsResponseCode { get; set; }
    }
}