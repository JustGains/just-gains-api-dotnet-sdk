// <copyright file="EquipmentGroupTranslation.cs" company="APIMatic">
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
    /// EquipmentGroupTranslation.
    /// </summary>
    public class EquipmentGroupTranslation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentGroupTranslation"/> class.
        /// </summary>
        public EquipmentGroupTranslation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentGroupTranslation"/> class.
        /// </summary>
        /// <param name="localeCode">localeCode.</param>
        /// <param name="equipmentGroupName">equipmentGroupName.</param>
        /// <param name="equipmentGroupDescription">equipmentGroupDescription.</param>
        public EquipmentGroupTranslation(
            string localeCode,
            string equipmentGroupName,
            string equipmentGroupDescription = null)
        {
            this.LocaleCode = localeCode;
            this.EquipmentGroupName = equipmentGroupName;
            this.EquipmentGroupDescription = equipmentGroupDescription;
        }

        /// <summary>
        /// The locale code for this translation
        /// </summary>
        [JsonProperty("localeCode")]
        public string LocaleCode { get; set; }

        /// <summary>
        /// The translated name of the equipment group
        /// </summary>
        [JsonProperty("equipmentGroupName")]
        public string EquipmentGroupName { get; set; }

        /// <summary>
        /// The translated description of the equipment group
        /// </summary>
        [JsonProperty("equipmentGroupDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentGroupDescription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EquipmentGroupTranslation : ({string.Join(", ", toStringOutput)})";
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
            return obj is EquipmentGroupTranslation other &&                ((this.LocaleCode == null && other.LocaleCode == null) || (this.LocaleCode?.Equals(other.LocaleCode) == true)) &&
                ((this.EquipmentGroupName == null && other.EquipmentGroupName == null) || (this.EquipmentGroupName?.Equals(other.EquipmentGroupName) == true)) &&
                ((this.EquipmentGroupDescription == null && other.EquipmentGroupDescription == null) || (this.EquipmentGroupDescription?.Equals(other.EquipmentGroupDescription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocaleCode = {(this.LocaleCode == null ? "null" : this.LocaleCode)}");
            toStringOutput.Add($"this.EquipmentGroupName = {(this.EquipmentGroupName == null ? "null" : this.EquipmentGroupName)}");
            toStringOutput.Add($"this.EquipmentGroupDescription = {(this.EquipmentGroupDescription == null ? "null" : this.EquipmentGroupDescription)}");
        }
    }
}