// <copyright file="Muscle.cs" company="APIMatic">
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
    /// Muscle.
    /// </summary>
    public class Muscle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Muscle"/> class.
        /// </summary>
        public Muscle()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Muscle"/> class.
        /// </summary>
        /// <param name="muscleCode">muscleCode.</param>
        /// <param name="muscleName">muscleName.</param>
        public Muscle(
            string muscleCode,
            string muscleName = null)
        {
            this.MuscleCode = muscleCode;
            this.MuscleName = muscleName;
        }

        /// <summary>
        /// Unique identifier for the muscle
        /// </summary>
        [JsonProperty("muscleCode")]
        public string MuscleCode { get; set; }

        /// <summary>
        /// The name of the muscle in the default language (typically English)
        /// </summary>
        [JsonProperty("muscleName", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Muscle : ({string.Join(", ", toStringOutput)})";
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
            return obj is Muscle other &&                ((this.MuscleCode == null && other.MuscleCode == null) || (this.MuscleCode?.Equals(other.MuscleCode) == true)) &&
                ((this.MuscleName == null && other.MuscleName == null) || (this.MuscleName?.Equals(other.MuscleName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MuscleCode = {(this.MuscleCode == null ? "null" : this.MuscleCode)}");
            toStringOutput.Add($"this.MuscleName = {(this.MuscleName == null ? "null" : this.MuscleName)}");
        }
    }
}