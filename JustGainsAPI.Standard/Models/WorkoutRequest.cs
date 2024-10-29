// <copyright file="WorkoutRequest.cs" company="APIMatic">
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
    /// WorkoutRequest.
    /// </summary>
    public class WorkoutRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutRequest"/> class.
        /// </summary>
        public WorkoutRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutRequest"/> class.
        /// </summary>
        /// <param name="workoutTitle">workoutTitle.</param>
        /// <param name="workoutSlug">workoutSlug.</param>
        /// <param name="workoutBackgroundImage">workoutBackgroundImage.</param>
        /// <param name="creatorCredits">creatorCredits.</param>
        public WorkoutRequest(
            string workoutTitle = null,
            string workoutSlug = null,
            Models.MediaAsset workoutBackgroundImage = null,
            List<Models.CreatorCredit> creatorCredits = null)
        {
            this.WorkoutTitle = workoutTitle;
            this.WorkoutSlug = workoutSlug;
            this.WorkoutBackgroundImage = workoutBackgroundImage;
            this.CreatorCredits = creatorCredits;
        }

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
        /// List of creator credits associated with this workout.
        /// </summary>
        [JsonProperty("creatorCredits", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreatorCredit> CreatorCredits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WorkoutRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is WorkoutRequest other &&                ((this.WorkoutTitle == null && other.WorkoutTitle == null) || (this.WorkoutTitle?.Equals(other.WorkoutTitle) == true)) &&
                ((this.WorkoutSlug == null && other.WorkoutSlug == null) || (this.WorkoutSlug?.Equals(other.WorkoutSlug) == true)) &&
                ((this.WorkoutBackgroundImage == null && other.WorkoutBackgroundImage == null) || (this.WorkoutBackgroundImage?.Equals(other.WorkoutBackgroundImage) == true)) &&
                ((this.CreatorCredits == null && other.CreatorCredits == null) || (this.CreatorCredits?.Equals(other.CreatorCredits) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WorkoutTitle = {(this.WorkoutTitle == null ? "null" : this.WorkoutTitle)}");
            toStringOutput.Add($"this.WorkoutSlug = {(this.WorkoutSlug == null ? "null" : this.WorkoutSlug)}");
            toStringOutput.Add($"this.WorkoutBackgroundImage = {(this.WorkoutBackgroundImage == null ? "null" : this.WorkoutBackgroundImage.ToString())}");
            toStringOutput.Add($"this.CreatorCredits = {(this.CreatorCredits == null ? "null" : $"[{string.Join(", ", this.CreatorCredits)} ]")}");
        }
    }
}