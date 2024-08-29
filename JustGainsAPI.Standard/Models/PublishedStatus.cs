// <copyright file="PublishedStatus.cs" company="APIMatic">
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
    /// PublishedStatus.
    /// </summary>
    public class PublishedStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedStatus"/> class.
        /// </summary>
        public PublishedStatus()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedStatus"/> class.
        /// </summary>
        /// <param name="publishedStatusCode">publishedStatusCode.</param>
        /// <param name="userRoleAccess">userRoleAccess.</param>
        /// <param name="publishedStatusName">publishedStatusName.</param>
        public PublishedStatus(
            string publishedStatusCode = null,
            string userRoleAccess = null,
            string publishedStatusName = null)
        {
            this.PublishedStatusCode = publishedStatusCode;
            this.UserRoleAccess = userRoleAccess;
            this.PublishedStatusName = publishedStatusName;
        }

        /// <summary>
        /// The unique code for the published status
        /// </summary>
        [JsonProperty("publishedStatusCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishedStatusCode { get; set; }

        /// <summary>
        /// Comma-separated list of user roles that have access
        /// </summary>
        [JsonProperty("userRoleAccess", NullValueHandling = NullValueHandling.Ignore)]
        public string UserRoleAccess { get; set; }

        /// <summary>
        /// The name of the published status
        /// </summary>
        [JsonProperty("publishedStatusName", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishedStatusName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PublishedStatus : ({string.Join(", ", toStringOutput)})";
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
            return obj is PublishedStatus other &&                ((this.PublishedStatusCode == null && other.PublishedStatusCode == null) || (this.PublishedStatusCode?.Equals(other.PublishedStatusCode) == true)) &&
                ((this.UserRoleAccess == null && other.UserRoleAccess == null) || (this.UserRoleAccess?.Equals(other.UserRoleAccess) == true)) &&
                ((this.PublishedStatusName == null && other.PublishedStatusName == null) || (this.PublishedStatusName?.Equals(other.PublishedStatusName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PublishedStatusCode = {(this.PublishedStatusCode == null ? "null" : this.PublishedStatusCode)}");
            toStringOutput.Add($"this.UserRoleAccess = {(this.UserRoleAccess == null ? "null" : this.UserRoleAccess)}");
            toStringOutput.Add($"this.PublishedStatusName = {(this.PublishedStatusName == null ? "null" : this.PublishedStatusName)}");
        }
    }
}