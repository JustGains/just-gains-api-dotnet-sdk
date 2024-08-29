// <copyright file="MuscleGroupTranslation.cs" company="APIMatic">
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
    /// MuscleGroupTranslation.
    /// </summary>
    public class MuscleGroupTranslation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MuscleGroupTranslation"/> class.
        /// </summary>
        public MuscleGroupTranslation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MuscleGroupTranslation"/> class.
        /// </summary>
        /// <param name="localeCode">localeCode.</param>
        /// <param name="muscleGroupName">muscleGroupName.</param>
        /// <param name="muscleGroupDescription">muscleGroupDescription.</param>
        public MuscleGroupTranslation(
            string localeCode,
            string muscleGroupName,
            string muscleGroupDescription = null)
        {
            this.LocaleCode = localeCode;
            this.MuscleGroupName = muscleGroupName;
            this.MuscleGroupDescription = muscleGroupDescription;
        }

        /// <summary>
        /// The locale code for this translation (e.g., 'en-US', 'es-ES')
        /// </summary>
        [JsonProperty("localeCode")]
        public string LocaleCode { get; set; }

        /// <summary>
        /// The translated name of the muscle group
        /// </summary>
        [JsonProperty("muscleGroupName")]
        public string MuscleGroupName { get; set; }

        /// <summary>
        /// The translated description of the muscle group (optional)
        /// </summary>
        [JsonProperty("muscleGroupDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleGroupDescription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MuscleGroupTranslation : ({string.Join(", ", toStringOutput)})";
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
            return obj is MuscleGroupTranslation other &&                ((this.LocaleCode == null && other.LocaleCode == null) || (this.LocaleCode?.Equals(other.LocaleCode) == true)) &&
                ((this.MuscleGroupName == null && other.MuscleGroupName == null) || (this.MuscleGroupName?.Equals(other.MuscleGroupName) == true)) &&
                ((this.MuscleGroupDescription == null && other.MuscleGroupDescription == null) || (this.MuscleGroupDescription?.Equals(other.MuscleGroupDescription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocaleCode = {(this.LocaleCode == null ? "null" : this.LocaleCode)}");
            toStringOutput.Add($"this.MuscleGroupName = {(this.MuscleGroupName == null ? "null" : this.MuscleGroupName)}");
            toStringOutput.Add($"this.MuscleGroupDescription = {(this.MuscleGroupDescription == null ? "null" : this.MuscleGroupDescription)}");
        }
    }
}