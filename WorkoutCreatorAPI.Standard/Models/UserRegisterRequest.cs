// <copyright file="UserRegisterRequest.cs" company="APIMatic">
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
    /// UserRegisterRequest.
    /// </summary>
    public class UserRegisterRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegisterRequest"/> class.
        /// </summary>
        public UserRegisterRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRegisterRequest"/> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="password">password.</param>
        /// <param name="username">username.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="redirectUrl">redirectUrl.</param>
        public UserRegisterRequest(
            string email,
            string password,
            string username,
            string firstName = null,
            string lastName = null,
            string redirectUrl = null)
        {
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.RedirectUrl = redirectUrl;
        }

        /// <summary>
        /// User's email address
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// User's password (should meet security requirements)
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// User's first name
        /// </summary>
        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// User's last name
        /// </summary>
        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// User's chosen username
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// URL to redirect after successful registration
        /// </summary>
        [JsonProperty("redirectUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUrl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UserRegisterRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UserRegisterRequest other &&                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.RedirectUrl == null && other.RedirectUrl == null) || (this.RedirectUrl?.Equals(other.RedirectUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
            toStringOutput.Add($"this.RedirectUrl = {(this.RedirectUrl == null ? "null" : this.RedirectUrl)}");
        }
    }
}