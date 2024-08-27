// <copyright file="WorkoutSummary.cs" company="APIMatic">
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
    /// WorkoutSummary.
    /// </summary>
    public class WorkoutSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutSummary"/> class.
        /// </summary>
        public WorkoutSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutSummary"/> class.
        /// </summary>
        /// <param name="totalReps">totalReps.</param>
        /// <param name="totalSets">totalSets.</param>
        /// <param name="totalVolume">totalVolume.</param>
        /// <param name="totalDistance">totalDistance.</param>
        /// <param name="estimatedDuration">estimatedDuration.</param>
        /// <param name="exerciseCount">exerciseCount.</param>
        public WorkoutSummary(
            int? totalReps = null,
            int? totalSets = null,
            double? totalVolume = null,
            double? totalDistance = null,
            int? estimatedDuration = null,
            int? exerciseCount = null)
        {
            this.TotalReps = totalReps;
            this.TotalSets = totalSets;
            this.TotalVolume = totalVolume;
            this.TotalDistance = totalDistance;
            this.EstimatedDuration = estimatedDuration;
            this.ExerciseCount = exerciseCount;
        }

        /// <summary>
        /// Total number of repetitions across all exercises in the workout.
        /// </summary>
        [JsonProperty("totalReps", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalReps { get; set; }

        /// <summary>
        /// Total number of sets across all exercises in the workout.
        /// </summary>
        [JsonProperty("totalSets", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalSets { get; set; }

        /// <summary>
        /// Total volume (weight * reps) across all exercises in the workout.
        /// </summary>
        [JsonProperty("totalVolume", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalVolume { get; set; }

        /// <summary>
        /// Total distance covered in the workout, if applicable.
        /// </summary>
        [JsonProperty("totalDistance", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalDistance { get; set; }

        /// <summary>
        /// Estimated duration of the workout in minutes.
        /// </summary>
        [JsonProperty("estimatedDuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? EstimatedDuration { get; set; }

        /// <summary>
        /// Number of exercises in the workout.
        /// </summary>
        [JsonProperty("exerciseCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExerciseCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WorkoutSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is WorkoutSummary other &&                ((this.TotalReps == null && other.TotalReps == null) || (this.TotalReps?.Equals(other.TotalReps) == true)) &&
                ((this.TotalSets == null && other.TotalSets == null) || (this.TotalSets?.Equals(other.TotalSets) == true)) &&
                ((this.TotalVolume == null && other.TotalVolume == null) || (this.TotalVolume?.Equals(other.TotalVolume) == true)) &&
                ((this.TotalDistance == null && other.TotalDistance == null) || (this.TotalDistance?.Equals(other.TotalDistance) == true)) &&
                ((this.EstimatedDuration == null && other.EstimatedDuration == null) || (this.EstimatedDuration?.Equals(other.EstimatedDuration) == true)) &&
                ((this.ExerciseCount == null && other.ExerciseCount == null) || (this.ExerciseCount?.Equals(other.ExerciseCount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TotalReps = {(this.TotalReps == null ? "null" : this.TotalReps.ToString())}");
            toStringOutput.Add($"this.TotalSets = {(this.TotalSets == null ? "null" : this.TotalSets.ToString())}");
            toStringOutput.Add($"this.TotalVolume = {(this.TotalVolume == null ? "null" : this.TotalVolume.ToString())}");
            toStringOutput.Add($"this.TotalDistance = {(this.TotalDistance == null ? "null" : this.TotalDistance.ToString())}");
            toStringOutput.Add($"this.EstimatedDuration = {(this.EstimatedDuration == null ? "null" : this.EstimatedDuration.ToString())}");
            toStringOutput.Add($"this.ExerciseCount = {(this.ExerciseCount == null ? "null" : this.ExerciseCount.ToString())}");
        }
    }
}