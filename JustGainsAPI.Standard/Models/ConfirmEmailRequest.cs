// <copyright file="ConfirmEmailRequest.cs" company="APIMatic">
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
    /// ConfirmEmailRequest.
    /// </summary>
    public class ConfirmEmailRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmEmailRequest"/> class.
        /// </summary>
        public ConfirmEmailRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmEmailRequest"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        public ConfirmEmailRequest(
            string email)
        {
            this.Email = email;
        }

        /// <summary>
        /// Email address to confirm
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConfirmEmailRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConfirmEmailRequest other &&                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true));
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