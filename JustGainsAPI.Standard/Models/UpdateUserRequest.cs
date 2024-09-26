// <copyright file="UpdateUserRequest.cs" company="APIMatic">
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
    /// UpdateUserRequest.
    /// </summary>
    public class UpdateUserRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequest"/> class.
        /// </summary>
        public UpdateUserRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequest"/> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="email">email.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="fullName">fullName.</param>
        public UpdateUserRequest(
            Guid? userId = null,
            string email = null,
            string firstName = null,
            string lastName = null,
            string fullName = null)
        {
            this.UserId = userId;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
        }

        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// The user's email address.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateUserRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateUserRequest other &&                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.FullName == null && other.FullName == null) || (this.FullName?.Equals(other.FullName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId.ToString())}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.FullName = {(this.FullName == null ? "null" : this.FullName)}");
        }
    }
}