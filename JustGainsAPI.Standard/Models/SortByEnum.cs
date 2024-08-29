// <copyright file="SortByEnum.cs" company="APIMatic">
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
    /// SortByEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortByEnum
    {
        /// <summary>
        /// CreatedAt.
        /// </summary>
        [EnumMember(Value = "createdAt")]
        CreatedAt,

        /// <summary>
        /// UpdatedAt.
        /// </summary>
        [EnumMember(Value = "updatedAt")]
        UpdatedAt,

        /// <summary>
        /// ProgramName.
        /// </summary>
        [EnumMember(Value = "programName")]
        ProgramName
    }
}