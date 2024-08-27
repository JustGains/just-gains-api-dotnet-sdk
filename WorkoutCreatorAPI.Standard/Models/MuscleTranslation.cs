// <copyright file="MuscleTranslation.cs" company="APIMatic">
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
    /// MuscleTranslation.
    /// </summary>
    public class MuscleTranslation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MuscleTranslation"/> class.
        /// </summary>
        public MuscleTranslation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MuscleTranslation"/> class.
        /// </summary>
        /// <param name="muscleCode">muscleCode.</param>
        /// <param name="localeCode">localeCode.</param>
        /// <param name="muscleName">muscleName.</param>
        public MuscleTranslation(
            string muscleCode,
            string localeCode,
            string muscleName = null)
        {
            this.MuscleCode = muscleCode;
            this.LocaleCode = localeCode;
            this.MuscleName = muscleName;
        }

        /// <summary>
        /// The muscle code of the translation
        /// </summary>
        [JsonProperty("muscleCode")]
        public string MuscleCode { get; set; }

        /// <summary>
        /// The locale code of the translation
        /// </summary>
        [JsonProperty("localeCode")]
        public string LocaleCode { get; set; }

        /// <summary>
        /// The translated name of the muscle
        /// </summary>
        [JsonProperty("muscleName", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MuscleTranslation : ({string.Join(", ", toStringOutput)})";
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
            return obj is MuscleTranslation other &&                ((this.MuscleCode == null && other.MuscleCode == null) || (this.MuscleCode?.Equals(other.MuscleCode) == true)) &&
                ((this.LocaleCode == null && other.LocaleCode == null) || (this.LocaleCode?.Equals(other.LocaleCode) == true)) &&
                ((this.MuscleName == null && other.MuscleName == null) || (this.MuscleName?.Equals(other.MuscleName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MuscleCode = {(this.MuscleCode == null ? "null" : this.MuscleCode)}");
            toStringOutput.Add($"this.LocaleCode = {(this.LocaleCode == null ? "null" : this.LocaleCode)}");
            toStringOutput.Add($"this.MuscleName = {(this.MuscleName == null ? "null" : this.MuscleName)}");
        }
    }
}