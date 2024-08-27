// <copyright file="Data25.cs" company="APIMatic">
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
    /// Data25.
    /// </summary>
    public class Data25
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data25"/> class.
        /// </summary>
        public Data25()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data25"/> class.
        /// </summary>
        /// <param name="muscleCode">muscleCode.</param>
        /// <param name="muscleName">muscleName.</param>
        /// <param name="muscleTranslations">muscleTranslations.</param>
        public Data25(
            string muscleCode = null,
            string muscleName = null,
            List<Models.MuscleTranslation> muscleTranslations = null)
        {
            this.MuscleCode = muscleCode;
            this.MuscleName = muscleName;
            this.MuscleTranslations = muscleTranslations;
        }

        /// <summary>
        /// Unique identifier for the muscle
        /// </summary>
        [JsonProperty("muscleCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleCode { get; set; }

        /// <summary>
        /// The name of the muscle in the default language (typically English)
        /// </summary>
        [JsonProperty("muscleName", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleName { get; set; }

        /// <summary>
        /// Array of translations for the muscle name in different languages. This is a write-only field used when creating or updating muscles.
        /// </summary>
        [JsonProperty("muscleTranslations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MuscleTranslation> MuscleTranslations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data25 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data25 other &&                ((this.MuscleCode == null && other.MuscleCode == null) || (this.MuscleCode?.Equals(other.MuscleCode) == true)) &&
                ((this.MuscleName == null && other.MuscleName == null) || (this.MuscleName?.Equals(other.MuscleName) == true)) &&
                ((this.MuscleTranslations == null && other.MuscleTranslations == null) || (this.MuscleTranslations?.Equals(other.MuscleTranslations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MuscleCode = {(this.MuscleCode == null ? "null" : this.MuscleCode)}");
            toStringOutput.Add($"this.MuscleName = {(this.MuscleName == null ? "null" : this.MuscleName)}");
            toStringOutput.Add($"this.MuscleTranslations = {(this.MuscleTranslations == null ? "null" : $"[{string.Join(", ", this.MuscleTranslations)} ]")}");
        }
    }
}