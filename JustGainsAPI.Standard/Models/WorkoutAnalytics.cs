// <copyright file="WorkoutAnalytics.cs" company="APIMatic">
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
    /// WorkoutAnalytics.
    /// </summary>
    public class WorkoutAnalytics
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutAnalytics"/> class.
        /// </summary>
        public WorkoutAnalytics()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutAnalytics"/> class.
        /// </summary>
        /// <param name="totalViews">totalViews.</param>
        /// <param name="ratingAverage">ratingAverage.</param>
        /// <param name="ratingCount">ratingCount.</param>
        public WorkoutAnalytics(
            int? totalViews = null,
            double? ratingAverage = null,
            int? ratingCount = null)
        {
            this.TotalViews = totalViews;
            this.RatingAverage = ratingAverage;
            this.RatingCount = ratingCount;
        }

        /// <summary>
        /// Number of views for the workout.
        /// </summary>
        [JsonProperty("totalViews", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalViews { get; set; }

        /// <summary>
        /// The average rating of the workout.
        /// </summary>
        [JsonProperty("ratingAverage", NullValueHandling = NullValueHandling.Ignore)]
        public double? RatingAverage { get; set; }

        /// <summary>
        /// The number of ratings for the workout.
        /// </summary>
        [JsonProperty("ratingCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? RatingCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WorkoutAnalytics : ({string.Join(", ", toStringOutput)})";
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
            return obj is WorkoutAnalytics other &&                ((this.TotalViews == null && other.TotalViews == null) || (this.TotalViews?.Equals(other.TotalViews) == true)) &&
                ((this.RatingAverage == null && other.RatingAverage == null) || (this.RatingAverage?.Equals(other.RatingAverage) == true)) &&
                ((this.RatingCount == null && other.RatingCount == null) || (this.RatingCount?.Equals(other.RatingCount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TotalViews = {(this.TotalViews == null ? "null" : this.TotalViews.ToString())}");
            toStringOutput.Add($"this.RatingAverage = {(this.RatingAverage == null ? "null" : this.RatingAverage.ToString())}");
            toStringOutput.Add($"this.RatingCount = {(this.RatingCount == null ? "null" : this.RatingCount.ToString())}");
        }
    }
}