// <copyright file="ExerciseMuscle.cs" company="APIMatic">
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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WorkoutCreatorAPI.Standard;
using WorkoutCreatorAPI.Standard.Utilities;

namespace WorkoutCreatorAPI.Standard.Models
{
    /// <summary>
    /// ExerciseMuscle.
    /// </summary>
    public class ExerciseMuscle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMuscle"/> class.
        /// </summary>
        public ExerciseMuscle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMuscle"/> class.
        /// </summary>
        /// <param name="muscleCode">muscleCode.</param>
        /// <param name="targetPercentage">targetPercentage.</param>
        /// <param name="isPrimary">isPrimary.</param>
        public ExerciseMuscle(
            string muscleCode = null,
            int? targetPercentage = null,
            bool? isPrimary = null)
        {
            this.MuscleCode = muscleCode;
            this.TargetPercentage = targetPercentage;
            this.IsPrimary = isPrimary;
        }

        /// <summary>
        /// muscleCode that belongs to this exercise
        /// </summary>
        [JsonProperty("muscleCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleCode { get; set; }

        /// <summary>
        /// The percentage of effort targeted at this muscle in the exercise.
        /// </summary>
        [JsonProperty("targetPercentage", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetPercentage { get; set; }

        /// <summary>
        /// Indicates whether this muscle is the primary muscle used in the exercise.
        /// </summary>
        [JsonProperty("isPrimary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrimary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseMuscle : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseMuscle other &&                ((this.MuscleCode == null && other.MuscleCode == null) || (this.MuscleCode?.Equals(other.MuscleCode) == true)) &&
                ((this.TargetPercentage == null && other.TargetPercentage == null) || (this.TargetPercentage?.Equals(other.TargetPercentage) == true)) &&
                ((this.IsPrimary == null && other.IsPrimary == null) || (this.IsPrimary?.Equals(other.IsPrimary) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MuscleCode = {(this.MuscleCode == null ? "null" : this.MuscleCode)}");
            toStringOutput.Add($"this.TargetPercentage = {(this.TargetPercentage == null ? "null" : this.TargetPercentage.ToString())}");
            toStringOutput.Add($"this.IsPrimary = {(this.IsPrimary == null ? "null" : this.IsPrimary.ToString())}");
        }
    }
}