// <copyright file="MuscleGroupType4Enum.cs" company="APIMatic">
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
    /// MuscleGroupType4Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MuscleGroupType4Enum
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
        SubGroup
    }
}