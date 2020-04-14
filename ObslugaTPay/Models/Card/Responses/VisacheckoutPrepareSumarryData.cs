using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace ObslugaTPay.Models.Card.Responses
{
    /// <summary>
    /// Visacheckout Summary Data model
    /// </summary>
    [JsonObject]
    public class VisacheckoutPrepareSumarryData
    {
        [JsonProperty("creationTimeStamp")]
        public string CreationTimeStamp { get; set; }

        [JsonProperty("userData")]
        public ICollection<UserData> UserData{ get; set; }

    }
}