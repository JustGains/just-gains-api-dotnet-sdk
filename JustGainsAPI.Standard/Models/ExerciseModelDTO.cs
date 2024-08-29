// <copyright file="ExerciseModelDTO.cs" company="APIMatic">
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
    /// ExerciseModelDTO.
    /// </summary>
    public class ExerciseModelDTO
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseModelDTO"/> class.
        /// </summary>
        public ExerciseModelDTO()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseModelDTO"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="modelName">model_name.</param>
        /// <param name="videoId">video_id.</param>
        /// <param name="videoUrl">video_url.</param>
        public ExerciseModelDTO(
            int? id = null,
            string modelName = null,
            string videoId = null,
            string videoUrl = null)
        {
            this.Id = id;
            this.ModelName = modelName;
            this.VideoId = videoId;
            this.VideoUrl = videoUrl;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets ModelName.
        /// </summary>
        [JsonProperty("model_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelName { get; set; }

        /// <summary>
        /// Gets or sets VideoId.
        /// </summary>
        [JsonProperty("video_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoId { get; set; }

        /// <summary>
        /// Gets or sets VideoUrl.
        /// </summary>
        [JsonProperty("video_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseModelDTO : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseModelDTO other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.ModelName == null && other.ModelName == null) || (this.ModelName?.Equals(other.ModelName) == true)) &&
                ((this.VideoId == null && other.VideoId == null) || (this.VideoId?.Equals(other.VideoId) == true)) &&
                ((this.VideoUrl == null && other.VideoUrl == null) || (this.VideoUrl?.Equals(other.VideoUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.ModelName = {(this.ModelName == null ? "null" : this.ModelName)}");
            toStringOutput.Add($"this.VideoId = {(this.VideoId == null ? "null" : this.VideoId)}");
            toStringOutput.Add($"this.VideoUrl = {(this.VideoUrl == null ? "null" : this.VideoUrl)}");
        }
    }
}