// <copyright file="UnitShort.cs" company="APIMatic">
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
    /// UnitShort.
    /// </summary>
    public class UnitShort
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitShort"/> class.
        /// </summary>
        public UnitShort()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitShort"/> class.
        /// </summary>
        /// <param name="unitShortName">unitShortName.</param>
        /// <param name="unitShortPlural">unitShortPlural.</param>
        public UnitShort(
            string unitShortName = null,
            string unitShortPlural = null)
        {
            this.UnitShortName = unitShortName;
            this.UnitShortPlural = unitShortPlural;
        }

        /// <summary>
        /// Gets or sets UnitShortName.
        /// </summary>
        [JsonProperty("unitShortName", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitShortName { get; set; }

        /// <summary>
        /// Gets or sets UnitShortPlural.
        /// </summary>
        [JsonProperty("unitShortPlural", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitShortPlural { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UnitShort : ({string.Join(", ", toStringOutput)})";
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
            return obj is UnitShort other &&                ((this.UnitShortName == null && other.UnitShortName == null) || (this.UnitShortName?.Equals(other.UnitShortName) == true)) &&
                ((this.UnitShortPlural == null && other.UnitShortPlural == null) || (this.UnitShortPlural?.Equals(other.UnitShortPlural) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UnitShortName = {(this.UnitShortName == null ? "null" : this.UnitShortName)}");
            toStringOutput.Add($"this.UnitShortPlural = {(this.UnitShortPlural == null ? "null" : this.UnitShortPlural)}");
        }
    }
}