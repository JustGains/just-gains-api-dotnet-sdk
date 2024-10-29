// <copyright file="Workout.cs" company="APIMatic">
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
    /// Workout.
    /// </summary>
    public class Workout
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Workout"/> class.
        /// </summary>
        public Workout()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Workout"/> class.
        /// </summary>
        /// <param name="workoutId">workoutId.</param>
        /// <param name="originalWorkoutId">originalWorkoutId.</param>
        /// <param name="workoutTitle">workoutTitle.</param>
        /// <param name="workoutSlug">workoutSlug.</param>
        /// <param name="workoutBackgroundImage">workoutBackgroundImage.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="lastViewedAt">lastViewedAt.</param>
        /// <param name="workoutSummary">workoutSummary.</param>
        /// <param name="workoutAnalytics">workoutAnalytics.</param>
        /// <param name="creatorCredits">creatorCredits.</param>
        public Workout(
            Guid? workoutId = null,
            Guid? originalWorkoutId = null,
            string workoutTitle = null,
            string workoutSlug = null,
            Models.MediaAsset workoutBackgroundImage = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            DateTime? lastViewedAt = null,
            Models.WorkoutSummary workoutSummary = null,
            Models.WorkoutAnalytics workoutAnalytics = null,
            List<Models.CreatorCredit> creatorCredits = null)
        {
            this.WorkoutId = workoutId;
            this.OriginalWorkoutId = originalWorkoutId;
            this.WorkoutTitle = workoutTitle;
            this.WorkoutSlug = workoutSlug;
            this.WorkoutBackgroundImage = workoutBackgroundImage;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastViewedAt = lastViewedAt;
            this.WorkoutSummary = workoutSummary;
            this.WorkoutAnalytics = workoutAnalytics;
            this.CreatorCredits = creatorCredits;
        }

        /// <summary>
        /// Unique identifier for the workout.
        /// </summary>
        [JsonProperty("workoutId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? WorkoutId { get; set; }

        /// <summary>
        /// ID of the original workout if this is a duplicate.
        /// </summary>
        [JsonProperty("originalWorkoutId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OriginalWorkoutId { get; set; }

        /// <summary>
        /// The title of the workout.
        /// </summary>
        [JsonProperty("workoutTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkoutTitle { get; set; }

        /// <summary>
        /// The URL slug of the workout.
        /// </summary>
        [JsonProperty("workoutSlug", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkoutSlug { get; set; }

        /// <summary>
        /// Gets or sets WorkoutBackgroundImage.
        /// </summary>
        [JsonProperty("workoutBackgroundImage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset WorkoutBackgroundImage { get; set; }

        /// <summary>
        /// The date and time when the workout was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the workout was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The date and time when the workout was last used.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastViewedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastViewedAt { get; set; }

        /// <summary>
        /// Summary information about the workout.
        /// </summary>
        [JsonProperty("workoutSummary", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WorkoutSummary WorkoutSummary { get; set; }

        /// <summary>
        /// Analytics data for the workout.
        /// </summary>
        [JsonProperty("workoutAnalytics", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WorkoutAnalytics WorkoutAnalytics { get; set; }

        /// <summary>
        /// List of creator credits associated with this workout.
        /// </summary>
        [JsonProperty("creatorCredits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreatorCredit> CreatorCredits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Workout : ({string.Join(", ", toStringOutput)})";
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
            return obj is Workout other &&                ((this.WorkoutId == null && other.WorkoutId == null) || (this.WorkoutId?.Equals(other.WorkoutId) == true)) &&
                ((this.OriginalWorkoutId == null && other.OriginalWorkoutId == null) || (this.OriginalWorkoutId?.Equals(other.OriginalWorkoutId) == true)) &&
                ((this.WorkoutTitle == null && other.WorkoutTitle == null) || (this.WorkoutTitle?.Equals(other.WorkoutTitle) == true)) &&
                ((this.WorkoutSlug == null && other.WorkoutSlug == null) || (this.WorkoutSlug?.Equals(other.WorkoutSlug) == true)) &&
                ((this.WorkoutBackgroundImage == null && other.WorkoutBackgroundImage == null) || (this.WorkoutBackgroundImage?.Equals(other.WorkoutBackgroundImage) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.LastViewedAt == null && other.LastViewedAt == null) || (this.LastViewedAt?.Equals(other.LastViewedAt) == true)) &&
                ((this.WorkoutSummary == null && other.WorkoutSummary == null) || (this.WorkoutSummary?.Equals(other.WorkoutSummary) == true)) &&
                ((this.WorkoutAnalytics == null && other.WorkoutAnalytics == null) || (this.WorkoutAnalytics?.Equals(other.WorkoutAnalytics) == true)) &&
                ((this.CreatorCredits == null && other.CreatorCredits == null) || (this.CreatorCredits?.Equals(other.CreatorCredits) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WorkoutId = {(this.WorkoutId == null ? "null" : this.WorkoutId.ToString())}");
            toStringOutput.Add($"this.OriginalWorkoutId = {(this.OriginalWorkoutId == null ? "null" : this.OriginalWorkoutId.ToString())}");
            toStringOutput.Add($"this.WorkoutTitle = {(this.WorkoutTitle == null ? "null" : this.WorkoutTitle)}");
            toStringOutput.Add($"this.WorkoutSlug = {(this.WorkoutSlug == null ? "null" : this.WorkoutSlug)}");
            toStringOutput.Add($"this.WorkoutBackgroundImage = {(this.WorkoutBackgroundImage == null ? "null" : this.WorkoutBackgroundImage.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.LastViewedAt = {(this.LastViewedAt == null ? "null" : this.LastViewedAt.ToString())}");
            toStringOutput.Add($"this.WorkoutSummary = {(this.WorkoutSummary == null ? "null" : this.WorkoutSummary.ToString())}");
            toStringOutput.Add($"this.WorkoutAnalytics = {(this.WorkoutAnalytics == null ? "null" : this.WorkoutAnalytics.ToString())}");
            toStringOutput.Add($"this.CreatorCredits = {(this.CreatorCredits == null ? "null" : $"[{string.Join(", ", this.CreatorCredits)} ]")}");
        }
    }
}