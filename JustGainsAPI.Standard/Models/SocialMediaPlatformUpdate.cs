// <copyright file="SocialMediaPlatformUpdate.cs" company="APIMatic">
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
    /// SocialMediaPlatformUpdate.
    /// </summary>
    public class SocialMediaPlatformUpdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaPlatformUpdate"/> class.
        /// </summary>
        public SocialMediaPlatformUpdate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaPlatformUpdate"/> class.
        /// </summary>
        /// <param name="socialMediaPlatformName">socialMediaPlatformName.</param>
        /// <param name="socialMediaPlatformUrlFormat">socialMediaPlatformUrlFormat.</param>
        /// <param name="socialMediaPlatformIcon">socialMediaPlatformIcon.</param>
        public SocialMediaPlatformUpdate(
            string socialMediaPlatformName = null,
            string socialMediaPlatformUrlFormat = null,
            Guid? socialMediaPlatformIcon = null)
        {
            this.SocialMediaPlatformName = socialMediaPlatformName;
            this.SocialMediaPlatformUrlFormat = socialMediaPlatformUrlFormat;
            this.SocialMediaPlatformIcon = socialMediaPlatformIcon;
        }

        /// <summary>
        /// Updated name of the social media platform
        /// </summary>
        [JsonProperty("socialMediaPlatformName", NullValueHandling = NullValueHandling.Ignore)]
        public string SocialMediaPlatformName { get; set; }

        /// <summary>
        /// Updated URL format for the platform's profile pages
        /// </summary>
        [JsonProperty("socialMediaPlatformUrlFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string SocialMediaPlatformUrlFormat { get; set; }

        /// <summary>
        /// Updated UUID of the associated MediaAsset for the platform's icon
        /// </summary>
        [JsonProperty("socialMediaPlatformIcon", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SocialMediaPlatformIcon { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SocialMediaPlatformUpdate : ({string.Join(", ", toStringOutput)})";
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
            return obj is SocialMediaPlatformUpdate other &&                ((this.SocialMediaPlatformName == null && other.SocialMediaPlatformName == null) || (this.SocialMediaPlatformName?.Equals(other.SocialMediaPlatformName) == true)) &&
                ((this.SocialMediaPlatformUrlFormat == null && other.SocialMediaPlatformUrlFormat == null) || (this.SocialMediaPlatformUrlFormat?.Equals(other.SocialMediaPlatformUrlFormat) == true)) &&
                ((this.SocialMediaPlatformIcon == null && other.SocialMediaPlatformIcon == null) || (this.SocialMediaPlatformIcon?.Equals(other.SocialMediaPlatformIcon) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SocialMediaPlatformName = {(this.SocialMediaPlatformName == null ? "null" : this.SocialMediaPlatformName)}");
            toStringOutput.Add($"this.SocialMediaPlatformUrlFormat = {(this.SocialMediaPlatformUrlFormat == null ? "null" : this.SocialMediaPlatformUrlFormat)}");
            toStringOutput.Add($"this.SocialMediaPlatformIcon = {(this.SocialMediaPlatformIcon == null ? "null" : this.SocialMediaPlatformIcon.ToString())}");
        }
    }
}