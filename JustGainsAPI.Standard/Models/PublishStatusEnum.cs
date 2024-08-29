// <copyright file="PublishStatusEnum.cs" company="APIMatic">
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
    /// PublishStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PublishStatusEnum
    {
        /// <summary>
        /// Unreviewed.
        /// </summary>
        [EnumMember(Value = "unreviewed")]
        Unreviewed,

        /// <summary>
        /// Reviewed.
        /// </summary>
        [EnumMember(Value = "reviewed")]
        Reviewed,

        /// <summary>
        /// Published.
        /// </summary>
        [EnumMember(Value = "published")]
        Published
    }
}