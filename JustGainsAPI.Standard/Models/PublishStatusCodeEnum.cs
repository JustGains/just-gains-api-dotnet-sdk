// <copyright file="PublishStatusCodeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json;

namespace JustGainsAPI.Standard.Models
{
    /// <summary>
    /// PublishStatusCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PublishStatusCodeEnum
    {
        /// <summary>
        /// UNREVIEWED.
        /// </summary>
        [EnumMember(Value = "UNREVIEWED")]
        UNREVIEWED,

        /// <summary>
        /// REVIEWED.
        /// </summary>
        [EnumMember(Value = "REVIEWED")]
        REVIEWED,

        /// <summary>
        /// PUBLISHED.
        /// </summary>
        [EnumMember(Value = "PUBLISHED")]
        PUBLISHED
    }
}