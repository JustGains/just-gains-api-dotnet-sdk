// <copyright file="Data1.cs" company="APIMatic">
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
    /// Data1.
    /// </summary>
    public class Data1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data1"/> class.
        /// </summary>
        public Data1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data1"/> class.
        /// </summary>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="refreshToken">refreshToken.</param>
        /// <param name="tokenExpiration">tokenExpiration.</param>
        /// <param name="userInfo">userInfo.</param>
        public Data1(
            string accessToken = null,
            string refreshToken = null,
            DateTime? tokenExpiration = null,
            Models.UserInfo userInfo = null)
        {
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
            this.TokenExpiration = tokenExpiration;
            this.UserInfo = userInfo;
        }

        /// <summary>
        /// JWT access token for authenticated requests
        /// </summary>
        [JsonProperty("accessToken", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        /// JWT refresh token for obtaining new access tokens
        /// </summary>
        [JsonProperty("refreshToken", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Expiration time of the access token
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("tokenExpiration", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TokenExpiration { get; set; }

        /// <summary>
        /// User information object
        /// </summary>
        [JsonProperty("userInfo", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UserInfo UserInfo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data1 other &&                ((this.AccessToken == null && other.AccessToken == null) || (this.AccessToken?.Equals(other.AccessToken) == true)) &&
                ((this.RefreshToken == null && other.RefreshToken == null) || (this.RefreshToken?.Equals(other.RefreshToken) == true)) &&
                ((this.TokenExpiration == null && other.TokenExpiration == null) || (this.TokenExpiration?.Equals(other.TokenExpiration) == true)) &&
                ((this.UserInfo == null && other.UserInfo == null) || (this.UserInfo?.Equals(other.UserInfo) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccessToken = {(this.AccessToken == null ? "null" : this.AccessToken)}");
            toStringOutput.Add($"this.RefreshToken = {(this.RefreshToken == null ? "null" : this.RefreshToken)}");
            toStringOutput.Add($"this.TokenExpiration = {(this.TokenExpiration == null ? "null" : this.TokenExpiration.ToString())}");
            toStringOutput.Add($"this.UserInfo = {(this.UserInfo == null ? "null" : this.UserInfo.ToString())}");
        }
    }
}