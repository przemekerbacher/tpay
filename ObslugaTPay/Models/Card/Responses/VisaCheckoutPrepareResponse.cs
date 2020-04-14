using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System.Collections.Generic;

namespace ObslugaTPay.Models.Card.Responses
{
    /// <summary>
    /// Visacheckout Prepare Response model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class VisacheckoutPrepareResponse
    {
        /// <summary>
        /// Api call result.
        /// </summary>
        public Result Result { get; set; }

        /// <summary>
        /// Summary Visa Checkout data connected with passed Call Id.
        /// </summary>
        public ICollection<VisacheckoutPrepareSumarryData> SummaryData { get; set; }

    }
}
