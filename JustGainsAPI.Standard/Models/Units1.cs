// <copyright file="Units1.cs" company="APIMatic">
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
    /// Units1.
    /// </summary>
    public class Units1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Units1"/> class.
        /// </summary>
        public Units1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Units1"/> class.
        /// </summary>
        /// <param name="unitCode">unitCode.</param>
        /// <param name="unitShort">unitShort.</param>
        /// <param name="unitLong">unitLong.</param>
        /// <param name="conversionFactor">conversionFactor.</param>
        public Units1(
            string unitCode = null,
            Models.UnitShort unitShort = null,
            Models.UnitLong unitLong = null,
            double? conversionFactor = null)
        {
            this.UnitCode = unitCode;
            this.UnitShort = unitShort;
            this.UnitLong = unitLong;
            this.ConversionFactor = conversionFactor;
        }

        /// <summary>
        /// Gets or sets UnitCode.
        /// </summary>
        [JsonProperty("unitCode", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitCode { get; set; }

        /// <summary>
        /// Gets or sets UnitShort.
        /// </summary>
        [JsonProperty("unitShort", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UnitShort UnitShort { get; set; }

        /// <summary>
        /// Gets or sets UnitLong.
        /// </summary>
        [JsonProperty("unitLong", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UnitLong UnitLong { get; set; }

        /// <summary>
        /// Gets or sets ConversionFactor.
        /// </summary>
        [JsonProperty("conversionFactor", NullValueHandling = NullValueHandling.Ignore)]
        public double? ConversionFactor { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Units1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Units1 other &&                ((this.UnitCode == null && other.UnitCode == null) || (this.UnitCode?.Equals(other.UnitCode) == true)) &&
                ((this.UnitShort == null && other.UnitShort == null) || (this.UnitShort?.Equals(other.UnitShort) == true)) &&
                ((this.UnitLong == null && other.UnitLong == null) || (this.UnitLong?.Equals(other.UnitLong) == true)) &&
                ((this.ConversionFactor == null && other.ConversionFactor == null) || (this.ConversionFactor?.Equals(other.ConversionFactor) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UnitCode = {(this.UnitCode == null ? "null" : this.UnitCode)}");
            toStringOutput.Add($"this.UnitShort = {(this.UnitShort == null ? "null" : this.UnitShort.ToString())}");
            toStringOutput.Add($"this.UnitLong = {(this.UnitLong == null ? "null" : this.UnitLong.ToString())}");
            toStringOutput.Add($"this.ConversionFactor = {(this.ConversionFactor == null ? "null" : this.ConversionFactor.ToString())}");
        }
    }
}