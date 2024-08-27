// <copyright file="UserInfo1.cs" company="APIMatic">
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
    /// UserInfo1.
    /// </summary>
    public class UserInfo1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo1"/> class.
        /// </summary>
        public UserInfo1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo1"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="email">email.</param>
        /// <param name="userName">userName.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="emailConfirmed">emailConfirmed.</param>
        /// <param name="roles">roles.</param>
        /// <param name="lastLoginAt">lastLoginAt.</param>
        /// <param name="message">message.</param>
        public UserInfo1(
            Guid? id = null,
            string email = null,
            string userName = null,
            string firstName = null,
            string lastName = null,
            bool? emailConfirmed = null,
            List<string> roles = null,
            DateTime? lastLoginAt = null,
            string message = null)
        {
            this.Id = id;
            this.Email = email;
            this.UserName = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailConfirmed = emailConfirmed;
            this.Roles = roles;
            this.LastLoginAt = lastLoginAt;
            this.Message = message;
        }

        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// User's email address
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// User's username
        /// </summary>
        [JsonProperty("userName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

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
        /// Indicates if the user's email has been confirmed
        /// </summary>
        [JsonProperty("emailConfirmed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmailConfirmed { get; set; }

        /// <summary>
        /// List of roles assigned to the user
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Timestamp of the user's last login
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastLoginAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastLoginAt { get; set; }

        /// <summary>
        /// Message to be displayed to the user
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UserInfo1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is UserInfo1 other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.EmailConfirmed == null && other.EmailConfirmed == null) || (this.EmailConfirmed?.Equals(other.EmailConfirmed) == true)) &&
                ((this.Roles == null && other.Roles == null) || (this.Roles?.Equals(other.Roles) == true)) &&
                ((this.LastLoginAt == null && other.LastLoginAt == null) || (this.LastLoginAt?.Equals(other.LastLoginAt) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.UserName = {(this.UserName == null ? "null" : this.UserName)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.EmailConfirmed = {(this.EmailConfirmed == null ? "null" : this.EmailConfirmed.ToString())}");
            toStringOutput.Add($"this.Roles = {(this.Roles == null ? "null" : $"[{string.Join(", ", this.Roles)} ]")}");
            toStringOutput.Add($"this.LastLoginAt = {(this.LastLoginAt == null ? "null" : this.LastLoginAt.ToString())}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
        }
    }
}