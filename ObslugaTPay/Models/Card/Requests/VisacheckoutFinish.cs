using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System.Collections.Generic;

namespace ObslugaTPay.Models.Card.Requests
{
    /// <summary>
    /// Visacheckout Finish model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class VisacheckoutFinish
    {
        /// <summary>
        /// API password.
        /// </summary>
        public string ApiPassword { get; set; }

        /// <summary>
        /// Modified summary_data parameter received from visacheckout_prepare. Can be used, when the total amount or other parameters changea in the order process.
        /// </summary>
        public ICollection<VisacheckoutFinishSummaryData> SummaryData { get; set; }

        /// <summary>
        /// Visa Checkout Call Id.
        /// </summary>
        public string CallId { get; set; }

        /// <summary>
        /// Language for 3DS gateway.
        /// </summary>
        public CardLanguage Language { get; set; }

        /// <summary>
        /// Sign is calculated from cryptographic hash function set in Merchant’s Panel (default SHA-1): hash_alg (method + call_id + language + enable_pow_url + verification code) where + means concatenation.
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// If parameter was sent, system will redirect a cutomer to the merchant site after payment. 1 – redirect Adress is set in Merchant Panel.
        /// </summary>
        public EnablePowUrl EnablePowUrl { get; set; }
    }
}
