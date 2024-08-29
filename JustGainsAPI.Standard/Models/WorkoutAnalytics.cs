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
        /// <param name="views">views.</param>
        /// <param name="totalUses">totalUses.</param>
        /// <param name="averageRating">averageRating.</param>
        public WorkoutAnalytics(
            int? views = null,
            int? totalUses = 0,
            double? averageRating = null)
        {
            this.Views = views;
            this.TotalUses = totalUses;
            this.AverageRating = averageRating;
        }

        /// <summary>
        /// Number of views for the workout.
        /// </summary>
        [JsonProperty("views", NullValueHandling = NullValueHandling.Ignore)]
        public int? Views { get; set; }

        /// <summary>
        /// The number of times this workout has been used.
        /// </summary>
        [JsonProperty("totalUses", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalUses { get; set; }

        /// <summary>
        /// The average rating of the workout.
        /// </summary>
        [JsonProperty("averageRating", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageRating { get; set; }

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
            return obj is WorkoutAnalytics other &&                ((this.Views == null && other.Views == null) || (this.Views?.Equals(other.Views) == true)) &&
                ((this.TotalUses == null && other.TotalUses == null) || (this.TotalUses?.Equals(other.TotalUses) == true)) &&
                ((this.AverageRating == null && other.AverageRating == null) || (this.AverageRating?.Equals(other.AverageRating) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Views = {(this.Views == null ? "null" : this.Views.ToString())}");
            toStringOutput.Add($"this.TotalUses = {(this.TotalUses == null ? "null" : this.TotalUses.ToString())}");
            toStringOutput.Add($"this.AverageRating = {(this.AverageRating == null ? "null" : this.AverageRating.ToString())}");
        }
    }
}