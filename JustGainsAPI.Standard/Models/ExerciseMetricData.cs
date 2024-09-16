// <copyright file="ExerciseMetricData.cs" company="APIMatic">
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
    /// ExerciseMetricData.
    /// </summary>
    public class ExerciseMetricData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMetricData"/> class.
        /// </summary>
        public ExerciseMetricData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMetricData"/> class.
        /// </summary>
        /// <param name="exerciseMetricCode">exerciseMetricCode.</param>
        /// <param name="exerciseMetricTranslations">exerciseMetricTranslations.</param>
        /// <param name="metricName">metricName.</param>
        /// <param name="measurementData">measurementData.</param>
        public ExerciseMetricData(
            string exerciseMetricCode = null,
            List<Models.ExerciseMetricTranslation> exerciseMetricTranslations = null,
            string metricName = null,
            string measurementData = null)
        {
            this.ExerciseMetricCode = exerciseMetricCode;
            this.ExerciseMetricTranslations = exerciseMetricTranslations;
            this.MetricName = metricName;
            this.MeasurementData = measurementData;
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

        /// <summary>
        /// Translated name of the metric in the requested locale
        /// </summary>
        [JsonProperty("metricName", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// a custom JSON object that can be used to store any additional data related to the metric
        /// </summary>
        [JsonProperty("measurementData", NullValueHandling = NullValueHandling.Ignore)]
        public string MeasurementData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseMetricData : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseMetricData other &&                ((this.ExerciseMetricCode == null && other.ExerciseMetricCode == null) || (this.ExerciseMetricCode?.Equals(other.ExerciseMetricCode) == true)) &&
                ((this.ExerciseMetricTranslations == null && other.ExerciseMetricTranslations == null) || (this.ExerciseMetricTranslations?.Equals(other.ExerciseMetricTranslations) == true)) &&
                ((this.MetricName == null && other.MetricName == null) || (this.MetricName?.Equals(other.MetricName) == true)) &&
                ((this.MeasurementData == null && other.MeasurementData == null) || (this.MeasurementData?.Equals(other.MeasurementData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseMetricCode = {(this.ExerciseMetricCode == null ? "null" : this.ExerciseMetricCode)}");
            toStringOutput.Add($"this.ExerciseMetricTranslations = {(this.ExerciseMetricTranslations == null ? "null" : $"[{string.Join(", ", this.ExerciseMetricTranslations)} ]")}");
            toStringOutput.Add($"this.MetricName = {(this.MetricName == null ? "null" : this.MetricName)}");
            toStringOutput.Add($"this.MeasurementData = {(this.MeasurementData == null ? "null" : this.MeasurementData)}");
        }
    }
}