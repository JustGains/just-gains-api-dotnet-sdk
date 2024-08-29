// <copyright file="EquipmentGroup.cs" company="APIMatic">
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
    /// EquipmentGroup.
    /// </summary>
    public class EquipmentGroup
    {
        private string equipmentGroupParent;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "equipmentGroupParent", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentGroup"/> class.
        /// </summary>
        public EquipmentGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentGroup"/> class.
        /// </summary>
        /// <param name="equipmentGroupCode">equipmentGroupCode.</param>
        /// <param name="equipmentGroupName">equipmentGroupName.</param>
        /// <param name="equipmentGroupParent">equipmentGroupParent.</param>
        /// <param name="equipmentGroupEquipment">equipmentGroupEquipment.</param>
        /// <param name="equipmentThumbnail">equipmentThumbnail.</param>
        /// <param name="sortOrder">sortOrder.</param>
        public EquipmentGroup(
            string equipmentGroupCode = null,
            string equipmentGroupName = null,
            string equipmentGroupParent = null,
            List<string> equipmentGroupEquipment = null,
            Models.MediaAsset equipmentThumbnail = null,
            int? sortOrder = 0)
        {
            this.EquipmentGroupCode = equipmentGroupCode;
            this.EquipmentGroupName = equipmentGroupName;
            if (equipmentGroupParent != null)
            {
                this.EquipmentGroupParent = equipmentGroupParent;
            }

            this.EquipmentGroupEquipment = equipmentGroupEquipment;
            this.EquipmentThumbnail = equipmentThumbnail;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Unique identifier for the equipment group.
        /// </summary>
        [JsonProperty("equipmentGroupCode", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentGroupCode { get; set; }

        /// <summary>
        /// Name of the equipment group, localized.
        /// </summary>
        [JsonProperty("equipmentGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentGroupName { get; set; }

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

        /// <summary>
        /// Gets or sets EquipmentGroupEquipment.
        /// </summary>
        [JsonProperty("equipmentGroupEquipment", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EquipmentGroupEquipment { get; set; }

        /// <summary>
        /// Gets or sets EquipmentThumbnail.
        /// </summary>
        [JsonProperty("equipmentThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset EquipmentThumbnail { get; set; }

        /// <summary>
        /// Used to sort the equipment groups
        /// </summary>
        [JsonProperty("sortOrder", NullValueHandling = NullValueHandling.Ignore)]
        public int? SortOrder { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EquipmentGroup : ({string.Join(", ", toStringOutput)})";
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
            return obj is EquipmentGroup other &&                ((this.EquipmentGroupCode == null && other.EquipmentGroupCode == null) || (this.EquipmentGroupCode?.Equals(other.EquipmentGroupCode) == true)) &&
                ((this.EquipmentGroupName == null && other.EquipmentGroupName == null) || (this.EquipmentGroupName?.Equals(other.EquipmentGroupName) == true)) &&
                ((this.EquipmentGroupParent == null && other.EquipmentGroupParent == null) || (this.EquipmentGroupParent?.Equals(other.EquipmentGroupParent) == true)) &&
                ((this.EquipmentGroupEquipment == null && other.EquipmentGroupEquipment == null) || (this.EquipmentGroupEquipment?.Equals(other.EquipmentGroupEquipment) == true)) &&
                ((this.EquipmentThumbnail == null && other.EquipmentThumbnail == null) || (this.EquipmentThumbnail?.Equals(other.EquipmentThumbnail) == true)) &&
                ((this.SortOrder == null && other.SortOrder == null) || (this.SortOrder?.Equals(other.SortOrder) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EquipmentGroupCode = {(this.EquipmentGroupCode == null ? "null" : this.EquipmentGroupCode)}");
            toStringOutput.Add($"this.EquipmentGroupName = {(this.EquipmentGroupName == null ? "null" : this.EquipmentGroupName)}");
            toStringOutput.Add($"this.EquipmentGroupParent = {(this.EquipmentGroupParent == null ? "null" : this.EquipmentGroupParent)}");
            toStringOutput.Add($"this.EquipmentGroupEquipment = {(this.EquipmentGroupEquipment == null ? "null" : $"[{string.Join(", ", this.EquipmentGroupEquipment)} ]")}");
            toStringOutput.Add($"this.EquipmentThumbnail = {(this.EquipmentThumbnail == null ? "null" : this.EquipmentThumbnail.ToString())}");
            toStringOutput.Add($"this.SortOrder = {(this.SortOrder == null ? "null" : this.SortOrder.ToString())}");
        }
    }
}