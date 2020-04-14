using Newtonsoft.Json;

namespace ObslugaTPay.Models.Card.Responses
{
    /// <summary>
    /// User Data model
    /// </summary>
    [JsonObject]
    public class UserData
    {
        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }
        
        [JsonProperty("userFirstName")]
        public string UserFirstName { get; set; }
    }
}