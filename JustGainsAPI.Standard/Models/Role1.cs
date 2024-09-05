// <copyright file="Role1.cs" company="APIMatic">
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
    /// Role1.
    /// </summary>
    public class Role1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role1"/> class.
        /// </summary>
        public Role1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role1"/> class.
        /// </summary>
        /// <param name="roleId">roleId.</param>
        /// <param name="roleName">roleName.</param>
        /// <param name="description">description.</param>
        public Role1(
            int? roleId = null,
            string roleName = null,
            string description = null)
        {
            this.RoleId = roleId;
            this.RoleName = roleName;
            this.Description = description;
        }

        /// <summary>
        /// Gets or sets RoleId.
        /// </summary>
        [JsonProperty("roleId", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoleId { get; set; }

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

            return $"Role1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Role1 other &&                ((this.RoleId == null && other.RoleId == null) || (this.RoleId?.Equals(other.RoleId) == true)) &&
                ((this.RoleName == null && other.RoleName == null) || (this.RoleName?.Equals(other.RoleName) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RoleId = {(this.RoleId == null ? "null" : this.RoleId.ToString())}");
            toStringOutput.Add($"this.RoleName = {(this.RoleName == null ? "null" : this.RoleName)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
        }
    }
}