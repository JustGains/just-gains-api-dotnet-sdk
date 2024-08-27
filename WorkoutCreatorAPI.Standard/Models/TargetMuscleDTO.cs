// <copyright file="TargetMuscleDTO.cs" company="APIMatic">
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
    /// TargetMuscleDTO.
    /// </summary>
    public class TargetMuscleDTO
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetMuscleDTO"/> class.
        /// </summary>
        public TargetMuscleDTO()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetMuscleDTO"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="muscleName">muscle_name.</param>
        /// <param name="targetPercentage">target_percentage.</param>
        public TargetMuscleDTO(
            int? id = null,
            string muscleName = null,
            int? targetPercentage = null)
        {
            this.Id = id;
            this.MuscleName = muscleName;
            this.TargetPercentage = targetPercentage;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets MuscleName.
        /// </summary>
        [JsonProperty("muscle_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleName { get; set; }

        /// <summary>
        /// Gets or sets TargetPercentage.
        /// </summary>
        [JsonProperty("target_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetPercentage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TargetMuscleDTO : ({string.Join(", ", toStringOutput)})";
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
            return obj is TargetMuscleDTO other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.MuscleName == null && other.MuscleName == null) || (this.MuscleName?.Equals(other.MuscleName) == true)) &&
                ((this.TargetPercentage == null && other.TargetPercentage == null) || (this.TargetPercentage?.Equals(other.TargetPercentage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.MuscleName = {(this.MuscleName == null ? "null" : this.MuscleName)}");
            toStringOutput.Add($"this.TargetPercentage = {(this.TargetPercentage == null ? "null" : this.TargetPercentage.ToString())}");
        }
    }
}