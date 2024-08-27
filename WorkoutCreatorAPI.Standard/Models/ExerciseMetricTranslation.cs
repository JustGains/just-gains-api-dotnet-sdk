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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WorkoutCreatorAPI.Standard;
using WorkoutCreatorAPI.Standard.Utilities;

namespace WorkoutCreatorAPI.Standard.Models
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
        /// <param name="exerciseMetricName">exerciseMetricName.</param>
        /// <param name="measurementData">measurementData.</param>
        public ExerciseMetricTranslation(
            string localeCode,
            string exerciseMetricName,
            object measurementData)
        {
            this.LocaleCode = localeCode;
            this.ExerciseMetricName = exerciseMetricName;
            this.MeasurementData = measurementData;
        }

        /// <summary>
        /// The locale code of the translation
        /// </summary>
        [JsonProperty("localeCode")]
        public string LocaleCode { get; set; }

        /// <summary>
        /// Translated Metric Name for the chosen Locale
        /// </summary>
        [JsonProperty("exerciseMetricName")]
        public string ExerciseMetricName { get; set; }

        /// <summary>
        /// JSONB format containing measurement details
        /// </summary>
        [JsonProperty("measurementData")]
        public object MeasurementData { get; set; }

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
                ((this.ExerciseMetricName == null && other.ExerciseMetricName == null) || (this.ExerciseMetricName?.Equals(other.ExerciseMetricName) == true)) &&
                ((this.MeasurementData == null && other.MeasurementData == null) || (this.MeasurementData?.Equals(other.MeasurementData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocaleCode = {(this.LocaleCode == null ? "null" : this.LocaleCode)}");
            toStringOutput.Add($"this.ExerciseMetricName = {(this.ExerciseMetricName == null ? "null" : this.ExerciseMetricName)}");
            toStringOutput.Add($"MeasurementData = {(this.MeasurementData == null ? "null" : this.MeasurementData.ToString())}");
        }
    }
}