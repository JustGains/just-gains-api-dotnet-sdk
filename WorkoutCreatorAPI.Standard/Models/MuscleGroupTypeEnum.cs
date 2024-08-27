// <copyright file="MuscleGroupTypeEnum.cs" company="APIMatic">
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
        /// SubGroup.
        /// </summary>
        [EnumMember(Value = "sub_group")]
        SubGroup,

        /// <summary>
        /// ExerciseGroup.
        /// </summary>
        [EnumMember(Value = "exercise_group")]
        ExerciseGroup
    }
}