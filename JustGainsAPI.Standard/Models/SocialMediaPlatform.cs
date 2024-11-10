// <copyright file="SocialMediaPlatform.cs" company="APIMatic">
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
    /// SocialMediaPlatform.
    /// </summary>
    public class SocialMediaPlatform
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaPlatform"/> class.
        /// </summary>
        public SocialMediaPlatform()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialMediaPlatform"/> class.
        /// </summary>
        /// <param name="socialMediaPlatformCode">socialMediaPlatformCode.</param>
        /// <param name="socialMediaPlatformName">socialMediaPlatformName.</param>
        /// <param name="socialMediaPlatformUrlFormat">socialMediaPlatformUrlFormat.</param>
        /// <param name="socialMediaPlatformIcon">socialMediaPlatformIcon.</param>
        public SocialMediaPlatform(
            string socialMediaPlatformCode = null,
            string socialMediaPlatformName = null,
            string socialMediaPlatformUrlFormat = null,
            Models.MediaAsset socialMediaPlatformIcon = null)
        {
            this.SocialMediaPlatformCode = socialMediaPlatformCode;
            this.SocialMediaPlatformName = socialMediaPlatformName;
            this.SocialMediaPlatformUrlFormat = socialMediaPlatformUrlFormat;
            this.SocialMediaPlatformIcon = socialMediaPlatformIcon;
        }

        /// <summary>
        /// Unique identifier for the social media platform
        /// </summary>
        [JsonProperty("socialMediaPlatformCode", NullValueHandling = NullValueHandling.Ignore)]
        public string SocialMediaPlatformCode { get; set; }

        /// <summary>
        /// Name of the social media platform
        /// </summary>
        [JsonProperty("socialMediaPlatformName", NullValueHandling = NullValueHandling.Ignore)]
        public string SocialMediaPlatformName { get; set; }

        /// <summary>
        /// URL format for the platform's profile pages
        /// </summary>
        [JsonProperty("socialMediaPlatformUrlFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string SocialMediaPlatformUrlFormat { get; set; }

        /// <summary>
        /// Gets or sets SocialMediaPlatformIcon.
        /// </summary>
        [JsonProperty("socialMediaPlatformIcon", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset SocialMediaPlatformIcon { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SocialMediaPlatform : ({string.Join(", ", toStringOutput)})";
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
            return obj is SocialMediaPlatform other &&                ((this.SocialMediaPlatformCode == null && other.SocialMediaPlatformCode == null) || (this.SocialMediaPlatformCode?.Equals(other.SocialMediaPlatformCode) == true)) &&
                ((this.SocialMediaPlatformName == null && other.SocialMediaPlatformName == null) || (this.SocialMediaPlatformName?.Equals(other.SocialMediaPlatformName) == true)) &&
                ((this.SocialMediaPlatformUrlFormat == null && other.SocialMediaPlatformUrlFormat == null) || (this.SocialMediaPlatformUrlFormat?.Equals(other.SocialMediaPlatformUrlFormat) == true)) &&
                ((this.SocialMediaPlatformIcon == null && other.SocialMediaPlatformIcon == null) || (this.SocialMediaPlatformIcon?.Equals(other.SocialMediaPlatformIcon) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SocialMediaPlatformCode = {(this.SocialMediaPlatformCode == null ? "null" : this.SocialMediaPlatformCode)}");
            toStringOutput.Add($"this.SocialMediaPlatformName = {(this.SocialMediaPlatformName == null ? "null" : this.SocialMediaPlatformName)}");
            toStringOutput.Add($"this.SocialMediaPlatformUrlFormat = {(this.SocialMediaPlatformUrlFormat == null ? "null" : this.SocialMediaPlatformUrlFormat)}");
            toStringOutput.Add($"this.SocialMediaPlatformIcon = {(this.SocialMediaPlatformIcon == null ? "null" : this.SocialMediaPlatformIcon.ToString())}");
        }
    }
}