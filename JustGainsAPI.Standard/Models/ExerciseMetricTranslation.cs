// <copyright file="ExerciseMetricTranslation.cs" company="APIMatic">
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
    /// ExerciseMetricTranslation.
    /// </summary>
    public class ExerciseMetricTranslation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMetricTranslation"/> class.
        /// </summary>
        public ExerciseMetricTranslation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMetricTranslation"/> class.
        /// </summary>
        /// <param name="localeCode">localeCode.</param>
        /// <param name="metricName">metricName.</param>
        /// <param name="measurementData">measurementData.</param>
        public ExerciseMetricTranslation(
            string localeCode = null,
            string metricName = null,
            string measurementData = null)
        {
            this.LocaleCode = localeCode;
            this.MetricName = metricName;
            this.MeasurementData = measurementData;
        }

        /// <summary>
        /// The locale code for this translation
        /// </summary>
        [JsonProperty("localeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string LocaleCode { get; set; }

        /// <summary>
        /// Translated name of the metric
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

            return $"ExerciseMetricTranslation : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseMetricTranslation other &&                ((this.LocaleCode == null && other.LocaleCode == null) || (this.LocaleCode?.Equals(other.LocaleCode) == true)) &&
                ((this.MetricName == null && other.MetricName == null) || (this.MetricName?.Equals(other.MetricName) == true)) &&
                ((this.MeasurementData == null && other.MeasurementData == null) || (this.MeasurementData?.Equals(other.MeasurementData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocaleCode = {(this.LocaleCode == null ? "null" : this.LocaleCode)}");
            toStringOutput.Add($"this.MetricName = {(this.MetricName == null ? "null" : this.MetricName)}");
            toStringOutput.Add($"this.MeasurementData = {(this.MeasurementData == null ? "null" : this.MeasurementData)}");
        }
    }
}