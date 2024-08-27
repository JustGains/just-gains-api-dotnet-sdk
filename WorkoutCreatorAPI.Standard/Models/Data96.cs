// <copyright file="Data96.cs" company="APIMatic">
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
    /// Data96.
    /// </summary>
    public class Data96
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data96"/> class.
        /// </summary>
        public Data96()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data96"/> class.
        /// </summary>
        /// <param name="workoutId">workoutId.</param>
        /// <param name="workoutTitle">workoutTitle.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="lastUsedAt">lastUsedAt.</param>
        /// <param name="totalUses">totalUses.</param>
        /// <param name="averageRating">averageRating.</param>
        /// <param name="creatorCredits">creatorCredits.</param>
        public Data96(
            int? workoutId = null,
            string workoutTitle = null,
            DateTime? updatedAt = null,
            DateTime? lastUsedAt = null,
            int? totalUses = 0,
            double? averageRating = null,
            List<Models.CreatorCredit> creatorCredits = null)
        {
            this.WorkoutId = workoutId;
            this.WorkoutTitle = workoutTitle;
            this.UpdatedAt = updatedAt;
            this.LastUsedAt = lastUsedAt;
            this.TotalUses = totalUses;
            this.AverageRating = averageRating;
            this.CreatorCredits = creatorCredits;
        }

        /// <summary>
        /// Unique identifier for the workout.
        /// </summary>
        [JsonProperty("workoutId", NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkoutId { get; set; }

        /// <summary>
        /// The title of the workout.
        /// </summary>
        [JsonProperty("workoutTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkoutTitle { get; set; }

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
        [JsonProperty("lastUsedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// The number of times this workout has been used.
        /// </summary>
        [JsonProperty("totalUses", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalUses { get; set; }

        /// <summary>
        /// The average rating of the workout.
        /// </summary>
        [JsonProperty("averageRating", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageRating { get; set; }

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

            return $"Data96 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data96 other &&                ((this.WorkoutId == null && other.WorkoutId == null) || (this.WorkoutId?.Equals(other.WorkoutId) == true)) &&
                ((this.WorkoutTitle == null && other.WorkoutTitle == null) || (this.WorkoutTitle?.Equals(other.WorkoutTitle) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.LastUsedAt == null && other.LastUsedAt == null) || (this.LastUsedAt?.Equals(other.LastUsedAt) == true)) &&
                ((this.TotalUses == null && other.TotalUses == null) || (this.TotalUses?.Equals(other.TotalUses) == true)) &&
                ((this.AverageRating == null && other.AverageRating == null) || (this.AverageRating?.Equals(other.AverageRating) == true)) &&
                ((this.CreatorCredits == null && other.CreatorCredits == null) || (this.CreatorCredits?.Equals(other.CreatorCredits) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WorkoutId = {(this.WorkoutId == null ? "null" : this.WorkoutId.ToString())}");
            toStringOutput.Add($"this.WorkoutTitle = {(this.WorkoutTitle == null ? "null" : this.WorkoutTitle)}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.LastUsedAt = {(this.LastUsedAt == null ? "null" : this.LastUsedAt.ToString())}");
            toStringOutput.Add($"this.TotalUses = {(this.TotalUses == null ? "null" : this.TotalUses.ToString())}");
            toStringOutput.Add($"this.AverageRating = {(this.AverageRating == null ? "null" : this.AverageRating.ToString())}");
            toStringOutput.Add($"this.CreatorCredits = {(this.CreatorCredits == null ? "null" : $"[{string.Join(", ", this.CreatorCredits)} ]")}");
        }
    }
}