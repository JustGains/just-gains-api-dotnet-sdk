// <copyright file="MuscleGroupType5Enum.cs" company="APIMatic">
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
    /// MuscleGroupType5Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MuscleGroupType5Enum
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