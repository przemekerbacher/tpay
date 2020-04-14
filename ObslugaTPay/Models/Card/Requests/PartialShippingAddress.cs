using Newtonsoft.Json;

namespace ObslugaTPay.Models.Card.Requests
{
    /// <summary>
    /// Partial Shipping Address model
    /// </summary>
    [JsonObject]
    public class PartialShippingAddress
    {
        /// <summary>
        /// Country code of the country where an item should be shipped, such as US; useful for calculating shipping costs.
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}