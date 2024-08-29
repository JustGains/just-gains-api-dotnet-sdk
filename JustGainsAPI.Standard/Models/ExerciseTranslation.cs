// <copyright file="ExerciseTranslation.cs" company="APIMatic">
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
    /// ExerciseTranslation.
    /// </summary>
    public class ExerciseTranslation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseTranslation"/> class.
        /// </summary>
        public ExerciseTranslation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseTranslation"/> class.
        /// </summary>
        /// <param name="localeCode">localeCode.</param>
        /// <param name="exerciseName">exerciseName.</param>
        /// <param name="isPrimary">isPrimary.</param>
        public ExerciseTranslation(
            string localeCode = null,
            string exerciseName = null,
            bool? isPrimary = null)
        {
            this.LocaleCode = localeCode;
            this.ExerciseName = exerciseName;
            this.IsPrimary = isPrimary;
        }

        /// <summary>
        /// The locale code of the translation
        /// </summary>
        [JsonProperty("localeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string LocaleCode { get; set; }

        /// <summary>
        /// Translated Primary Exercise Name for the chosen Locale
        /// </summary>
        [JsonProperty("exerciseName", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseName { get; set; }

        /// <summary>
        /// Is this the primary translation for the exercise in the chosen locale
        /// </summary>
        [JsonProperty("isPrimary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrimary { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseTranslation : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseTranslation other &&                ((this.LocaleCode == null && other.LocaleCode == null) || (this.LocaleCode?.Equals(other.LocaleCode) == true)) &&
                ((this.ExerciseName == null && other.ExerciseName == null) || (this.ExerciseName?.Equals(other.ExerciseName) == true)) &&
                ((this.IsPrimary == null && other.IsPrimary == null) || (this.IsPrimary?.Equals(other.IsPrimary) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocaleCode = {(this.LocaleCode == null ? "null" : this.LocaleCode)}");
            toStringOutput.Add($"this.ExerciseName = {(this.ExerciseName == null ? "null" : this.ExerciseName)}");
            toStringOutput.Add($"this.IsPrimary = {(this.IsPrimary == null ? "null" : this.IsPrimary.ToString())}");
        }
    }
}