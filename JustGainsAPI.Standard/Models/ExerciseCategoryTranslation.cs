// <copyright file="ExerciseCategoryTranslation.cs" company="APIMatic">
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
    /// ExerciseCategoryTranslation.
    /// </summary>
    public class ExerciseCategoryTranslation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseCategoryTranslation"/> class.
        /// </summary>
        public ExerciseCategoryTranslation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseCategoryTranslation"/> class.
        /// </summary>
        /// <param name="localeCode">localeCode.</param>
        /// <param name="exerciseCategoryName">exerciseCategoryName.</param>
        public ExerciseCategoryTranslation(
            string localeCode,
            string exerciseCategoryName)
        {
            this.LocaleCode = localeCode;
            this.ExerciseCategoryName = exerciseCategoryName;
        }

        /// <summary>
        /// The locale code for this translation (e.g., 'en-US', 'es-ES').
        /// </summary>
        [JsonProperty("localeCode")]
        public string LocaleCode { get; set; }

        /// <summary>
        /// The translated name of the exercise category in the specified locale.
        /// </summary>
        [JsonProperty("exerciseCategoryName")]
        public string ExerciseCategoryName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseCategoryTranslation : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseCategoryTranslation other &&                ((this.LocaleCode == null && other.LocaleCode == null) || (this.LocaleCode?.Equals(other.LocaleCode) == true)) &&
                ((this.ExerciseCategoryName == null && other.ExerciseCategoryName == null) || (this.ExerciseCategoryName?.Equals(other.ExerciseCategoryName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocaleCode = {(this.LocaleCode == null ? "null" : this.LocaleCode)}");
            toStringOutput.Add($"this.ExerciseCategoryName = {(this.ExerciseCategoryName == null ? "null" : this.ExerciseCategoryName)}");
        }
    }
}