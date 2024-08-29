// <copyright file="ProgramAnalytics.cs" company="APIMatic">
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
    /// ProgramAnalytics.
    /// </summary>
    public class ProgramAnalytics
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramAnalytics"/> class.
        /// </summary>
        public ProgramAnalytics()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramAnalytics"/> class.
        /// </summary>
        /// <param name="analyticsId">analyticsId.</param>
        /// <param name="programId">programId.</param>
        /// <param name="startCount">startCount.</param>
        /// <param name="completionCount">completionCount.</param>
        /// <param name="averageRating">averageRating.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        public ProgramAnalytics(
            int analyticsId,
            int programId,
            int startCount,
            int completionCount,
            double averageRating,
            DateTime lastUpdated)
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
        [JsonProperty("analyticsId")]
        public int AnalyticsId { get; set; }

        /// <summary>
        /// Identifier of the program these analytics belong to.
        /// </summary>
        [JsonProperty("programId")]
        public int ProgramId { get; set; }

        /// <summary>
        /// Number of times the program has been started by users.
        /// </summary>
        [JsonProperty("startCount")]
        public int StartCount { get; set; }

        /// <summary>
        /// Number of times the program has been completed by users.
        /// </summary>
        [JsonProperty("completionCount")]
        public int CompletionCount { get; set; }

        /// <summary>
        /// Average rating of the program (typically out of 5).
        /// </summary>
        [JsonProperty("averageRating")]
        public double AverageRating { get; set; }

        /// <summary>
        /// Timestamp of when these analytics were last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProgramAnalytics : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProgramAnalytics other &&                this.AnalyticsId.Equals(other.AnalyticsId) &&
                this.ProgramId.Equals(other.ProgramId) &&
                this.StartCount.Equals(other.StartCount) &&
                this.CompletionCount.Equals(other.CompletionCount) &&
                this.AverageRating.Equals(other.AverageRating) &&
                this.LastUpdated.Equals(other.LastUpdated);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AnalyticsId = {this.AnalyticsId}");
            toStringOutput.Add($"this.ProgramId = {this.ProgramId}");
            toStringOutput.Add($"this.StartCount = {this.StartCount}");
            toStringOutput.Add($"this.CompletionCount = {this.CompletionCount}");
            toStringOutput.Add($"this.AverageRating = {this.AverageRating}");
            toStringOutput.Add($"this.LastUpdated = {this.LastUpdated}");
        }
    }
}