// <copyright file="CreatorSocialMediaAccount.cs" company="APIMatic">
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
    /// CreatorSocialMediaAccount.
    /// </summary>
    public class CreatorSocialMediaAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorSocialMediaAccount"/> class.
        /// </summary>
        public CreatorSocialMediaAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorSocialMediaAccount"/> class.
        /// </summary>
        /// <param name="socialMediaPlatformCode">socialMediaPlatformCode.</param>
        /// <param name="socialMediaAccountUsername">socialMediaAccountUsername.</param>
        public CreatorSocialMediaAccount(
            string socialMediaPlatformCode = null,
            string socialMediaAccountUsername = null)
        {
            this.SocialMediaPlatformCode = socialMediaPlatformCode;
            this.SocialMediaAccountUsername = socialMediaAccountUsername;
        }

        /// <summary>
        /// The ID of the social media platform from the predefined list.
        /// </summary>
        [JsonProperty("socialMediaPlatformCode", NullValueHandling = NullValueHandling.Ignore)]
        public string SocialMediaPlatformCode { get; set; }

        /// <summary>
        /// The creator's username on this platform.
        /// </summary>
        [JsonProperty("socialMediaAccountUsername", NullValueHandling = NullValueHandling.Ignore)]
        public string SocialMediaAccountUsername { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreatorSocialMediaAccount : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreatorSocialMediaAccount other &&                ((this.SocialMediaPlatformCode == null && other.SocialMediaPlatformCode == null) || (this.SocialMediaPlatformCode?.Equals(other.SocialMediaPlatformCode) == true)) &&
                ((this.SocialMediaAccountUsername == null && other.SocialMediaAccountUsername == null) || (this.SocialMediaAccountUsername?.Equals(other.SocialMediaAccountUsername) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SocialMediaPlatformCode = {(this.SocialMediaPlatformCode == null ? "null" : this.SocialMediaPlatformCode)}");
            toStringOutput.Add($"this.SocialMediaAccountUsername = {(this.SocialMediaAccountUsername == null ? "null" : this.SocialMediaAccountUsername)}");
        }
    }
}