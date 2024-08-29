// <copyright file="ConversionFactor.cs" company="APIMatic">
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
    /// ConversionFactor.
    /// </summary>
    public class ConversionFactor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionFactor"/> class.
        /// </summary>
        public ConversionFactor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionFactor"/> class.
        /// </summary>
        /// <param name="metricToImperial">metricToImperial.</param>
        public ConversionFactor(
            double? metricToImperial = null)
        {
            this.MetricToImperial = metricToImperial;
        }

        /// <summary>
        /// Gets or sets MetricToImperial.
        /// </summary>
        [JsonProperty("metricToImperial", NullValueHandling = NullValueHandling.Ignore)]
        public double? MetricToImperial { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConversionFactor : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConversionFactor other &&                ((this.MetricToImperial == null && other.MetricToImperial == null) || (this.MetricToImperial?.Equals(other.MetricToImperial) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MetricToImperial = {(this.MetricToImperial == null ? "null" : this.MetricToImperial.ToString())}");
        }
    }
}