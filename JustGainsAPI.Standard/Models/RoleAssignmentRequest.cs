// <copyright file="RoleAssignmentRequest.cs" company="APIMatic">
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
    /// RoleAssignmentRequest.
    /// </summary>
    public class RoleAssignmentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleAssignmentRequest"/> class.
        /// </summary>
        public RoleAssignmentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleAssignmentRequest"/> class.
        /// </summary>
        /// <param name="roleId">roleId.</param>
        public RoleAssignmentRequest(
            int roleId)
        {
            this.RoleId = roleId;
        }

        /// <summary>
        /// Gets or sets RoleId.
        /// </summary>
        [JsonProperty("roleId")]
        public int RoleId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RoleAssignmentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is RoleAssignmentRequest other &&                this.RoleId.Equals(other.RoleId);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RoleId = {this.RoleId}");
        }
    }
}