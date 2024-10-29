// <copyright file="Data3.cs" company="APIMatic">
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
    /// Data3.
    /// </summary>
    public class Data3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data3"/> class.
        /// </summary>
        public Data3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data3"/> class.
        /// </summary>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="refreshToken">refreshToken.</param>
        /// <param name="user">user.</param>
        public Data3(
            string accessToken = null,
            string refreshToken = null,
            Models.UserInfo user = null)
        {
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
            this.User = user;
        }

        /// <summary>
        /// The access token received from the OAuth provider
        /// </summary>
        [JsonProperty("accessToken", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        /// The refresh token received from the OAuth provider
        /// </summary>
        [JsonProperty("refreshToken", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// User information object
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UserInfo User { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data3 other &&                ((this.AccessToken == null && other.AccessToken == null) || (this.AccessToken?.Equals(other.AccessToken) == true)) &&
                ((this.RefreshToken == null && other.RefreshToken == null) || (this.RefreshToken?.Equals(other.RefreshToken) == true)) &&
                ((this.User == null && other.User == null) || (this.User?.Equals(other.User) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccessToken = {(this.AccessToken == null ? "null" : this.AccessToken)}");
            toStringOutput.Add($"this.RefreshToken = {(this.RefreshToken == null ? "null" : this.RefreshToken)}");
            toStringOutput.Add($"this.User = {(this.User == null ? "null" : this.User.ToString())}");
        }
    }
}