// <copyright file="WorkoutTableItem.cs" company="APIMatic">
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
    /// WorkoutTableItem.
    /// </summary>
    public class WorkoutTableItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutTableItem"/> class.
        /// </summary>
        public WorkoutTableItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutTableItem"/> class.
        /// </summary>
        /// <param name="workoutId">workoutId.</param>
        /// <param name="originalWorkoutId">originalWorkoutId.</param>
        /// <param name="workoutTitle">workoutTitle.</param>
        /// <param name="workoutSlug">workoutSlug.</param>
        /// <param name="workoutImage">workoutImage.</param>
        /// <param name="isBookmark">isBookmark.</param>
        /// <param name="creatorCredits">creatorCredits.</param>
        /// <param name="primaryMuscleGroups">primaryMuscleGroups.</param>
        /// <param name="equipmentList">equipmentList.</param>
        /// <param name="secondaryMuscleGroups">secondaryMuscleGroups.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="lastViewedAt">lastViewedAt.</param>
        /// <param name="tags">tags.</param>
        /// <param name="workoutSummary">workoutSummary.</param>
        /// <param name="workoutAnalytics">workoutAnalytics.</param>
        public WorkoutTableItem(
            Guid? workoutId = null,
            Guid? originalWorkoutId = null,
            string workoutTitle = null,
            string workoutSlug = null,
            Models.MediaAsset workoutImage = null,
            bool? isBookmark = null,
            List<Models.CreatorCredit> creatorCredits = null,
            List<string> primaryMuscleGroups = null,
            List<string> equipmentList = null,
            List<string> secondaryMuscleGroups = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            DateTime? lastViewedAt = null,
            List<string> tags = null,
            Models.WorkoutSummary workoutSummary = null,
            Models.WorkoutAnalytics workoutAnalytics = null)
        {
            this.WorkoutId = workoutId;
            this.OriginalWorkoutId = originalWorkoutId;
            this.WorkoutTitle = workoutTitle;
            this.WorkoutSlug = workoutSlug;
            this.WorkoutImage = workoutImage;
            this.IsBookmark = isBookmark;
            this.CreatorCredits = creatorCredits;
            this.PrimaryMuscleGroups = primaryMuscleGroups;
            this.EquipmentList = equipmentList;
            this.SecondaryMuscleGroups = secondaryMuscleGroups;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastViewedAt = lastViewedAt;
            this.Tags = tags;
            this.WorkoutSummary = workoutSummary;
            this.WorkoutAnalytics = workoutAnalytics;
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
        /// Gets or sets WorkoutImage.
        /// </summary>
        [JsonProperty("workoutImage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset WorkoutImage { get; set; }

        /// <summary>
        /// Indicates if the workout is a user's own workout or a bookmarked one from another user.
        /// </summary>
        [JsonProperty("isBookmark", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBookmark { get; set; }

        /// <summary>
        /// List of creator credits associated with this workout.
        /// </summary>
        [JsonProperty("creatorCredits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreatorCredit> CreatorCredits { get; set; }

        /// <summary>
        /// List of primary muscle group codes targeted in the workout.
        /// </summary>
        [JsonProperty("primaryMuscleGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrimaryMuscleGroups { get; set; }

        /// <summary>
        /// List of equipment codes used in the workout.
        /// </summary>
        [JsonProperty("equipmentList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EquipmentList { get; set; }

        /// <summary>
        /// List of secondary muscles targeted in the workout.
        /// </summary>
        [JsonProperty("secondaryMuscleGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecondaryMuscleGroups { get; set; }

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
        /// NOT IMPLEMENTED:- TODO- List of tags associated with the workout.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WorkoutTableItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is WorkoutTableItem other &&                ((this.WorkoutId == null && other.WorkoutId == null) || (this.WorkoutId?.Equals(other.WorkoutId) == true)) &&
                ((this.OriginalWorkoutId == null && other.OriginalWorkoutId == null) || (this.OriginalWorkoutId?.Equals(other.OriginalWorkoutId) == true)) &&
                ((this.WorkoutTitle == null && other.WorkoutTitle == null) || (this.WorkoutTitle?.Equals(other.WorkoutTitle) == true)) &&
                ((this.WorkoutSlug == null && other.WorkoutSlug == null) || (this.WorkoutSlug?.Equals(other.WorkoutSlug) == true)) &&
                ((this.WorkoutImage == null && other.WorkoutImage == null) || (this.WorkoutImage?.Equals(other.WorkoutImage) == true)) &&
                ((this.IsBookmark == null && other.IsBookmark == null) || (this.IsBookmark?.Equals(other.IsBookmark) == true)) &&
                ((this.CreatorCredits == null && other.CreatorCredits == null) || (this.CreatorCredits?.Equals(other.CreatorCredits) == true)) &&
                ((this.PrimaryMuscleGroups == null && other.PrimaryMuscleGroups == null) || (this.PrimaryMuscleGroups?.Equals(other.PrimaryMuscleGroups) == true)) &&
                ((this.EquipmentList == null && other.EquipmentList == null) || (this.EquipmentList?.Equals(other.EquipmentList) == true)) &&
                ((this.SecondaryMuscleGroups == null && other.SecondaryMuscleGroups == null) || (this.SecondaryMuscleGroups?.Equals(other.SecondaryMuscleGroups) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.LastViewedAt == null && other.LastViewedAt == null) || (this.LastViewedAt?.Equals(other.LastViewedAt) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                ((this.WorkoutSummary == null && other.WorkoutSummary == null) || (this.WorkoutSummary?.Equals(other.WorkoutSummary) == true)) &&
                ((this.WorkoutAnalytics == null && other.WorkoutAnalytics == null) || (this.WorkoutAnalytics?.Equals(other.WorkoutAnalytics) == true));
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
            toStringOutput.Add($"this.WorkoutImage = {(this.WorkoutImage == null ? "null" : this.WorkoutImage.ToString())}");
            toStringOutput.Add($"this.IsBookmark = {(this.IsBookmark == null ? "null" : this.IsBookmark.ToString())}");
            toStringOutput.Add($"this.CreatorCredits = {(this.CreatorCredits == null ? "null" : $"[{string.Join(", ", this.CreatorCredits)} ]")}");
            toStringOutput.Add($"this.PrimaryMuscleGroups = {(this.PrimaryMuscleGroups == null ? "null" : $"[{string.Join(", ", this.PrimaryMuscleGroups)} ]")}");
            toStringOutput.Add($"this.EquipmentList = {(this.EquipmentList == null ? "null" : $"[{string.Join(", ", this.EquipmentList)} ]")}");
            toStringOutput.Add($"this.SecondaryMuscleGroups = {(this.SecondaryMuscleGroups == null ? "null" : $"[{string.Join(", ", this.SecondaryMuscleGroups)} ]")}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.LastViewedAt = {(this.LastViewedAt == null ? "null" : this.LastViewedAt.ToString())}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : $"[{string.Join(", ", this.Tags)} ]")}");
            toStringOutput.Add($"this.WorkoutSummary = {(this.WorkoutSummary == null ? "null" : this.WorkoutSummary.ToString())}");
            toStringOutput.Add($"this.WorkoutAnalytics = {(this.WorkoutAnalytics == null ? "null" : this.WorkoutAnalytics.ToString())}");
        }
    }
}