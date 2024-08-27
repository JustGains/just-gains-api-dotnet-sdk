// <copyright file="ImperialUnits.cs" company="APIMatic">
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
    /// ImperialUnits.
    /// </summary>
    public class ImperialUnits
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImperialUnits"/> class.
        /// </summary>
        public ImperialUnits()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImperialUnits"/> class.
        /// </summary>
        /// <param name="units">units.</param>
        /// <param name="defaultUnit">defaultUnit.</param>
        public ImperialUnits(
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

            return $"ImperialUnits : ({string.Join(", ", toStringOutput)})";
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
            return obj is ImperialUnits other &&                ((this.Units == null && other.Units == null) || (this.Units?.Equals(other.Units) == true)) &&
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