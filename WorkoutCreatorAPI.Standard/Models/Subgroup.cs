// <copyright file="Subgroup.cs" company="APIMatic">
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
    /// Subgroup.
    /// </summary>
    public class Subgroup
    {
        private string equipmentGroupParent;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "equipmentGroupParent", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Subgroup"/> class.
        /// </summary>
        public Subgroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subgroup"/> class.
        /// </summary>
        /// <param name="equipmentGroupCode">equipmentGroupCode.</param>
        /// <param name="equipmentGroupName">equipmentGroupName.</param>
        /// <param name="equipmentGroupType">equipmentGroupType.</param>
        /// <param name="equipmentGroupParent">equipmentGroupParent.</param>
        public Subgroup(
            string equipmentGroupCode = null,
            string equipmentGroupName = null,
            Models.EquipmentGroupTypeEnum? equipmentGroupType = null,
            string equipmentGroupParent = null)
        {
            this.EquipmentGroupCode = equipmentGroupCode;
            this.EquipmentGroupName = equipmentGroupName;
            this.EquipmentGroupType = equipmentGroupType;
            if (equipmentGroupParent != null)
            {
                this.EquipmentGroupParent = equipmentGroupParent;
            }

        }

        /// <summary>
        /// Unique identifier for the equipment group.
        /// </summary>
        [JsonProperty("equipmentGroupCode", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentGroupCode { get; set; }

        /// <summary>
        /// The localized name of the equipment group
        /// </summary>
        [JsonProperty("equipmentGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentGroupName { get; set; }

        /// <summary>
        /// Gets or sets EquipmentGroupType.
        /// </summary>
        [JsonProperty("equipmentGroupType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EquipmentGroupTypeEnum? EquipmentGroupType { get; set; }

        /// <summary>
        /// parent group CODE for hierarchical structuring.
        /// </summary>
        [JsonProperty("equipmentGroupParent")]
        public string EquipmentGroupParent
        {
            get
            {
                return this.equipmentGroupParent;
            }

            set
            {
                this.shouldSerialize["equipmentGroupParent"] = true;
                this.equipmentGroupParent = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Subgroup : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEquipmentGroupParent()
        {
            this.shouldSerialize["equipmentGroupParent"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEquipmentGroupParent()
        {
            return this.shouldSerialize["equipmentGroupParent"];
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
            return obj is Subgroup other &&                ((this.EquipmentGroupCode == null && other.EquipmentGroupCode == null) || (this.EquipmentGroupCode?.Equals(other.EquipmentGroupCode) == true)) &&
                ((this.EquipmentGroupName == null && other.EquipmentGroupName == null) || (this.EquipmentGroupName?.Equals(other.EquipmentGroupName) == true)) &&
                ((this.EquipmentGroupType == null && other.EquipmentGroupType == null) || (this.EquipmentGroupType?.Equals(other.EquipmentGroupType) == true)) &&
                ((this.EquipmentGroupParent == null && other.EquipmentGroupParent == null) || (this.EquipmentGroupParent?.Equals(other.EquipmentGroupParent) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EquipmentGroupCode = {(this.EquipmentGroupCode == null ? "null" : this.EquipmentGroupCode)}");
            toStringOutput.Add($"this.EquipmentGroupName = {(this.EquipmentGroupName == null ? "null" : this.EquipmentGroupName)}");
            toStringOutput.Add($"this.EquipmentGroupType = {(this.EquipmentGroupType == null ? "null" : this.EquipmentGroupType.ToString())}");
            toStringOutput.Add($"this.EquipmentGroupParent = {(this.EquipmentGroupParent == null ? "null" : this.EquipmentGroupParent)}");
        }
    }
}