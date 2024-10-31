// <copyright file="User.cs" company="APIMatic">
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
    /// User.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="userName">userName.</param>
        /// <param name="emailConfirmed">emailConfirmed.</param>
        /// <param name="email">email.</param>
        /// <param name="password">password.</param>
        /// <param name="oAuthProvider">oAuthProvider.</param>
        /// <param name="roles">roles.</param>
        /// <param name="lastSignInAt">LastSignInAt.</param>
        /// <param name="creatorProfile">creatorProfile.</param>
        public User(
            Guid? userId = null,
            string userName = null,
            bool? emailConfirmed = null,
            string email = null,
            string password = null,
            string oAuthProvider = null,
            List<string> roles = null,
            DateTime? lastSignInAt = null,
            Models.CreatorProfile creatorProfile = null)
        {
            this.UserId = userId;
            this.UserName = userName;
            this.EmailConfirmed = emailConfirmed;
            this.Email = email;
            this.Password = password;
            this.OAuthProvider = oAuthProvider;
            this.Roles = roles;
            this.LastSignInAt = lastSignInAt;
            this.CreatorProfile = creatorProfile;
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
        /// Indicates if the user's email has been confirmed
        /// </summary>
        [JsonProperty("emailConfirmed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmailConfirmed { get; set; }

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
        /// Timestamp of the user's last login
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("LastSignInAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastSignInAt { get; set; }

        /// <summary>
        /// Represents a creator's profile information.
        /// </summary>
        [JsonProperty("creatorProfile", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorProfile CreatorProfile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"User : ({string.Join(", ", toStringOutput)})";
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
            return obj is User other &&                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                ((this.EmailConfirmed == null && other.EmailConfirmed == null) || (this.EmailConfirmed?.Equals(other.EmailConfirmed) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.OAuthProvider == null && other.OAuthProvider == null) || (this.OAuthProvider?.Equals(other.OAuthProvider) == true)) &&
                ((this.Roles == null && other.Roles == null) || (this.Roles?.Equals(other.Roles) == true)) &&
                ((this.LastSignInAt == null && other.LastSignInAt == null) || (this.LastSignInAt?.Equals(other.LastSignInAt) == true)) &&
                ((this.CreatorProfile == null && other.CreatorProfile == null) || (this.CreatorProfile?.Equals(other.CreatorProfile) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId.ToString())}");
            toStringOutput.Add($"this.UserName = {(this.UserName == null ? "null" : this.UserName)}");
            toStringOutput.Add($"this.EmailConfirmed = {(this.EmailConfirmed == null ? "null" : this.EmailConfirmed.ToString())}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password)}");
            toStringOutput.Add($"this.OAuthProvider = {(this.OAuthProvider == null ? "null" : this.OAuthProvider)}");
            toStringOutput.Add($"this.Roles = {(this.Roles == null ? "null" : $"[{string.Join(", ", this.Roles)} ]")}");
            toStringOutput.Add($"this.LastSignInAt = {(this.LastSignInAt == null ? "null" : this.LastSignInAt.ToString())}");
            toStringOutput.Add($"this.CreatorProfile = {(this.CreatorProfile == null ? "null" : this.CreatorProfile.ToString())}");
        }
    }
}