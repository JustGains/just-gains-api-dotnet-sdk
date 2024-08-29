// <copyright file="MetricUnits.cs" company="APIMatic">
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
    /// MetricUnits.
    /// </summary>
    public class MetricUnits
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricUnits"/> class.
        /// </summary>
        public MetricUnits()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricUnits"/> class.
        /// </summary>
        /// <param name="units">units.</param>
        /// <param name="defaultUnit">defaultUnit.</param>
        public MetricUnits(
            List<Models.Units1> units = null,
            int? defaultUnit = null)
        {
            this.Units = units;
            this.DefaultUnit = defaultUnit;
        }

        /// <summary>
        /// Gets or sets Units.
        /// </summary>
        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Units1> Units { get; set; }

        /// <summary>
        /// Gets or sets DefaultUnit.
        /// </summary>
        [JsonProperty("defaultUnit", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultUnit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MetricUnits : ({string.Join(", ", toStringOutput)})";
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
            return obj is MetricUnits other &&                ((this.Units == null && other.Units == null) || (this.Units?.Equals(other.Units) == true)) &&
                ((this.DefaultUnit == null && other.DefaultUnit == null) || (this.DefaultUnit?.Equals(other.DefaultUnit) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Units = {(this.Units == null ? "null" : $"[{string.Join(", ", this.Units)} ]")}");
            toStringOutput.Add($"this.DefaultUnit = {(this.DefaultUnit == null ? "null" : this.DefaultUnit.ToString())}");
        }
    }
}