// <copyright file="ResetPasswordRequest.cs" company="APIMatic">
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
    /// ResetPasswordRequest.
    /// </summary>
    public class ResetPasswordRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetPasswordRequest"/> class.
        /// </summary>
        public ResetPasswordRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetPasswordRequest"/> class.
        /// </summary>
        /// <param name="newPassword">newPassword.</param>
        public ResetPasswordRequest(
            string newPassword)
        {
            this.NewPassword = newPassword;
        }

        /// <summary>
        /// New password to set
        /// </summary>
        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ResetPasswordRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ResetPasswordRequest other &&                ((this.NewPassword == null && other.NewPassword == null) || (this.NewPassword?.Equals(other.NewPassword) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NewPassword = {(this.NewPassword == null ? "null" : this.NewPassword)}");
        }
    }
}