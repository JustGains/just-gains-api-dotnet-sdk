// <copyright file="ExerciseType.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JustGainsAPI.Standard.Models
{
    /// <summary>
    /// ExerciseType.
    /// </summary>
    public class ExerciseType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseType"/> class.
        /// </summary>
        public ExerciseType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseType"/> class.
        /// </summary>
        /// <param name="exerciseTypeCode">exerciseTypeCode.</param>
        /// <param name="exerciseTypeName">exerciseTypeName.</param>
        /// <param name="exerciseTypeExerciseMetrics">exerciseTypeExerciseMetrics.</param>
        public ExerciseType(
            string exerciseTypeCode = null,
            string exerciseTypeName = null,
            List<string> exerciseTypeExerciseMetrics = null)
        {
            this.ExerciseTypeCode = exerciseTypeCode;
            this.ExerciseTypeName = exerciseTypeName;
            this.ExerciseTypeExerciseMetrics = exerciseTypeExerciseMetrics;
        }

        /// <summary>
        /// A unique identifier for the exercise type.
        /// </summary>
        [JsonProperty("exerciseTypeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseTypeCode { get; set; }

        /// <summary>
        /// The name of the exercise type.
        /// </summary>
        [JsonProperty("exerciseTypeName", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseTypeName { get; set; }

        /// <summary>
        /// An array of metric codes associated with this exercise type. These metrics are used to measure and track performance for exercises of this type.
        /// </summary>
        [JsonProperty("exerciseTypeExerciseMetrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExerciseTypeExerciseMetrics { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseType : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ExerciseType other &&                ((this.ExerciseTypeCode == null && other.ExerciseTypeCode == null) || (this.ExerciseTypeCode?.Equals(other.ExerciseTypeCode) == true)) &&
                ((this.ExerciseTypeName == null && other.ExerciseTypeName == null) || (this.ExerciseTypeName?.Equals(other.ExerciseTypeName) == true)) &&
                ((this.ExerciseTypeExerciseMetrics == null && other.ExerciseTypeExerciseMetrics == null) || (this.ExerciseTypeExerciseMetrics?.Equals(other.ExerciseTypeExerciseMetrics) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseTypeCode = {(this.ExerciseTypeCode == null ? "null" : this.ExerciseTypeCode)}");
            toStringOutput.Add($"this.ExerciseTypeName = {(this.ExerciseTypeName == null ? "null" : this.ExerciseTypeName)}");
            toStringOutput.Add($"this.ExerciseTypeExerciseMetrics = {(this.ExerciseTypeExerciseMetrics == null ? "null" : $"[{string.Join(", ", this.ExerciseTypeExerciseMetrics)} ]")}");
        }
    }
}