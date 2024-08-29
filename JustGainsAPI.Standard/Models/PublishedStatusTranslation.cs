// <copyright file="PublishedStatusTranslation.cs" company="APIMatic">
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
    /// PublishedStatusTranslation.
    /// </summary>
    public class PublishedStatusTranslation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedStatusTranslation"/> class.
        /// </summary>
        public PublishedStatusTranslation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedStatusTranslation"/> class.
        /// </summary>
        /// <param name="localeCode">localeCode.</param>
        /// <param name="publishedStatusName">publishedStatusName.</param>
        public PublishedStatusTranslation(
            string localeCode = null,
            string publishedStatusName = null)
        {
            this.LocaleCode = localeCode;
            this.PublishedStatusName = publishedStatusName;
        }

        /// <summary>
        /// The locale code of the translation
        /// </summary>
        [JsonProperty("localeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string LocaleCode { get; set; }

        /// <summary>
        /// The translated name of the published status
        /// </summary>
        [JsonProperty("publishedStatusName", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishedStatusName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PublishedStatusTranslation : ({string.Join(", ", toStringOutput)})";
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
            return obj is PublishedStatusTranslation other &&                ((this.LocaleCode == null && other.LocaleCode == null) || (this.LocaleCode?.Equals(other.LocaleCode) == true)) &&
                ((this.PublishedStatusName == null && other.PublishedStatusName == null) || (this.PublishedStatusName?.Equals(other.PublishedStatusName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocaleCode = {(this.LocaleCode == null ? "null" : this.LocaleCode)}");
            toStringOutput.Add($"this.PublishedStatusName = {(this.PublishedStatusName == null ? "null" : this.PublishedStatusName)}");
        }
    }
}