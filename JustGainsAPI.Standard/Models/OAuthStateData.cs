// <copyright file="OAuthStateData.cs" company="APIMatic">
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
    /// OAuthStateData.
    /// </summary>
    public class OAuthStateData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthStateData"/> class.
        /// </summary>
        public OAuthStateData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthStateData"/> class.
        /// </summary>
        /// <param name="uri">uri.</param>
        /// <param name="pkceVerifier">pkceVerifier.</param>
        public OAuthStateData(
            string uri,
            string pkceVerifier)
        {
            this.Uri = uri;
            this.PkceVerifier = pkceVerifier;
        }

        /// <summary>
        /// The authorization URL to redirect the user to
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// The PKCE verifier code for the OAuth flow
        /// </summary>
        [JsonProperty("pkceVerifier")]
        public string PkceVerifier { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OAuthStateData : ({string.Join(", ", toStringOutput)})";
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
            return obj is OAuthStateData other &&                ((this.Uri == null && other.Uri == null) || (this.Uri?.Equals(other.Uri) == true)) &&
                ((this.PkceVerifier == null && other.PkceVerifier == null) || (this.PkceVerifier?.Equals(other.PkceVerifier) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uri = {(this.Uri == null ? "null" : this.Uri)}");
            toStringOutput.Add($"this.PkceVerifier = {(this.PkceVerifier == null ? "null" : this.PkceVerifier)}");
        }
    }
}