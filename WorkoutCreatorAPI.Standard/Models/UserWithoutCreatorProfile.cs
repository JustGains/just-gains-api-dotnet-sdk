// <copyright file="UserWithoutCreatorProfile.cs" company="APIMatic">
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
    /// UserWithoutCreatorProfile.
    /// </summary>
    public class UserWithoutCreatorProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserWithoutCreatorProfile"/> class.
        /// </summary>
        public UserWithoutCreatorProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserWithoutCreatorProfile"/> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="userName">userName.</param>
        /// <param name="email">email.</param>
        /// <param name="password">password.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="oAuthProvider">oAuthProvider.</param>
        /// <param name="role">role.</param>
        /// <param name="refreshToken">refreshToken.</param>
        public UserWithoutCreatorProfile(
            Guid? userId = null,
            string userName = null,
            string email = null,
            string password = null,
            string firstName = null,
            string lastName = null,
            string fullName = null,
            string oAuthProvider = null,
            string role = null,
            string refreshToken = null)
        {
            this.UserId = userId;
            this.UserName = userName;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
            this.OAuthProvider = oAuthProvider;
            this.Role = role;
            this.RefreshToken = refreshToken;
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
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// refreshToken value to get next accesstoken
        /// </summary>
        [JsonProperty("refreshToken", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UserWithoutCreatorProfile : ({string.Join(", ", toStringOutput)})";
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
            return obj is UserWithoutCreatorProfile other &&                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.FullName == null && other.FullName == null) || (this.FullName?.Equals(other.FullName) == true)) &&
                ((this.OAuthProvider == null && other.OAuthProvider == null) || (this.OAuthProvider?.Equals(other.OAuthProvider) == true)) &&
                ((this.Role == null && other.Role == null) || (this.Role?.Equals(other.Role) == true)) &&
                ((this.RefreshToken == null && other.RefreshToken == null) || (this.RefreshToken?.Equals(other.RefreshToken) == true));
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
            toStringOutput.Add($"this.Role = {(this.Role == null ? "null" : this.Role)}");
            toStringOutput.Add($"this.RefreshToken = {(this.RefreshToken == null ? "null" : this.RefreshToken)}");
        }
    }
}