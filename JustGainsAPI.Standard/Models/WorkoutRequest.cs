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
        /// <param name="workoutBackgroundImage">workoutBackgroundImage.</param>
        /// <param name="workoutContent">workoutContent.</param>
        /// <param name="workoutData">workoutData.</param>
        /// <param name="creatorCredits">creatorCredits.</param>
        public WorkoutRequest(
            string workoutTitle = null,
            Models.MediaAsset workoutBackgroundImage = null,
            object workoutContent = null,
            List<Models.WorkoutData> workoutData = null,
            List<Models.CreatorCredit> creatorCredits = null)
        {
            this.WorkoutTitle = workoutTitle;
            this.WorkoutBackgroundImage = workoutBackgroundImage;
            this.WorkoutContent = workoutContent;
            this.WorkoutData = workoutData;
            this.CreatorCredits = creatorCredits;
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
        /// The content of the workout (JSON formatted output from the JS Editor)
        /// </summary>
        [JsonProperty("workoutContent", NullValueHandling = NullValueHandling.Ignore)]
        public object WorkoutContent { get; set; }

        /// <summary>
        /// Gets or sets WorkoutData.
        /// </summary>
        [JsonProperty("workoutData", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.WorkoutData> WorkoutData { get; set; }

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
                ((this.WorkoutBackgroundImage == null && other.WorkoutBackgroundImage == null) || (this.WorkoutBackgroundImage?.Equals(other.WorkoutBackgroundImage) == true)) &&
                ((this.WorkoutContent == null && other.WorkoutContent == null) || (this.WorkoutContent?.Equals(other.WorkoutContent) == true)) &&
                ((this.WorkoutData == null && other.WorkoutData == null) || (this.WorkoutData?.Equals(other.WorkoutData) == true)) &&
                ((this.CreatorCredits == null && other.CreatorCredits == null) || (this.CreatorCredits?.Equals(other.CreatorCredits) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WorkoutTitle = {(this.WorkoutTitle == null ? "null" : this.WorkoutTitle)}");
            toStringOutput.Add($"this.WorkoutBackgroundImage = {(this.WorkoutBackgroundImage == null ? "null" : this.WorkoutBackgroundImage.ToString())}");
            toStringOutput.Add($"WorkoutContent = {(this.WorkoutContent == null ? "null" : this.WorkoutContent.ToString())}");
            toStringOutput.Add($"this.WorkoutData = {(this.WorkoutData == null ? "null" : $"[{string.Join(", ", this.WorkoutData)} ]")}");
            toStringOutput.Add($"this.CreatorCredits = {(this.CreatorCredits == null ? "null" : $"[{string.Join(", ", this.CreatorCredits)} ]")}");
        }
    }
}