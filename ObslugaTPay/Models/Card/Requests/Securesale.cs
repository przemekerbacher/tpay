using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;

namespace ObslugaTPay.Models.Card.Requests
{
    /// <summary>
    /// Securesale model
    /// </summary>
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Securesale
    {
        /// <summary>
        /// Customer name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Customer email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Transaction description.
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Transaction amount casted to float.
        /// </summary>
        public float Amount { get; set; }

        /// <summary>
        /// Api password
        /// </summary>
        public string ApiPassword { get; set; }

        /// <summary>
        /// Sign is calculated from cryptographic hash function set in Merchant panel (default SHA-1) hash_alg (method + card + name + email + desc + amount + currency + order_id + onetimer + language + enable_pow_url + verification code) where + means concatenation.
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// Transaction currency in ISO numeric format.
        /// </summary>
        public int Currency { get; set; }

        /// <summary>
        /// Defines if customer wants to save his card for future use. If this parameter is sent, there will be no cli_auth parameter sent in system notificaion.
        /// </summary>
        public string Onetimer { get; set; }

        /// <summary>
        /// Url to redirect customer in case of payment success
        /// </summary>
        public string PowUrl { get; set; }

        /// <summary>
        /// Url to redirect customer in case of payment failure.
        /// </summary>
        public string PowUrlBlad { get; set; }

        /// <summary>
        /// Merchant order ID used to recognise payment.
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Language for 3DS gateway.
        /// </summary>
        public CardLanguage? Language { get; set; }

        /// <summary>
        /// Can be 1.
        /// </summary>
        public EnablePowUrl? EnablePowUrl { get; set; }

        /// <summary>
        /// Card hash calculated by schema described in method description
        /// </summary>
        public string Card { get; set; }

    }
}
