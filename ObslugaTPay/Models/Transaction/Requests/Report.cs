using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    /// <summary>
    /// Report model
    /// </summary>
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Report
    {
        /// <summary>
        /// Start range of generated report.
        /// </summary>
        [DataMember]
        public DateTime FromDate { get; set; }

        /// <summary>
        /// End range of generated report.
        /// </summary>
        [DataMember]
        public DateTime ToDate { get; set; }

        /// <summary>
        /// API password.
        /// </summary>
        [DataMember]
        public string ApiPassword { get; set; }
    }
}
