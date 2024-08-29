// <copyright file="Units.cs" company="APIMatic">
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
    /// Units.
    /// </summary>
    public class Units
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Units"/> class.
        /// </summary>
        public Units()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Units"/> class.
        /// </summary>
        /// <param name="metricUnits">metricUnits.</param>
        /// <param name="imperialUnits">imperialUnits.</param>
        public Units(
            Models.MetricUnits metricUnits = null,
            Models.ImperialUnits imperialUnits = null)
        {
            this.MetricUnits = metricUnits;
            this.ImperialUnits = imperialUnits;
        }

        /// <summary>
        /// Gets or sets MetricUnits.
        /// </summary>
        [JsonProperty("metricUnits", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MetricUnits MetricUnits { get; set; }

        /// <summary>
        /// Gets or sets ImperialUnits.
        /// </summary>
        [JsonProperty("imperialUnits", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ImperialUnits ImperialUnits { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Units : ({string.Join(", ", toStringOutput)})";
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
            return obj is Units other &&                ((this.MetricUnits == null && other.MetricUnits == null) || (this.MetricUnits?.Equals(other.MetricUnits) == true)) &&
                ((this.ImperialUnits == null && other.ImperialUnits == null) || (this.ImperialUnits?.Equals(other.ImperialUnits) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MetricUnits = {(this.MetricUnits == null ? "null" : this.MetricUnits.ToString())}");
            toStringOutput.Add($"this.ImperialUnits = {(this.ImperialUnits == null ? "null" : this.ImperialUnits.ToString())}");
        }
    }
}