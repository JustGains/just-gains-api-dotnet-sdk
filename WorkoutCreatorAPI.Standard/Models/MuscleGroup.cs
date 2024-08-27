// <copyright file="MuscleGroup.cs" company="APIMatic">
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
    /// MuscleGroup.
    /// </summary>
    public class MuscleGroup
    {
        private string muscleGroupParent;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "muscleGroupParent", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MuscleGroup"/> class.
        /// </summary>
        public MuscleGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MuscleGroup"/> class.
        /// </summary>
        /// <param name="muscleGroupCode">muscleGroupCode.</param>
        /// <param name="muscleGroupName">muscleGroupName.</param>
        /// <param name="muscleGroupTranslations">muscleGroupTranslations.</param>
        /// <param name="muscleGroupParent">muscleGroupParent.</param>
        /// <param name="muscleGroupMuscles">muscleGroupMuscles.</param>
        /// <param name="muscleGroupType">muscleGroupType.</param>
        /// <param name="muscleGroupThumbnail">muscleGroupThumbnail.</param>
        public MuscleGroup(
            string muscleGroupCode = null,
            string muscleGroupName = null,
            List<Models.MuscleGroupTranslation> muscleGroupTranslations = null,
            string muscleGroupParent = null,
            List<string> muscleGroupMuscles = null,
            Models.MuscleGroupType5Enum? muscleGroupType = null,
            Models.MuscleGroupThumbnail1 muscleGroupThumbnail = null)
        {
            this.MuscleGroupCode = muscleGroupCode;
            this.MuscleGroupName = muscleGroupName;
            this.MuscleGroupTranslations = muscleGroupTranslations;
            if (muscleGroupParent != null)
            {
                this.MuscleGroupParent = muscleGroupParent;
            }

            this.MuscleGroupMuscles = muscleGroupMuscles;
            this.MuscleGroupType = muscleGroupType;
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
        /// Muscle Group Translations
        /// </summary>
        [JsonProperty("muscleGroupTranslations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MuscleGroupTranslation> MuscleGroupTranslations { get; set; }

        /// <summary>
        /// parent group CODE for hierarchical structuring.
        /// </summary>
        [JsonProperty("muscleGroupParent")]
        public string MuscleGroupParent
        {
            get
            {
                return this.muscleGroupParent;
            }

            set
            {
                this.shouldSerialize["muscleGroupParent"] = true;
                this.muscleGroupParent = value;
            }
        }

        /// <summary>
        /// An array of muscle codes associated with this muscle group.
        /// Each muscle code represents a specific muscle or muscle group targeted in exercises.
        /// The codes are used to identify muscles across different languages and provide
        /// consistency in muscle targeting for various exercises.
        /// </summary>
        [JsonProperty("muscleGroupMuscles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MuscleGroupMuscles { get; set; }

        /// <summary>
        /// Gets or sets MuscleGroupType.
        /// </summary>
        [JsonProperty("muscleGroupType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MuscleGroupType5Enum? MuscleGroupType { get; set; }

        /// <summary>
        /// Link to the thumbnail image for the muscle group.
        /// </summary>
        [JsonProperty("muscleGroupThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MuscleGroupThumbnail1 MuscleGroupThumbnail { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MuscleGroup : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMuscleGroupParent()
        {
            this.shouldSerialize["muscleGroupParent"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMuscleGroupParent()
        {
            return this.shouldSerialize["muscleGroupParent"];
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
            return obj is MuscleGroup other &&                ((this.MuscleGroupCode == null && other.MuscleGroupCode == null) || (this.MuscleGroupCode?.Equals(other.MuscleGroupCode) == true)) &&
                ((this.MuscleGroupName == null && other.MuscleGroupName == null) || (this.MuscleGroupName?.Equals(other.MuscleGroupName) == true)) &&
                ((this.MuscleGroupTranslations == null && other.MuscleGroupTranslations == null) || (this.MuscleGroupTranslations?.Equals(other.MuscleGroupTranslations) == true)) &&
                ((this.MuscleGroupParent == null && other.MuscleGroupParent == null) || (this.MuscleGroupParent?.Equals(other.MuscleGroupParent) == true)) &&
                ((this.MuscleGroupMuscles == null && other.MuscleGroupMuscles == null) || (this.MuscleGroupMuscles?.Equals(other.MuscleGroupMuscles) == true)) &&
                ((this.MuscleGroupType == null && other.MuscleGroupType == null) || (this.MuscleGroupType?.Equals(other.MuscleGroupType) == true)) &&
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
            toStringOutput.Add($"this.MuscleGroupTranslations = {(this.MuscleGroupTranslations == null ? "null" : $"[{string.Join(", ", this.MuscleGroupTranslations)} ]")}");
            toStringOutput.Add($"this.MuscleGroupParent = {(this.MuscleGroupParent == null ? "null" : this.MuscleGroupParent)}");
            toStringOutput.Add($"this.MuscleGroupMuscles = {(this.MuscleGroupMuscles == null ? "null" : $"[{string.Join(", ", this.MuscleGroupMuscles)} ]")}");
            toStringOutput.Add($"this.MuscleGroupType = {(this.MuscleGroupType == null ? "null" : this.MuscleGroupType.ToString())}");
            toStringOutput.Add($"this.MuscleGroupThumbnail = {(this.MuscleGroupThumbnail == null ? "null" : this.MuscleGroupThumbnail.ToString())}");
        }
    }
}