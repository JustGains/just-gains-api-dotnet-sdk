// <copyright file="UnitLong.cs" company="APIMatic">
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
    /// UnitLong.
    /// </summary>
    public class UnitLong
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitLong"/> class.
        /// </summary>
        public UnitLong()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitLong"/> class.
        /// </summary>
        /// <param name="unitLongName">unitLongName.</param>
        /// <param name="unitLongPlural">unitLongPlural.</param>
        public UnitLong(
            string unitLongName = null,
            string unitLongPlural = null)
        {
            this.UnitLongName = unitLongName;
            this.UnitLongPlural = unitLongPlural;
        }

        /// <summary>
        /// Gets or sets UnitLongName.
        /// </summary>
        [JsonProperty("unitLongName", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitLongName { get; set; }

        /// <summary>
        /// Gets or sets UnitLongPlural.
        /// </summary>
        [JsonProperty("unitLongPlural", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitLongPlural { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UnitLong : ({string.Join(", ", toStringOutput)})";
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
            return obj is UnitLong other &&                ((this.UnitLongName == null && other.UnitLongName == null) || (this.UnitLongName?.Equals(other.UnitLongName) == true)) &&
                ((this.UnitLongPlural == null && other.UnitLongPlural == null) || (this.UnitLongPlural?.Equals(other.UnitLongPlural) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UnitLongName = {(this.UnitLongName == null ? "null" : this.UnitLongName)}");
            toStringOutput.Add($"this.UnitLongPlural = {(this.UnitLongPlural == null ? "null" : this.UnitLongPlural)}");
        }
    }
}