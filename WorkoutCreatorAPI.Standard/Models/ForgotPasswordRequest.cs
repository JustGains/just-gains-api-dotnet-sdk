// <copyright file="ForgotPasswordRequest.cs" company="APIMatic">
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
    /// ForgotPasswordRequest.
    /// </summary>
    public class ForgotPasswordRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPasswordRequest"/> class.
        /// </summary>
        public ForgotPasswordRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPasswordRequest"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        public ForgotPasswordRequest(
            string email)
        {
            this.Email = email;
        }

        /// <summary>
        /// Email address associated with the account
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ForgotPasswordRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ForgotPasswordRequest other &&                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
        }
    }
}