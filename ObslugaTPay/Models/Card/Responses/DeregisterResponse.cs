using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;

namespace ObslugaTPay.Models.Card.Responses
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class DeregisterResponse
    {
        /// <summary>
        /// f input parameters are correct and client was deregistered, method returns result = 1.
        /// </summary>
        public Result Result { get; set; }

        /// <summary>
        /// Error code number if an error occurs or not present in response.
        /// </summary>
        public string ErrCode { get; set; }
    }
}
