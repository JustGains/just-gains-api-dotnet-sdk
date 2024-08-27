// <copyright file="ExerciseGroupTypeEnum.cs" company="APIMatic">
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
    /// ExerciseGroupTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExerciseGroupTypeEnum
    {
        /// <summary>
        /// SUPERSET.
        /// </summary>
        [EnumMember(Value = "SUPERSET")]
        SUPERSET,

        /// <summary>
        /// INTERVAL.
        /// </summary>
        [EnumMember(Value = "INTERVAL")]
        INTERVAL,

        /// <summary>
        /// WARMUP.
        /// </summary>
        [EnumMember(Value = "WARMUP")]
        WARMUP,

        /// <summary>
        /// COOLDOWN.
        /// </summary>
        [EnumMember(Value = "COOLDOWN")]
        COOLDOWN,

        /// <summary>
        /// SECTION.
        /// </summary>
        [EnumMember(Value = "SECTION")]
        SECTION
    }
}