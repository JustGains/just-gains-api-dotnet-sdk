// <copyright file="ExerciseVideo.cs" company="APIMatic">
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
    /// ExerciseVideo.
    /// </summary>
    public class ExerciseVideo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseVideo"/> class.
        /// </summary>
        public ExerciseVideo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseVideo"/> class.
        /// </summary>
        /// <param name="exerciseCode">exerciseCode.</param>
        /// <param name="userId">userId.</param>
        /// <param name="mediaElement">mediaElement.</param>
        /// <param name="sortOrder">sortOrder.</param>
        public ExerciseVideo(
            string exerciseCode = null,
            Guid? userId = null,
            Models.MediaAsset mediaElement = null,
            int? sortOrder = null)
        {
            this.ExerciseCode = exerciseCode;
            this.UserId = userId;
            this.MediaElement = mediaElement;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Unique identifier for the exercise.
        /// </summary>
        [JsonProperty("exerciseCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseCode { get; set; }

        /// <summary>
        /// The user ID of the user who created the exercise.
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Gets or sets MediaElement.
        /// </summary>
        [JsonProperty("mediaElement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset MediaElement { get; set; }

        /// <summary>
        /// The order in which the video should be displayed.
        /// </summary>
        [JsonProperty("sortOrder", NullValueHandling = NullValueHandling.Ignore)]
        public int? SortOrder { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseVideo : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseVideo other &&                ((this.ExerciseCode == null && other.ExerciseCode == null) || (this.ExerciseCode?.Equals(other.ExerciseCode) == true)) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.MediaElement == null && other.MediaElement == null) || (this.MediaElement?.Equals(other.MediaElement) == true)) &&
                ((this.SortOrder == null && other.SortOrder == null) || (this.SortOrder?.Equals(other.SortOrder) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseCode = {(this.ExerciseCode == null ? "null" : this.ExerciseCode)}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId.ToString())}");
            toStringOutput.Add($"this.MediaElement = {(this.MediaElement == null ? "null" : this.MediaElement.ToString())}");
            toStringOutput.Add($"this.SortOrder = {(this.SortOrder == null ? "null" : this.SortOrder.ToString())}");
        }
    }
}