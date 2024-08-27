// <copyright file="MuscleGroupList.cs" company="APIMatic">
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
    /// MuscleGroupList.
    /// </summary>
    public class MuscleGroupList
    {
        private string muscleGroupParent;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "muscleGroupParent", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MuscleGroupList"/> class.
        /// </summary>
        public MuscleGroupList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MuscleGroupList"/> class.
        /// </summary>
        /// <param name="muscleGroupCode">muscleGroupCode.</param>
        /// <param name="muscleGroupName">muscleGroupName.</param>
        /// <param name="muscleGroupType">muscleGroupType.</param>
        /// <param name="muscleGroupParent">muscleGroupParent.</param>
        /// <param name="subgroups">subgroups.</param>
        /// <param name="muscleGroupMuscles">muscleGroupMuscles.</param>
        /// <param name="muscleGroupThumbnail">muscleGroupThumbnail.</param>
        public MuscleGroupList(
            string muscleGroupCode = null,
            string muscleGroupName = null,
            Models.MuscleGroupTypeEnum? muscleGroupType = null,
            string muscleGroupParent = null,
            List<Models.Subgroup1> subgroups = null,
            List<string> muscleGroupMuscles = null,
            Models.MediaAsset muscleGroupThumbnail = null)
        {
            this.MuscleGroupCode = muscleGroupCode;
            this.MuscleGroupName = muscleGroupName;
            this.MuscleGroupType = muscleGroupType;
            if (muscleGroupParent != null)
            {
                this.MuscleGroupParent = muscleGroupParent;
            }

            this.Subgroups = subgroups;
            this.MuscleGroupMuscles = muscleGroupMuscles;
            this.MuscleGroupThumbnail = muscleGroupThumbnail;
        }

        /// <summary>
        /// The unique code of the muscle group
        /// </summary>
        [JsonProperty("muscleGroupCode", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleGroupCode { get; set; }

        /// <summary>
        /// The localized name of the muscle group
        /// </summary>
        [JsonProperty("muscleGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string MuscleGroupName { get; set; }

        /// <summary>
        /// Gets or sets MuscleGroupType.
        /// </summary>
        [JsonProperty("muscleGroupType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MuscleGroupTypeEnum? MuscleGroupType { get; set; }

        /// <summary>
        /// The code of the muscle group that is the parent of this group
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
        /// Gets or sets Subgroups.
        /// </summary>
        [JsonProperty("subgroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Subgroup1> Subgroups { get; set; }

        /// <summary>
        /// An array of muscle codes associated with this muscle group.
        /// Each muscle code represents a specific muscle or muscle group targeted in exercises.
        /// The codes are used to identify muscles across different languages and provide
        /// consistency in muscle targeting for various exercises.
        /// </summary>
        [JsonProperty("muscleGroupMuscles", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MuscleGroupMuscles { get; set; }

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

            return $"MuscleGroupList : ({string.Join(", ", toStringOutput)})";
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
            return obj is MuscleGroupList other &&                ((this.MuscleGroupCode == null && other.MuscleGroupCode == null) || (this.MuscleGroupCode?.Equals(other.MuscleGroupCode) == true)) &&
                ((this.MuscleGroupName == null && other.MuscleGroupName == null) || (this.MuscleGroupName?.Equals(other.MuscleGroupName) == true)) &&
                ((this.MuscleGroupType == null && other.MuscleGroupType == null) || (this.MuscleGroupType?.Equals(other.MuscleGroupType) == true)) &&
                ((this.MuscleGroupParent == null && other.MuscleGroupParent == null) || (this.MuscleGroupParent?.Equals(other.MuscleGroupParent) == true)) &&
                ((this.Subgroups == null && other.Subgroups == null) || (this.Subgroups?.Equals(other.Subgroups) == true)) &&
                ((this.MuscleGroupMuscles == null && other.MuscleGroupMuscles == null) || (this.MuscleGroupMuscles?.Equals(other.MuscleGroupMuscles) == true)) &&
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
            toStringOutput.Add($"this.MuscleGroupType = {(this.MuscleGroupType == null ? "null" : this.MuscleGroupType.ToString())}");
            toStringOutput.Add($"this.MuscleGroupParent = {(this.MuscleGroupParent == null ? "null" : this.MuscleGroupParent)}");
            toStringOutput.Add($"this.Subgroups = {(this.Subgroups == null ? "null" : $"[{string.Join(", ", this.Subgroups)} ]")}");
            toStringOutput.Add($"this.MuscleGroupMuscles = {(this.MuscleGroupMuscles == null ? "null" : $"[{string.Join(", ", this.MuscleGroupMuscles)} ]")}");
            toStringOutput.Add($"this.MuscleGroupThumbnail = {(this.MuscleGroupThumbnail == null ? "null" : this.MuscleGroupThumbnail.ToString())}");
        }
    }
}