// <copyright file="Subgroup4.cs" company="APIMatic">
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
    /// Subgroup4.
    /// </summary>
    public class Subgroup4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subgroup4"/> class.
        /// </summary>
        public Subgroup4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subgroup4"/> class.
        /// </summary>
        /// <param name="muscleGroupCode">muscleGroupCode.</param>
        /// <param name="muscleGroupName">muscleGroupName.</param>
        /// <param name="muscleGroupType">muscleGroupType.</param>
        public Subgroup4(
            string muscleGroupCode = null,
            string muscleGroupName = null,
            Models.MuscleGroupType4Enum? muscleGroupType = null)
        {
            this.MuscleGroupCode = muscleGroupCode;
            this.MuscleGroupName = muscleGroupName;
            this.MuscleGroupType = muscleGroupType;
        }

        /// <summary>
        /// The unique code of the muscle subgroup
        /// </summary>
        [JsonProperty("muscleGroupCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleGroupCode { get; set; }

        /// <summary>
        /// The localized name of the muscle subgroup
        /// </summary>
        [JsonProperty("muscleGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleGroupName { get; set; }

        /// <summary>
        /// Gets or sets MuscleGroupType.
        /// </summary>
        [JsonProperty("muscleGroupType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MuscleGroupType4Enum? MuscleGroupType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Subgroup4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Subgroup4 other &&                ((this.MuscleGroupCode == null && other.MuscleGroupCode == null) || (this.MuscleGroupCode?.Equals(other.MuscleGroupCode) == true)) &&
                ((this.MuscleGroupName == null && other.MuscleGroupName == null) || (this.MuscleGroupName?.Equals(other.MuscleGroupName) == true)) &&
                ((this.MuscleGroupType == null && other.MuscleGroupType == null) || (this.MuscleGroupType?.Equals(other.MuscleGroupType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MuscleGroupCode = {(this.MuscleGroupCode == null ? "null" : this.MuscleGroupCode)}");
            toStringOutput.Add($"this.MuscleGroupName = {(this.MuscleGroupName == null ? "null" : this.MuscleGroupName)}");
            toStringOutput.Add($"this.MuscleGroupType = {(this.MuscleGroupType == null ? "null" : this.MuscleGroupType.ToString())}");
        }
    }
}