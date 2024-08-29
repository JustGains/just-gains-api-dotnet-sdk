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
        /// <param name="exerciseMetricName">exerciseMetricName.</param>
        /// <param name="measurementData">measurementData.</param>
        public ExerciseMetric(
            string exerciseMetricCode = null,
            string exerciseMetricName = null,
            Models.MeasurementData measurementData = null)
        {
            this.ExerciseMetricCode = exerciseMetricCode;
            this.ExerciseMetricName = exerciseMetricName;
            this.MeasurementData = measurementData;
        }

        /// <summary>
        /// A unique identifier for the exercise metric.
        /// </summary>
        [JsonProperty("exerciseMetricCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseMetricCode { get; set; }

        /// <summary>
        /// Translated name of the metric (Realistically not used because the real data for this comes from measurementData)
        /// </summary>
        [JsonProperty("exerciseMetricName", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseMetricName { get; set; }

        /// <summary>
        /// Gets or sets MeasurementData.
        /// </summary>
        [JsonProperty("measurementData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MeasurementData MeasurementData { get; set; }

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
                ((this.ExerciseMetricName == null && other.ExerciseMetricName == null) || (this.ExerciseMetricName?.Equals(other.ExerciseMetricName) == true)) &&
                ((this.MeasurementData == null && other.MeasurementData == null) || (this.MeasurementData?.Equals(other.MeasurementData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseMetricCode = {(this.ExerciseMetricCode == null ? "null" : this.ExerciseMetricCode)}");
            toStringOutput.Add($"this.ExerciseMetricName = {(this.ExerciseMetricName == null ? "null" : this.ExerciseMetricName)}");
            toStringOutput.Add($"this.MeasurementData = {(this.MeasurementData == null ? "null" : this.MeasurementData.ToString())}");
        }
    }
}