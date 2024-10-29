// <copyright file="WorkoutMuscleGroupsSecondary.cs" company="APIMatic">
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
    /// WorkoutMuscleGroupsSecondary.
    /// </summary>
    public class WorkoutMuscleGroupsSecondary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutMuscleGroupsSecondary"/> class.
        /// </summary>
        public WorkoutMuscleGroupsSecondary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutMuscleGroupsSecondary"/> class.
        /// </summary>
        /// <param name="muscleGroupCode">muscleGroupCode.</param>
        /// <param name="muscleGroupName">muscleGroupName.</param>
        /// <param name="muscleGroupThumbnail">muscleGroupThumbnail.</param>
        public WorkoutMuscleGroupsSecondary(
            string muscleGroupCode = null,
            string muscleGroupName = null,
            Models.MediaAsset muscleGroupThumbnail = null)
        {
            this.MuscleGroupCode = muscleGroupCode;
            this.MuscleGroupName = muscleGroupName;
            this.MuscleGroupThumbnail = muscleGroupThumbnail;
        }

        /// <summary>
        /// Unique identifier for the muscle group.
        /// </summary>
        [JsonProperty("muscleGroupCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleGroupCode { get; set; }

        /// <summary>
        /// Name of the muscle group, localized.
        /// </summary>
        [JsonProperty("muscleGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleGroupName { get; set; }

        /// <summary>
        /// Gets or sets MuscleGroupThumbnail.
        /// </summary>
        [JsonProperty("muscleGroupThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset MuscleGroupThumbnail { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WorkoutMuscleGroupsSecondary : ({string.Join(", ", toStringOutput)})";
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
            return obj is WorkoutMuscleGroupsSecondary other &&                ((this.MuscleGroupCode == null && other.MuscleGroupCode == null) || (this.MuscleGroupCode?.Equals(other.MuscleGroupCode) == true)) &&
                ((this.MuscleGroupName == null && other.MuscleGroupName == null) || (this.MuscleGroupName?.Equals(other.MuscleGroupName) == true)) &&
                ((this.MuscleGroupThumbnail == null && other.MuscleGroupThumbnail == null) || (this.MuscleGroupThumbnail?.Equals(other.MuscleGroupThumbnail) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MuscleGroupCode = {(this.MuscleGroupCode == null ? "null" : this.MuscleGroupCode)}");
            toStringOutput.Add($"this.MuscleGroupName = {(this.MuscleGroupName == null ? "null" : this.MuscleGroupName)}");
            toStringOutput.Add($"this.MuscleGroupThumbnail = {(this.MuscleGroupThumbnail == null ? "null" : this.MuscleGroupThumbnail.ToString())}");
        }
    }
}