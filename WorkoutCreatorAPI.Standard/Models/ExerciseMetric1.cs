// <copyright file="ExerciseMetric1.cs" company="APIMatic">
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
    /// ExerciseMetric1.
    /// </summary>
    public class ExerciseMetric1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMetric1"/> class.
        /// </summary>
        public ExerciseMetric1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMetric1"/> class.
        /// </summary>
        /// <param name="metricCode">metricCode.</param>
        /// <param name="metricUnit">metricUnit.</param>
        public ExerciseMetric1(
            string metricCode = null,
            string metricUnit = null)
        {
            this.MetricCode = metricCode;
            this.MetricUnit = metricUnit;
        }

        /// <summary>
        /// The code of the metric being recorded.
        /// </summary>
        [JsonProperty("metricCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricCode { get; set; }

        /// <summary>
        /// The unit of measurement for this metric.
        /// </summary>
        [JsonProperty("metricUnit", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricUnit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseMetric1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseMetric1 other &&                ((this.MetricCode == null && other.MetricCode == null) || (this.MetricCode?.Equals(other.MetricCode) == true)) &&
                ((this.MetricUnit == null && other.MetricUnit == null) || (this.MetricUnit?.Equals(other.MetricUnit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MetricCode = {(this.MetricCode == null ? "null" : this.MetricCode)}");
            toStringOutput.Add($"this.MetricUnit = {(this.MetricUnit == null ? "null" : this.MetricUnit)}");
        }
    }
}