// <copyright file="SortBy1Enum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using WorkoutCreatorAPI.Standard;
using WorkoutCreatorAPI.Standard.Utilities;

namespace WorkoutCreatorAPI.Standard.Models
{
    /// <summary>
    /// SortBy1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortBy1Enum
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
        /// Title.
        /// </summary>
        [EnumMember(Value = "title")]
        Title
    }
}