// <copyright file="WorkoutPreview.cs" company="APIMatic">
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
    /// WorkoutPreview.
    /// </summary>
    public class WorkoutPreview
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutPreview"/> class.
        /// </summary>
        public WorkoutPreview()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutPreview"/> class.
        /// </summary>
        /// <param name="workoutId">workoutId.</param>
        /// <param name="workoutTitle">workoutTitle.</param>
        /// <param name="workoutBackgroundImage">workoutBackgroundImage.</param>
        /// <param name="workoutMuscleGroupsPrimary">workoutMuscleGroupsPrimary.</param>
        /// <param name="workoutMuscleGroupsSecondary">workoutMuscleGroupsSecondary.</param>
        /// <param name="workoutEquipmentGroups">workoutEquipmentGroups.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="lastViewedAt">lastViewedAt.</param>
        /// <param name="workoutData">workoutData.</param>
        /// <param name="workoutContent">workoutContent.</param>
        /// <param name="workoutSummary">workoutSummary.</param>
        /// <param name="workoutAnalytics">workoutAnalytics.</param>
        /// <param name="creatorCredits">creatorCredits.</param>
        public WorkoutPreview(
            Guid? workoutId = null,
            string workoutTitle = null,
            Models.MediaAsset workoutBackgroundImage = null,
            List<Models.WorkoutMuscleGroupsPrimary> workoutMuscleGroupsPrimary = null,
            List<Models.WorkoutMuscleGroupsSecondary> workoutMuscleGroupsSecondary = null,
            List<Models.WorkoutEquipmentGroup> workoutEquipmentGroups = null,
            DateTime? updatedAt = null,
            DateTime? lastViewedAt = null,
            List<Models.WorkoutData> workoutData = null,
            Models.WorkoutContent workoutContent = null,
            Models.WorkoutSummary workoutSummary = null,
            Models.WorkoutAnalytics workoutAnalytics = null,
            List<Models.CreatorCredit> creatorCredits = null)
        {
            this.WorkoutId = workoutId;
            this.WorkoutTitle = workoutTitle;
            this.WorkoutBackgroundImage = workoutBackgroundImage;
            this.WorkoutMuscleGroupsPrimary = workoutMuscleGroupsPrimary;
            this.WorkoutMuscleGroupsSecondary = workoutMuscleGroupsSecondary;
            this.WorkoutEquipmentGroups = workoutEquipmentGroups;
            this.UpdatedAt = updatedAt;
            this.LastViewedAt = lastViewedAt;
            this.WorkoutData = workoutData;
            this.WorkoutContent = workoutContent;
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
        /// The title of the workout.
        /// </summary>
        [JsonProperty("workoutTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkoutTitle { get; set; }

        /// <summary>
        /// Gets or sets WorkoutBackgroundImage.
        /// </summary>
        [JsonProperty("workoutBackgroundImage", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset WorkoutBackgroundImage { get; set; }

        /// <summary>
        /// Gets or sets WorkoutMuscleGroupsPrimary.
        /// </summary>
        [JsonProperty("workoutMuscleGroupsPrimary", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.WorkoutMuscleGroupsPrimary> WorkoutMuscleGroupsPrimary { get; set; }

        /// <summary>
        /// Gets or sets WorkoutMuscleGroupsSecondary.
        /// </summary>
        [JsonProperty("workoutMuscleGroupsSecondary", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.WorkoutMuscleGroupsSecondary> WorkoutMuscleGroupsSecondary { get; set; }

        /// <summary>
        /// Gets or sets WorkoutEquipmentGroups.
        /// </summary>
        [JsonProperty("workoutEquipmentGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.WorkoutEquipmentGroup> WorkoutEquipmentGroups { get; set; }

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
        /// Gets or sets WorkoutData.
        /// </summary>
        [JsonProperty("workoutData", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.WorkoutData> WorkoutData { get; set; }

        /// <summary>
        /// Gets or sets WorkoutContent.
        /// </summary>
        [JsonProperty("workoutContent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WorkoutContent WorkoutContent { get; set; }

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

            return $"WorkoutPreview : ({string.Join(", ", toStringOutput)})";
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
            return obj is WorkoutPreview other &&                ((this.WorkoutId == null && other.WorkoutId == null) || (this.WorkoutId?.Equals(other.WorkoutId) == true)) &&
                ((this.WorkoutTitle == null && other.WorkoutTitle == null) || (this.WorkoutTitle?.Equals(other.WorkoutTitle) == true)) &&
                ((this.WorkoutBackgroundImage == null && other.WorkoutBackgroundImage == null) || (this.WorkoutBackgroundImage?.Equals(other.WorkoutBackgroundImage) == true)) &&
                ((this.WorkoutMuscleGroupsPrimary == null && other.WorkoutMuscleGroupsPrimary == null) || (this.WorkoutMuscleGroupsPrimary?.Equals(other.WorkoutMuscleGroupsPrimary) == true)) &&
                ((this.WorkoutMuscleGroupsSecondary == null && other.WorkoutMuscleGroupsSecondary == null) || (this.WorkoutMuscleGroupsSecondary?.Equals(other.WorkoutMuscleGroupsSecondary) == true)) &&
                ((this.WorkoutEquipmentGroups == null && other.WorkoutEquipmentGroups == null) || (this.WorkoutEquipmentGroups?.Equals(other.WorkoutEquipmentGroups) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.LastViewedAt == null && other.LastViewedAt == null) || (this.LastViewedAt?.Equals(other.LastViewedAt) == true)) &&
                ((this.WorkoutData == null && other.WorkoutData == null) || (this.WorkoutData?.Equals(other.WorkoutData) == true)) &&
                ((this.WorkoutContent == null && other.WorkoutContent == null) || (this.WorkoutContent?.Equals(other.WorkoutContent) == true)) &&
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
            toStringOutput.Add($"this.WorkoutTitle = {(this.WorkoutTitle == null ? "null" : this.WorkoutTitle)}");
            toStringOutput.Add($"this.WorkoutBackgroundImage = {(this.WorkoutBackgroundImage == null ? "null" : this.WorkoutBackgroundImage.ToString())}");
            toStringOutput.Add($"this.WorkoutMuscleGroupsPrimary = {(this.WorkoutMuscleGroupsPrimary == null ? "null" : $"[{string.Join(", ", this.WorkoutMuscleGroupsPrimary)} ]")}");
            toStringOutput.Add($"this.WorkoutMuscleGroupsSecondary = {(this.WorkoutMuscleGroupsSecondary == null ? "null" : $"[{string.Join(", ", this.WorkoutMuscleGroupsSecondary)} ]")}");
            toStringOutput.Add($"this.WorkoutEquipmentGroups = {(this.WorkoutEquipmentGroups == null ? "null" : $"[{string.Join(", ", this.WorkoutEquipmentGroups)} ]")}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.LastViewedAt = {(this.LastViewedAt == null ? "null" : this.LastViewedAt.ToString())}");
            toStringOutput.Add($"this.WorkoutData = {(this.WorkoutData == null ? "null" : $"[{string.Join(", ", this.WorkoutData)} ]")}");
            toStringOutput.Add($"this.WorkoutContent = {(this.WorkoutContent == null ? "null" : this.WorkoutContent.ToString())}");
            toStringOutput.Add($"this.WorkoutSummary = {(this.WorkoutSummary == null ? "null" : this.WorkoutSummary.ToString())}");
            toStringOutput.Add($"this.WorkoutAnalytics = {(this.WorkoutAnalytics == null ? "null" : this.WorkoutAnalytics.ToString())}");
            toStringOutput.Add($"this.CreatorCredits = {(this.CreatorCredits == null ? "null" : $"[{string.Join(", ", this.CreatorCredits)} ]")}");
        }
    }
}