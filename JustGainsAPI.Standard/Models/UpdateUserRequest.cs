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
        /// <param name="user">user.</param>
        public UpdateUserRequest(
            Models.User user)
        {
            this.User = user;
        }

        /// <summary>
        /// Represents a user in the system.
        /// </summary>
        [JsonProperty("user")]
        public Models.User User { get; set; }

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
            return obj is UpdateUserRequest other &&                ((this.User == null && other.User == null) || (this.User?.Equals(other.User) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.User = {(this.User == null ? "null" : this.User.ToString())}");
        }
    }
}