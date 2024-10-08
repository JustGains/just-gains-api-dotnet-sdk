// <copyright file="ExerciseMetric.cs" company="APIMatic">
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
    /// ExerciseMetric.
    /// </summary>
    public class ExerciseMetric
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMetric"/> class.
        /// </summary>
        public ExerciseMetric()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMetric"/> class.
        /// </summary>
        /// <param name="exerciseMetricCode">exerciseMetricCode.</param>
        /// <param name="exerciseMetricTranslations">exerciseMetricTranslations.</param>
        public ExerciseMetric(
            string exerciseMetricCode = null,
            List<Models.ExerciseMetricTranslation> exerciseMetricTranslations = null)
        {
            this.ExerciseMetricCode = exerciseMetricCode;
            this.ExerciseMetricTranslations = exerciseMetricTranslations;
        }

        /// <summary>
        /// A unique identifier for the exercise metric.
        /// </summary>
        [JsonProperty("exerciseMetricCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseMetricCode { get; set; }

        /// <summary>
        /// Array of translations for the metric
        /// </summary>
        [JsonProperty("exerciseMetricTranslations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ExerciseMetricTranslation> ExerciseMetricTranslations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseMetric : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseMetric other &&                ((this.ExerciseMetricCode == null && other.ExerciseMetricCode == null) || (this.ExerciseMetricCode?.Equals(other.ExerciseMetricCode) == true)) &&
                ((this.ExerciseMetricTranslations == null && other.ExerciseMetricTranslations == null) || (this.ExerciseMetricTranslations?.Equals(other.ExerciseMetricTranslations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseMetricCode = {(this.ExerciseMetricCode == null ? "null" : this.ExerciseMetricCode)}");
            toStringOutput.Add($"this.ExerciseMetricTranslations = {(this.ExerciseMetricTranslations == null ? "null" : $"[{string.Join(", ", this.ExerciseMetricTranslations)} ]")}");
        }
    }
}