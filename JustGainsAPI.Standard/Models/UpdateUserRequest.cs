// <copyright file="UpdateUserRequest.cs" company="APIMatic">
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
    /// UpdateUserRequest.
    /// </summary>
    public class UpdateUserRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequest"/> class.
        /// </summary>
        public UpdateUserRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequest"/> class.
        /// </summary>
        /// <param name="creatorProfileId">creatorProfileId.</param>
        /// <param name="email">email.</param>
        public UpdateUserRequest(
            Guid? creatorProfileId = null,
            string email = null)
        {
            this.CreatorProfileId = creatorProfileId;
            this.Email = email;
        }

        /// <summary>
        /// Unique identifier for the creator profile.
        /// </summary>
        [JsonProperty("creatorProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CreatorProfileId { get; set; }

        /// <summary>
        /// The user's email address.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateUserRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateUserRequest other &&                ((this.CreatorProfileId == null && other.CreatorProfileId == null) || (this.CreatorProfileId?.Equals(other.CreatorProfileId) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreatorProfileId = {(this.CreatorProfileId == null ? "null" : this.CreatorProfileId.ToString())}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
        }
    }
}