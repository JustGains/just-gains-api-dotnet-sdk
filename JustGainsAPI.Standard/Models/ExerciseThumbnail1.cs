// <copyright file="ExerciseThumbnail1.cs" company="APIMatic">
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
    /// ExerciseThumbnail1.
    /// </summary>
    public class ExerciseThumbnail1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseThumbnail1"/> class.
        /// </summary>
        public ExerciseThumbnail1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseThumbnail1"/> class.
        /// </summary>
        /// <param name="exerciseCode">exerciseCode.</param>
        /// <param name="userId">userId.</param>
        /// <param name="mediaAsset">mediaAsset.</param>
        public ExerciseThumbnail1(
            string exerciseCode,
            Guid userId,
            Models.MediaAsset mediaAsset)
        {
            this.ExerciseCode = exerciseCode;
            this.UserId = userId;
            this.MediaAsset = mediaAsset;
        }

        /// <summary>
        /// Unique identifier for the exercise.
        /// </summary>
        [JsonProperty("exerciseCode")]
        public string ExerciseCode { get; set; }

        /// <summary>
        /// The user ID of the user who created the thumbnail.
        /// </summary>
        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets MediaAsset.
        /// </summary>
        [JsonProperty("mediaAsset")]
        public Models.MediaAsset MediaAsset { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseThumbnail1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseThumbnail1 other &&                ((this.ExerciseCode == null && other.ExerciseCode == null) || (this.ExerciseCode?.Equals(other.ExerciseCode) == true)) &&
                this.UserId.Equals(other.UserId) &&
                ((this.MediaAsset == null && other.MediaAsset == null) || (this.MediaAsset?.Equals(other.MediaAsset) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseCode = {(this.ExerciseCode == null ? "null" : this.ExerciseCode)}");
            toStringOutput.Add($"this.UserId = {this.UserId}");
            toStringOutput.Add($"this.MediaAsset = {(this.MediaAsset == null ? "null" : this.MediaAsset.ToString())}");
        }
    }
}