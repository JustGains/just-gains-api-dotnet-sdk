// <copyright file="InitiateAuthRequest.cs" company="APIMatic">
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
    /// InitiateAuthRequest.
    /// </summary>
    public class InitiateAuthRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateAuthRequest"/> class.
        /// </summary>
        public InitiateAuthRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateAuthRequest"/> class.
        /// </summary>
        /// <param name="redirectUrl">redirectUrl.</param>
        public InitiateAuthRequest(
            string redirectUrl)
        {
            this.RedirectUrl = redirectUrl;
        }

        /// <summary>
        /// The URL to redirect to after authentication
        /// </summary>
        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InitiateAuthRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is InitiateAuthRequest other &&                ((this.RedirectUrl == null && other.RedirectUrl == null) || (this.RedirectUrl?.Equals(other.RedirectUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RedirectUrl = {(this.RedirectUrl == null ? "null" : this.RedirectUrl)}");
        }
    }
}