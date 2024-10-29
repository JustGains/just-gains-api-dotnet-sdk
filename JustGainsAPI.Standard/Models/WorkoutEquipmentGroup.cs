// <copyright file="WorkoutEquipmentGroup.cs" company="APIMatic">
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
    /// WorkoutEquipmentGroup.
    /// </summary>
    public class WorkoutEquipmentGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutEquipmentGroup"/> class.
        /// </summary>
        public WorkoutEquipmentGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutEquipmentGroup"/> class.
        /// </summary>
        /// <param name="equipmentCode">equipmentCode.</param>
        /// <param name="equipmentName">equipmentName.</param>
        /// <param name="equipmentThumbnail">equipmentThumbnail.</param>
        public WorkoutEquipmentGroup(
            string equipmentCode = null,
            string equipmentName = null,
            Models.MediaAsset equipmentThumbnail = null)
        {
            this.EquipmentCode = equipmentCode;
            this.EquipmentName = equipmentName;
            this.EquipmentThumbnail = equipmentThumbnail;
        }

        /// <summary>
        /// Unique identifier for the equipment.
        /// </summary>
        [JsonProperty("equipmentCode", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentCode { get; set; }

        /// <summary>
        /// Name of the equipment, localized.
        /// </summary>
        [JsonProperty("equipmentName", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentName { get; set; }

        /// <summary>
        /// Gets or sets EquipmentThumbnail.
        /// </summary>
        [JsonProperty("equipmentThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset EquipmentThumbnail { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WorkoutEquipmentGroup : ({string.Join(", ", toStringOutput)})";
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
            return obj is WorkoutEquipmentGroup other &&                ((this.EquipmentCode == null && other.EquipmentCode == null) || (this.EquipmentCode?.Equals(other.EquipmentCode) == true)) &&
                ((this.EquipmentName == null && other.EquipmentName == null) || (this.EquipmentName?.Equals(other.EquipmentName) == true)) &&
                ((this.EquipmentThumbnail == null && other.EquipmentThumbnail == null) || (this.EquipmentThumbnail?.Equals(other.EquipmentThumbnail) == true));
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
        }
    }
}