// <copyright file="CreatorProfile1.cs" company="APIMatic">
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
    /// CreatorProfile1.
    /// </summary>
    public class CreatorProfile1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorProfile1"/> class.
        /// </summary>
        public CreatorProfile1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorProfile1"/> class.
        /// </summary>
        /// <param name="creatorProfileId">creatorProfileId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="userName">userName.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="profilePhoto">profilePhoto.</param>
        /// <param name="socialMediaAccounts">socialMediaAccounts.</param>
        public CreatorProfile1(
            Guid? creatorProfileId = null,
            Guid? userId = null,
            string userName = null,
            string firstName = null,
            string lastName = null,
            string fullName = null,
            Models.MediaAsset profilePhoto = null,
            List<Models.CreatorSocialMediaAccount> socialMediaAccounts = null)
        {
            this.CreatorProfileId = creatorProfileId;
            this.UserId = userId;
            this.UserName = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
            this.ProfilePhoto = profilePhoto;
            this.SocialMediaAccounts = socialMediaAccounts;
        }

        /// <summary>
        /// Unique identifier for the creator profile.
        /// </summary>
        [JsonProperty("creatorProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CreatorProfileId { get; set; }

        /// <summary>
        /// Associated user ID, if applicable.
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Creator's username.
        /// </summary>
        [JsonProperty("userName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// Creator's first name.
        /// </summary>
        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// Creator's last name.
        /// </summary>
        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Creator's full name.
        /// </summary>
        [JsonProperty("fullName", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets ProfilePhoto.
        /// </summary>
        [JsonProperty("profilePhoto", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset ProfilePhoto { get; set; }

        /// <summary>
        /// List of creator's social media accounts.
        /// </summary>
        [JsonProperty("socialMediaAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreatorSocialMediaAccount> SocialMediaAccounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreatorProfile1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreatorProfile1 other &&                ((this.CreatorProfileId == null && other.CreatorProfileId == null) || (this.CreatorProfileId?.Equals(other.CreatorProfileId) == true)) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.FullName == null && other.FullName == null) || (this.FullName?.Equals(other.FullName) == true)) &&
                ((this.ProfilePhoto == null && other.ProfilePhoto == null) || (this.ProfilePhoto?.Equals(other.ProfilePhoto) == true)) &&
                ((this.SocialMediaAccounts == null && other.SocialMediaAccounts == null) || (this.SocialMediaAccounts?.Equals(other.SocialMediaAccounts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreatorProfileId = {(this.CreatorProfileId == null ? "null" : this.CreatorProfileId.ToString())}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId.ToString())}");
            toStringOutput.Add($"this.UserName = {(this.UserName == null ? "null" : this.UserName)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.FullName = {(this.FullName == null ? "null" : this.FullName)}");
            toStringOutput.Add($"this.ProfilePhoto = {(this.ProfilePhoto == null ? "null" : this.ProfilePhoto.ToString())}");
            toStringOutput.Add($"this.SocialMediaAccounts = {(this.SocialMediaAccounts == null ? "null" : $"[{string.Join(", ", this.SocialMediaAccounts)} ]")}");
        }
    }
}