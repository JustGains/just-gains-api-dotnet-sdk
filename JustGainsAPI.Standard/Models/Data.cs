// <copyright file="Data.cs" company="APIMatic">
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
    /// Data.
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data"/> class.
        /// </summary>
        public Data()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data"/> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="userName">userName.</param>
        /// <param name="email">email.</param>
        /// <param name="password">password.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="oAuthProvider">oAuthProvider.</param>
        /// <param name="roles">roles.</param>
        /// <param name="refreshToken">refreshToken.</param>
        /// <param name="userCreatorProfile">userCreatorProfile.</param>
        public Data(
            Guid? userId = null,
            string userName = null,
            string email = null,
            string password = null,
            string firstName = null,
            string lastName = null,
            string fullName = null,
            string oAuthProvider = null,
            List<string> roles = null,
            string refreshToken = null,
            Models.CreatorProfile userCreatorProfile = null)
        {
            this.UserId = userId;
            this.UserName = userName;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
            this.OAuthProvider = oAuthProvider;
            this.Roles = roles;
            this.RefreshToken = refreshToken;
            this.UserCreatorProfile = userCreatorProfile;
        }

        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// The user's chosen username for the platform.
        /// </summary>
        [JsonProperty("userName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// The user's email address.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// The user's hashed password. This should never be exposed in API responses.
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// The user's first name.
        /// </summary>
        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user's last name.
        /// </summary>
        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// The user's full name, typically a combination of first and last name.
        /// </summary>
        [JsonProperty("fullName", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        /// <summary>
        /// The name of the OAuth provider if the user signed up using OAuth.
        /// </summary>
        [JsonProperty("oAuthProvider", NullValueHandling = NullValueHandling.Ignore)]
        public string OAuthProvider { get; set; }

        /// <summary>
        /// The user's role in the system, determining their permissions.
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// refreshToken value to get next accessToken
        /// </summary>
        [JsonProperty("refreshToken", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Represents a creator's profile information.
        /// </summary>
        [JsonProperty("userCreatorProfile", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorProfile UserCreatorProfile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data other &&                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.FullName == null && other.FullName == null) || (this.FullName?.Equals(other.FullName) == true)) &&
                ((this.OAuthProvider == null && other.OAuthProvider == null) || (this.OAuthProvider?.Equals(other.OAuthProvider) == true)) &&
                ((this.Roles == null && other.Roles == null) || (this.Roles?.Equals(other.Roles) == true)) &&
                ((this.RefreshToken == null && other.RefreshToken == null) || (this.RefreshToken?.Equals(other.RefreshToken) == true)) &&
                ((this.UserCreatorProfile == null && other.UserCreatorProfile == null) || (this.UserCreatorProfile?.Equals(other.UserCreatorProfile) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId.ToString())}");
            toStringOutput.Add($"this.UserName = {(this.UserName == null ? "null" : this.UserName)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.FullName = {(this.FullName == null ? "null" : this.FullName)}");
            toStringOutput.Add($"this.OAuthProvider = {(this.OAuthProvider == null ? "null" : this.OAuthProvider)}");
            toStringOutput.Add($"this.Roles = {(this.Roles == null ? "null" : $"[{string.Join(", ", this.Roles)} ]")}");
            toStringOutput.Add($"this.RefreshToken = {(this.RefreshToken == null ? "null" : this.RefreshToken)}");
            toStringOutput.Add($"this.UserCreatorProfile = {(this.UserCreatorProfile == null ? "null" : this.UserCreatorProfile.ToString())}");
        }
    }
}