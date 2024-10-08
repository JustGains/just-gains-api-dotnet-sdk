// <copyright file="Equipment.cs" company="APIMatic">
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
    /// Equipment.
    /// </summary>
    public class Equipment
    {
        private List<string> equipmentEquipmentGroups;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "equipmentEquipmentGroups", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Equipment"/> class.
        /// </summary>
        public Equipment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Equipment"/> class.
        /// </summary>
        /// <param name="equipmentCode">equipmentCode.</param>
        /// <param name="equipmentName">equipmentName.</param>
        /// <param name="equipmentThumbnail">equipmentThumbnail.</param>
        /// <param name="equipmentEquipmentGroups">equipmentEquipmentGroups.</param>
        public Equipment(
            string equipmentCode,
            string equipmentName = null,
            Models.MediaAsset equipmentThumbnail = null,
            List<string> equipmentEquipmentGroups = null)
        {
            this.EquipmentCode = equipmentCode;
            this.EquipmentName = equipmentName;
            this.EquipmentThumbnail = equipmentThumbnail;
            if (equipmentEquipmentGroups != null)
            {
                this.EquipmentEquipmentGroups = equipmentEquipmentGroups;
            }

        }

        /// <summary>
        /// A unique identifier for the equipment.
        /// </summary>
        [JsonProperty("equipmentCode")]
        public string EquipmentCode { get; set; }

        /// <summary>
        /// The name of the equipment, localized.
        /// </summary>
        [JsonProperty("equipmentName", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentName { get; set; }

        /// <summary>
        /// Gets or sets EquipmentThumbnail.
        /// </summary>
        [JsonProperty("equipmentThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset EquipmentThumbnail { get; set; }

        /// <summary>
        /// A list of equipment groups this equipment belongs to.
        /// </summary>
        [JsonProperty("equipmentEquipmentGroups")]
        public List<string> EquipmentEquipmentGroups
        {
            get
            {
                return this.equipmentEquipmentGroups;
            }

            set
            {
                this.shouldSerialize["equipmentEquipmentGroups"] = true;
                this.equipmentEquipmentGroups = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Equipment : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEquipmentEquipmentGroups()
        {
            this.shouldSerialize["equipmentEquipmentGroups"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEquipmentEquipmentGroups()
        {
            return this.shouldSerialize["equipmentEquipmentGroups"];
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
            return obj is Equipment other &&                ((this.EquipmentCode == null && other.EquipmentCode == null) || (this.EquipmentCode?.Equals(other.EquipmentCode) == true)) &&
                ((this.EquipmentName == null && other.EquipmentName == null) || (this.EquipmentName?.Equals(other.EquipmentName) == true)) &&
                ((this.EquipmentThumbnail == null && other.EquipmentThumbnail == null) || (this.EquipmentThumbnail?.Equals(other.EquipmentThumbnail) == true)) &&
                ((this.EquipmentEquipmentGroups == null && other.EquipmentEquipmentGroups == null) || (this.EquipmentEquipmentGroups?.Equals(other.EquipmentEquipmentGroups) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EquipmentCode = {(this.EquipmentCode == null ? "null" : this.EquipmentCode)}");
            toStringOutput.Add($"this.EquipmentName = {(this.EquipmentName == null ? "null" : this.EquipmentName)}");
            toStringOutput.Add($"this.EquipmentThumbnail = {(this.EquipmentThumbnail == null ? "null" : this.EquipmentThumbnail.ToString())}");
            toStringOutput.Add($"this.EquipmentEquipmentGroups = {(this.EquipmentEquipmentGroups == null ? "null" : $"[{string.Join(", ", this.EquipmentEquipmentGroups)} ]")}");
        }
    }
}