// <copyright file="CreatorProfile.cs" company="APIMatic">
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
    /// CreatorProfile.
    /// </summary>
    public class CreatorProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorProfile"/> class.
        /// </summary>
        public CreatorProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorProfile"/> class.
        /// </summary>
        /// <param name="creatorProfileId">creatorProfileId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="userName">userName.</param>
        /// <param name="creatorEmail">creatorEmail.</param>
        /// <param name="profilePhoto">profilePhoto.</param>
        /// <param name="socialMediaAccounts">socialMediaAccounts.</param>
        public CreatorProfile(
            Guid? creatorProfileId = null,
            Guid? userId = null,
            string userName = null,
            string creatorEmail = null,
            Models.MediaAsset profilePhoto = null,
            List<Models.CreatorSocialMediaAccount> socialMediaAccounts = null)
        {
            this.CreatorProfileId = creatorProfileId;
            this.UserId = userId;
            this.UserName = userName;
            this.CreatorEmail = creatorEmail;
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
        /// Creator's email address.
        /// </summary>
        [JsonProperty("creatorEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorEmail { get; set; }

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

            return $"CreatorProfile : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreatorProfile other &&                ((this.CreatorProfileId == null && other.CreatorProfileId == null) || (this.CreatorProfileId?.Equals(other.CreatorProfileId) == true)) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.UserName == null && other.UserName == null) || (this.UserName?.Equals(other.UserName) == true)) &&
                ((this.CreatorEmail == null && other.CreatorEmail == null) || (this.CreatorEmail?.Equals(other.CreatorEmail) == true)) &&
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
            toStringOutput.Add($"this.CreatorEmail = {(this.CreatorEmail == null ? "null" : this.CreatorEmail)}");
            toStringOutput.Add($"this.ProfilePhoto = {(this.ProfilePhoto == null ? "null" : this.ProfilePhoto.ToString())}");
            toStringOutput.Add($"this.SocialMediaAccounts = {(this.SocialMediaAccounts == null ? "null" : $"[{string.Join(", ", this.SocialMediaAccounts)} ]")}");
        }
    }
}