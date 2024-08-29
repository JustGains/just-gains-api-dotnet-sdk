// <copyright file="MuscleGroupTypeEnum.cs" company="APIMatic">
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
    /// MuscleGroupTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MuscleGroupTypeEnum
    {
        /// <summary>
        /// MainGroup.
        /// </summary>
        [EnumMember(Value = "main_group")]
        MainGroup,

        /// <summary>
        /// Subgroup.
        /// </summary>
        [EnumMember(Value = "subgroup")]
        Subgroup,

        /// <summary>
        /// ExerciseGroup.
        /// </summary>
        [EnumMember(Value = "exercise_group")]
        ExerciseGroup
    }
}