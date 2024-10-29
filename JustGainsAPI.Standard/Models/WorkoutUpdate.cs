// <copyright file="WorkoutUpdate.cs" company="APIMatic">
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
    /// WorkoutUpdate.
    /// </summary>
    public class WorkoutUpdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutUpdate"/> class.
        /// </summary>
        public WorkoutUpdate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutUpdate"/> class.
        /// </summary>
        /// <param name="workoutTitle">workoutTitle.</param>
        /// <param name="workoutBackgroundImage">workoutBackgroundImage.</param>
        /// <param name="workoutSlug">workoutSlug.</param>
        /// <param name="tags">tags.</param>
        public WorkoutUpdate(
            string workoutTitle = null,
            Models.MediaAsset workoutBackgroundImage = null,
            string workoutSlug = null,
            List<string> tags = null)
        {
            this.WorkoutTitle = workoutTitle;
            this.WorkoutBackgroundImage = workoutBackgroundImage;
            this.WorkoutSlug = workoutSlug;
            this.Tags = tags;
        }

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
        /// The URL slug of the workout.
        /// </summary>
        [JsonProperty("workoutSlug", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkoutSlug { get; set; }

        /// <summary>
        /// (NOT IMPLEMENTED) List of tags associated with the workout.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WorkoutUpdate : ({string.Join(", ", toStringOutput)})";
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
            return obj is WorkoutUpdate other &&                ((this.WorkoutTitle == null && other.WorkoutTitle == null) || (this.WorkoutTitle?.Equals(other.WorkoutTitle) == true)) &&
                ((this.WorkoutBackgroundImage == null && other.WorkoutBackgroundImage == null) || (this.WorkoutBackgroundImage?.Equals(other.WorkoutBackgroundImage) == true)) &&
                ((this.WorkoutSlug == null && other.WorkoutSlug == null) || (this.WorkoutSlug?.Equals(other.WorkoutSlug) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WorkoutTitle = {(this.WorkoutTitle == null ? "null" : this.WorkoutTitle)}");
            toStringOutput.Add($"this.WorkoutBackgroundImage = {(this.WorkoutBackgroundImage == null ? "null" : this.WorkoutBackgroundImage.ToString())}");
            toStringOutput.Add($"this.WorkoutSlug = {(this.WorkoutSlug == null ? "null" : this.WorkoutSlug)}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : $"[{string.Join(", ", this.Tags)} ]")}");
        }
    }
}