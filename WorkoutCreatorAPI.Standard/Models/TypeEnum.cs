// <copyright file="TypeEnum.cs" company="APIMatic">
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
    /// TypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Paragraph.
        /// </summary>
        [EnumMember(Value = "paragraph")]
        Paragraph,

        /// <summary>
        /// Delimiter.
        /// </summary>
        [EnumMember(Value = "delimiter")]
        Delimiter
    }
}