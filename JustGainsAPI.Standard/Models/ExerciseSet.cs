// <copyright file="ExerciseSet.cs" company="APIMatic">
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
    /// ExerciseSet.
    /// </summary>
    public class ExerciseSet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseSet"/> class.
        /// </summary>
        public ExerciseSet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseSet"/> class.
        /// </summary>
        /// <param name="setNumber">setNumber.</param>
        /// <param name="metricValues">metricValues.</param>
        public ExerciseSet(
            int setNumber,
            Dictionary<string, double> metricValues)
        {
            this.SetNumber = setNumber;
            this.MetricValues = metricValues;
        }

        /// <summary>
        /// The number of the set within the exercise.
        /// </summary>
        [JsonProperty("setNumber")]
        public int SetNumber { get; set; }

        /// <summary>
        /// A map of metric codes to their corresponding values for this set.
        /// </summary>
        [JsonProperty("metricValues")]
        public Dictionary<string, double> MetricValues { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseSet : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseSet other &&                this.SetNumber.Equals(other.SetNumber) &&
                ((this.MetricValues == null && other.MetricValues == null) || (this.MetricValues?.Equals(other.MetricValues) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SetNumber = {this.SetNumber}");
            toStringOutput.Add($"MetricValues = {(this.MetricValues == null ? "null" : this.MetricValues.ToString())}");
        }
    }
}