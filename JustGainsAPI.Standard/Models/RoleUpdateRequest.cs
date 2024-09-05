// <copyright file="RoleUpdateRequest.cs" company="APIMatic">
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
    /// RoleUpdateRequest.
    /// </summary>
    public class RoleUpdateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleUpdateRequest"/> class.
        /// </summary>
        public RoleUpdateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleUpdateRequest"/> class.
        /// </summary>
        /// <param name="roleName">roleName.</param>
        /// <param name="description">description.</param>
        public RoleUpdateRequest(
            string roleName = null,
            string description = null)
        {
            this.RoleName = roleName;
            this.Description = description;
        }

        /// <summary>
        /// Gets or sets RoleName.
        /// </summary>
        [JsonProperty("roleName", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RoleUpdateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is RoleUpdateRequest other &&                ((this.RoleName == null && other.RoleName == null) || (this.RoleName?.Equals(other.RoleName) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RoleName = {(this.RoleName == null ? "null" : this.RoleName)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
        }
    }
}