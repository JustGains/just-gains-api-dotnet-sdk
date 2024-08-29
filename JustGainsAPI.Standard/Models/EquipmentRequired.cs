// <copyright file="EquipmentRequired.cs" company="APIMatic">
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
    /// EquipmentRequired.
    /// </summary>
    public class EquipmentRequired
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentRequired"/> class.
        /// </summary>
        public EquipmentRequired()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentRequired"/> class.
        /// </summary>
        /// <param name="required">required.</param>
        /// <param name="optional">optional.</param>
        public EquipmentRequired(
            List<List<string>> required = null,
            List<string> optional = null)
        {
            this.Required = required;
            this.Optional = optional;
        }

        /// <summary>
        /// Gets or sets Required.
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<string>> Required { get; set; }

        /// <summary>
        /// Gets or sets Optional.
        /// </summary>
        [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Optional { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EquipmentRequired : ({string.Join(", ", toStringOutput)})";
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
            return obj is EquipmentRequired other &&                ((this.Required == null && other.Required == null) || (this.Required?.Equals(other.Required) == true)) &&
                ((this.Optional == null && other.Optional == null) || (this.Optional?.Equals(other.Optional) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Required = {(this.Required == null ? "null" : $"[{string.Join(", ", this.Required)} ]")}");
            toStringOutput.Add($"this.Optional = {(this.Optional == null ? "null" : $"[{string.Join(", ", this.Optional)} ]")}");
        }
    }
}