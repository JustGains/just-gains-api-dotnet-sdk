// <copyright file="SortOrderEnum.cs" company="APIMatic">
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
    /// SortOrderEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortOrderEnum
    {
        /// <summary>
        /// Asc.
        /// </summary>
        [EnumMember(Value = "asc")]
        Asc,

        /// <summary>
        /// Desc.
        /// </summary>
        [EnumMember(Value = "desc")]
        Desc
    }
}