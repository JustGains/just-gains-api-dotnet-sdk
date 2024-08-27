// <copyright file="PublishStatusEnum.cs" company="APIMatic">
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