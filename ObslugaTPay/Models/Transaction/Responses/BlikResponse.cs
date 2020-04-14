﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ObslugaTPay.Models.Enums;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ObslugaTPay.Models
{
    /// <summary>
    /// Blik response model
    /// </summary>
    [DataContract]
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BlikResponse
    {
        /// <summary>
        /// Attention! result: 1 does not indicate transfer of funds! This is successful user app popup indicator. Can be 0 or 1
        /// </summary>
        [DataMember]
        public Result Result { get; set; }

        /// <summary>
        /// <see cref="BlikAliasResponse"/>
        /// </summary>
        [DataMember]
        public List<BlikAliasResponse> AvailableUserApps { get; set; }

        /// <summary>
        /// <see cref="TransactionErrorCodes"/>
        /// </summary>
        [DataMember]
        public TransactionErrorCodes? Err { get; set; }
    }
}
