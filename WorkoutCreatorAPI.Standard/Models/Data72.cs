// <copyright file="Data72.cs" company="APIMatic">
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
    /// Data72.
    /// </summary>
    public class Data72
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data72"/> class.
        /// </summary>
        public Data72()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data72"/> class.
        /// </summary>
        /// <param name="analyticsId">analyticsId.</param>
        /// <param name="programId">programId.</param>
        /// <param name="startCount">startCount.</param>
        /// <param name="completionCount">completionCount.</param>
        /// <param name="averageRating">averageRating.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        public Data72(
            int? analyticsId = null,
            int? programId = null,
            int? startCount = null,
            int? completionCount = null,
            double? averageRating = null,
            DateTime? lastUpdated = null)
        {
            this.AnalyticsId = analyticsId;
            this.ProgramId = programId;
            this.StartCount = startCount;
            this.CompletionCount = completionCount;
            this.AverageRating = averageRating;
            this.LastUpdated = lastUpdated;
        }

        /// <summary>
        /// Unique identifier for this analytics entry.
        /// </summary>
        [JsonProperty("analyticsId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AnalyticsId { get; set; }

        /// <summary>
        /// Identifier of the program these analytics belong to.
        /// </summary>
        [JsonProperty("programId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProgramId { get; set; }

        /// <summary>
        /// Number of times the program has been started by users.
        /// </summary>
        [JsonProperty("startCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartCount { get; set; }

        /// <summary>
        /// Number of times the program has been completed by users.
        /// </summary>
        [JsonProperty("completionCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompletionCount { get; set; }

        /// <summary>
        /// Average rating of the program (typically out of 5).
        /// </summary>
        [JsonProperty("averageRating", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageRating { get; set; }

        /// <summary>
        /// Timestamp of when these analytics were last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastUpdated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastUpdated { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data72 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data72 other &&                ((this.AnalyticsId == null && other.AnalyticsId == null) || (this.AnalyticsId?.Equals(other.AnalyticsId) == true)) &&
                ((this.ProgramId == null && other.ProgramId == null) || (this.ProgramId?.Equals(other.ProgramId) == true)) &&
                ((this.StartCount == null && other.StartCount == null) || (this.StartCount?.Equals(other.StartCount) == true)) &&
                ((this.CompletionCount == null && other.CompletionCount == null) || (this.CompletionCount?.Equals(other.CompletionCount) == true)) &&
                ((this.AverageRating == null && other.AverageRating == null) || (this.AverageRating?.Equals(other.AverageRating) == true)) &&
                ((this.LastUpdated == null && other.LastUpdated == null) || (this.LastUpdated?.Equals(other.LastUpdated) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AnalyticsId = {(this.AnalyticsId == null ? "null" : this.AnalyticsId.ToString())}");
            toStringOutput.Add($"this.ProgramId = {(this.ProgramId == null ? "null" : this.ProgramId.ToString())}");
            toStringOutput.Add($"this.StartCount = {(this.StartCount == null ? "null" : this.StartCount.ToString())}");
            toStringOutput.Add($"this.CompletionCount = {(this.CompletionCount == null ? "null" : this.CompletionCount.ToString())}");
            toStringOutput.Add($"this.AverageRating = {(this.AverageRating == null ? "null" : this.AverageRating.ToString())}");
            toStringOutput.Add($"this.LastUpdated = {(this.LastUpdated == null ? "null" : this.LastUpdated.ToString())}");
        }
    }
}