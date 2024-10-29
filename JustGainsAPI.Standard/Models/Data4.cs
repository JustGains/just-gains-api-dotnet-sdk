// <copyright file="Data4.cs" company="APIMatic">
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
    /// Data4.
    /// </summary>
    public class Data4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data4"/> class.
        /// </summary>
        public Data4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data4"/> class.
        /// </summary>
        /// <param name="clientId">clientId.</param>
        /// <param name="authorizeUrl">authorizeUrl.</param>
        /// <param name="tokenUrl">tokenUrl.</param>
        /// <param name="scopes">scopes.</param>
        public Data4(
            string clientId = null,
            string authorizeUrl = null,
            string tokenUrl = null,
            List<string> scopes = null)
        {
            this.ClientId = clientId;
            this.AuthorizeUrl = authorizeUrl;
            this.TokenUrl = tokenUrl;
            this.Scopes = scopes;
        }

        /// <summary>
        /// The OAuth client ID
        /// </summary>
        [JsonProperty("clientId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// The authorization endpoint URL
        /// </summary>
        [JsonProperty("authorizeUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizeUrl { get; set; }

        /// <summary>
        /// The token endpoint URL
        /// </summary>
        [JsonProperty("tokenUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenUrl { get; set; }

        /// <summary>
        /// Available OAuth scopes
        /// </summary>
        [JsonProperty("scopes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Scopes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data4 other &&                ((this.ClientId == null && other.ClientId == null) || (this.ClientId?.Equals(other.ClientId) == true)) &&
                ((this.AuthorizeUrl == null && other.AuthorizeUrl == null) || (this.AuthorizeUrl?.Equals(other.AuthorizeUrl) == true)) &&
                ((this.TokenUrl == null && other.TokenUrl == null) || (this.TokenUrl?.Equals(other.TokenUrl) == true)) &&
                ((this.Scopes == null && other.Scopes == null) || (this.Scopes?.Equals(other.Scopes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ClientId = {(this.ClientId == null ? "null" : this.ClientId)}");
            toStringOutput.Add($"this.AuthorizeUrl = {(this.AuthorizeUrl == null ? "null" : this.AuthorizeUrl)}");
            toStringOutput.Add($"this.TokenUrl = {(this.TokenUrl == null ? "null" : this.TokenUrl)}");
            toStringOutput.Add($"this.Scopes = {(this.Scopes == null ? "null" : $"[{string.Join(", ", this.Scopes)} ]")}");
        }
    }
}