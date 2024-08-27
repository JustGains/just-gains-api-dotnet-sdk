// <copyright file="Locale.cs" company="APIMatic">
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
    /// Locale.
    /// </summary>
    public class Locale
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Locale"/> class.
        /// </summary>
        public Locale()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Locale"/> class.
        /// </summary>
        /// <param name="localeCode">localeCode.</param>
        /// <param name="localeName">localeName.</param>
        /// <param name="published">published.</param>
        /// <param name="localeIcon">localeIcon.</param>
        public Locale(
            string localeCode = null,
            string localeName = null,
            bool? published = null,
            Models.LocaleIcon localeIcon = null)
        {
            this.LocaleCode = localeCode;
            this.LocaleName = localeName;
            this.Published = published;
            this.LocaleIcon = localeIcon;
        }

        /// <summary>
        /// A unique code for the locale.
        /// </summary>
        [JsonProperty("localeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string LocaleCode { get; set; }

        /// <summary>
        /// The name of the locale.
        /// </summary>
        [JsonProperty("localeName", NullValueHandling = NullValueHandling.Ignore)]
        public string LocaleName { get; set; }

        /// <summary>
        /// Indicates whether the locale is published.
        /// </summary>
        [JsonProperty("published", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Published { get; set; }

        /// <summary>
        /// The icon associated with this locale.
        /// </summary>
        [JsonProperty("localeIcon", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LocaleIcon LocaleIcon { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Locale : ({string.Join(", ", toStringOutput)})";
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
            return obj is Locale other &&                ((this.LocaleCode == null && other.LocaleCode == null) || (this.LocaleCode?.Equals(other.LocaleCode) == true)) &&
                ((this.LocaleName == null && other.LocaleName == null) || (this.LocaleName?.Equals(other.LocaleName) == true)) &&
                ((this.Published == null && other.Published == null) || (this.Published?.Equals(other.Published) == true)) &&
                ((this.LocaleIcon == null && other.LocaleIcon == null) || (this.LocaleIcon?.Equals(other.LocaleIcon) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocaleCode = {(this.LocaleCode == null ? "null" : this.LocaleCode)}");
            toStringOutput.Add($"this.LocaleName = {(this.LocaleName == null ? "null" : this.LocaleName)}");
            toStringOutput.Add($"this.Published = {(this.Published == null ? "null" : this.Published.ToString())}");
            toStringOutput.Add($"this.LocaleIcon = {(this.LocaleIcon == null ? "null" : this.LocaleIcon.ToString())}");
        }
    }
}