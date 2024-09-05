// <copyright file="Environment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JustGainsAPI.Standard
{
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// Testing.
        /// </summary>
        [EnumMember(Value = "testing")]
        Testing,

        /// <summary>
        /// Production.
        /// </summary>
        [EnumMember(Value = "production")]
        Production,

        /// <summary>
        /// Mock.
        /// </summary>
        [EnumMember(Value = "mock")]
        Mock,
    }
}
