// <copyright file="ExerciseListItem.cs" company="APIMatic">
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
    /// ExerciseListItem.
    /// </summary>
    public class ExerciseListItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseListItem"/> class.
        /// </summary>
        public ExerciseListItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseListItem"/> class.
        /// </summary>
        /// <param name="exerciseCode">exerciseCode.</param>
        /// <param name="exerciseName">exerciseName.</param>
        /// <param name="exerciseMuscles">exerciseMuscles.</param>
        /// <param name="exerciseThumbnail">exerciseThumbnail.</param>
        /// <param name="recentOrder">recentOrder.</param>
        /// <param name="exerciseTypeCode">exerciseTypeCode.</param>
        /// <param name="exerciseMetrics">exerciseMetrics.</param>
        public ExerciseListItem(
            string exerciseCode = null,
            string exerciseName = null,
            List<Models.ExerciseMuscle> exerciseMuscles = null,
            Models.MediaAsset exerciseThumbnail = null,
            int? recentOrder = null,
            string exerciseTypeCode = null,
            List<string> exerciseMetrics = null)
        {
            this.ExerciseCode = exerciseCode;
            this.ExerciseName = exerciseName;
            this.ExerciseMuscles = exerciseMuscles;
            this.ExerciseThumbnail = exerciseThumbnail;
            this.RecentOrder = recentOrder;
            this.ExerciseTypeCode = exerciseTypeCode;
            this.ExerciseMetrics = exerciseMetrics;
        }

        /// <summary>
        /// Unique identifier for the exercise.
        /// </summary>
        [JsonProperty("exerciseCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseCode { get; set; }

        /// <summary>
        /// Translated Primary Exercise Name for the chosen Locale
        /// </summary>
        [JsonProperty("exerciseName", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseName { get; set; }

        /// <summary>
        /// Gets or sets ExerciseMuscles.
        /// </summary>
        [JsonProperty("exerciseMuscles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ExerciseMuscle> ExerciseMuscles { get; set; }

        /// <summary>
        /// Gets or sets ExerciseThumbnail.
        /// </summary>
        [JsonProperty("exerciseThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset ExerciseThumbnail { get; set; }

        /// <summary>
        /// Used for sorting by most recently used exercises.
        /// </summary>
        [JsonProperty("recentOrder", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecentOrder { get; set; }

        /// <summary>
        /// The exerciseTypeCode of the exercise
        /// </summary>
        [JsonProperty("exerciseTypeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseTypeCode { get; set; }

        /// <summary>
        /// Array of metric codes associated with this exercise
        /// </summary>
        [JsonProperty("exerciseMetrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExerciseMetrics { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseListItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseListItem other &&                ((this.ExerciseCode == null && other.ExerciseCode == null) || (this.ExerciseCode?.Equals(other.ExerciseCode) == true)) &&
                ((this.ExerciseName == null && other.ExerciseName == null) || (this.ExerciseName?.Equals(other.ExerciseName) == true)) &&
                ((this.ExerciseMuscles == null && other.ExerciseMuscles == null) || (this.ExerciseMuscles?.Equals(other.ExerciseMuscles) == true)) &&
                ((this.ExerciseThumbnail == null && other.ExerciseThumbnail == null) || (this.ExerciseThumbnail?.Equals(other.ExerciseThumbnail) == true)) &&
                ((this.RecentOrder == null && other.RecentOrder == null) || (this.RecentOrder?.Equals(other.RecentOrder) == true)) &&
                ((this.ExerciseTypeCode == null && other.ExerciseTypeCode == null) || (this.ExerciseTypeCode?.Equals(other.ExerciseTypeCode) == true)) &&
                ((this.ExerciseMetrics == null && other.ExerciseMetrics == null) || (this.ExerciseMetrics?.Equals(other.ExerciseMetrics) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseCode = {(this.ExerciseCode == null ? "null" : this.ExerciseCode)}");
            toStringOutput.Add($"this.ExerciseName = {(this.ExerciseName == null ? "null" : this.ExerciseName)}");
            toStringOutput.Add($"this.ExerciseMuscles = {(this.ExerciseMuscles == null ? "null" : $"[{string.Join(", ", this.ExerciseMuscles)} ]")}");
            toStringOutput.Add($"this.ExerciseThumbnail = {(this.ExerciseThumbnail == null ? "null" : this.ExerciseThumbnail.ToString())}");
            toStringOutput.Add($"this.RecentOrder = {(this.RecentOrder == null ? "null" : this.RecentOrder.ToString())}");
            toStringOutput.Add($"this.ExerciseTypeCode = {(this.ExerciseTypeCode == null ? "null" : this.ExerciseTypeCode)}");
            toStringOutput.Add($"this.ExerciseMetrics = {(this.ExerciseMetrics == null ? "null" : $"[{string.Join(", ", this.ExerciseMetrics)} ]")}");
        }
    }
}