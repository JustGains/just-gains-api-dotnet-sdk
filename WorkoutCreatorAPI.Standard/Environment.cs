// <copyright file="Environment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorkoutCreatorAPI.Standard
{
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// Production.
        /// </summary>
        [EnumMember(Value = "Production")]
        Production,

        /// <summary>
        /// Testing.
        /// </summary>
        [EnumMember(Value = "Testing")]
        Testing,

        /// <summary>
        /// Mock.
        /// </summary>
        [EnumMember(Value = "Mock")]
        Mock,
    }
}
