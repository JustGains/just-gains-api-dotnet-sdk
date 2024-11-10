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
        /// <param name="exerciseTypeCode">exerciseTypeCode.</param>
        /// <param name="exerciseCategories">exerciseCategories.</param>
        /// <param name="publishedStatus">publishedStatus.</param>
        /// <param name="exerciseMuscles">exerciseMuscles.</param>
        /// <param name="exerciseThumbnail">exerciseThumbnail.</param>
        /// <param name="exerciseMetrics">exerciseMetrics.</param>
        /// <param name="relatedExercises">relatedExercises.</param>
        /// <param name="recentOrder">recentOrder.</param>
        public ExerciseListItem(
            string exerciseCode = null,
            string exerciseName = null,
            string exerciseTypeCode = null,
            List<string> exerciseCategories = null,
            string publishedStatus = null,
            List<Models.ExerciseMuscle> exerciseMuscles = null,
            Models.MediaAsset exerciseThumbnail = null,
            List<string> exerciseMetrics = null,
            List<Models.RelatedExerciseListItem> relatedExercises = null,
            int? recentOrder = null)
        {
            this.ExerciseCode = exerciseCode;
            this.ExerciseName = exerciseName;
            this.ExerciseTypeCode = exerciseTypeCode;
            this.ExerciseCategories = exerciseCategories;
            this.PublishedStatus = publishedStatus;
            this.ExerciseMuscles = exerciseMuscles;
            this.ExerciseThumbnail = exerciseThumbnail;
            this.ExerciseMetrics = exerciseMetrics;
            this.RelatedExercises = relatedExercises;
            this.RecentOrder = recentOrder;
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
        /// The exerciseTypeCode of the exercise
        /// </summary>
        [JsonProperty("exerciseTypeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseTypeCode { get; set; }

        /// <summary>
        /// Array of category codes associated with this exercise
        /// </summary>
        [JsonProperty("exerciseCategories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExerciseCategories { get; set; }

        /// <summary>
        /// The publish status of the exercise
        /// </summary>
        [JsonProperty("publishedStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishedStatus { get; set; }

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
        /// Array of metric codes associated with this exercise
        /// </summary>
        [JsonProperty("exerciseMetrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExerciseMetrics { get; set; }

        /// <summary>
        /// Gets or sets RelatedExercises.
        /// </summary>
        [JsonProperty("relatedExercises", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RelatedExerciseListItem> RelatedExercises { get; set; }

        /// <summary>
        /// Used for sorting by most recently used exercises.
        /// </summary>
        [JsonProperty("recentOrder", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecentOrder { get; set; }

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
                ((this.ExerciseTypeCode == null && other.ExerciseTypeCode == null) || (this.ExerciseTypeCode?.Equals(other.ExerciseTypeCode) == true)) &&
                ((this.ExerciseCategories == null && other.ExerciseCategories == null) || (this.ExerciseCategories?.Equals(other.ExerciseCategories) == true)) &&
                ((this.PublishedStatus == null && other.PublishedStatus == null) || (this.PublishedStatus?.Equals(other.PublishedStatus) == true)) &&
                ((this.ExerciseMuscles == null && other.ExerciseMuscles == null) || (this.ExerciseMuscles?.Equals(other.ExerciseMuscles) == true)) &&
                ((this.ExerciseThumbnail == null && other.ExerciseThumbnail == null) || (this.ExerciseThumbnail?.Equals(other.ExerciseThumbnail) == true)) &&
                ((this.ExerciseMetrics == null && other.ExerciseMetrics == null) || (this.ExerciseMetrics?.Equals(other.ExerciseMetrics) == true)) &&
                ((this.RelatedExercises == null && other.RelatedExercises == null) || (this.RelatedExercises?.Equals(other.RelatedExercises) == true)) &&
                ((this.RecentOrder == null && other.RecentOrder == null) || (this.RecentOrder?.Equals(other.RecentOrder) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseCode = {(this.ExerciseCode == null ? "null" : this.ExerciseCode)}");
            toStringOutput.Add($"this.ExerciseName = {(this.ExerciseName == null ? "null" : this.ExerciseName)}");
            toStringOutput.Add($"this.ExerciseTypeCode = {(this.ExerciseTypeCode == null ? "null" : this.ExerciseTypeCode)}");
            toStringOutput.Add($"this.ExerciseCategories = {(this.ExerciseCategories == null ? "null" : $"[{string.Join(", ", this.ExerciseCategories)} ]")}");
            toStringOutput.Add($"this.PublishedStatus = {(this.PublishedStatus == null ? "null" : this.PublishedStatus)}");
            toStringOutput.Add($"this.ExerciseMuscles = {(this.ExerciseMuscles == null ? "null" : $"[{string.Join(", ", this.ExerciseMuscles)} ]")}");
            toStringOutput.Add($"this.ExerciseThumbnail = {(this.ExerciseThumbnail == null ? "null" : this.ExerciseThumbnail.ToString())}");
            toStringOutput.Add($"this.ExerciseMetrics = {(this.ExerciseMetrics == null ? "null" : $"[{string.Join(", ", this.ExerciseMetrics)} ]")}");
            toStringOutput.Add($"this.RelatedExercises = {(this.RelatedExercises == null ? "null" : $"[{string.Join(", ", this.RelatedExercises)} ]")}");
            toStringOutput.Add($"this.RecentOrder = {(this.RecentOrder == null ? "null" : this.RecentOrder.ToString())}");
        }
    }
}