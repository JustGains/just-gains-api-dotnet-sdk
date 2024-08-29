// <copyright file="EquipmentTranslation.cs" company="APIMatic">
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
    /// EquipmentTranslation.
    /// </summary>
    public class EquipmentTranslation
    {
        private string localeCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "localeCode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentTranslation"/> class.
        /// </summary>
        public EquipmentTranslation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentTranslation"/> class.
        /// </summary>
        /// <param name="equipmentName">equipmentName.</param>
        /// <param name="localeCode">localeCode.</param>
        public EquipmentTranslation(
            string equipmentName,
            string localeCode = null)
        {
            if (localeCode != null)
            {
                this.LocaleCode = localeCode;
            }

            this.EquipmentName = equipmentName;
        }

        /// <summary>
        /// Gets or sets LocaleCode.
        /// </summary>
        [JsonProperty("localeCode")]
        public string LocaleCode
        {
            get
            {
                return this.localeCode;
            }

            set
            {
                this.shouldSerialize["localeCode"] = true;
                this.localeCode = value;
            }
        }

        /// <summary>
        /// Gets or sets EquipmentName.
        /// </summary>
        [JsonProperty("equipmentName")]
        public string EquipmentName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EquipmentTranslation : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocaleCode()
        {
            this.shouldSerialize["localeCode"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocaleCode()
        {
            return this.shouldSerialize["localeCode"];
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
            return obj is EquipmentTranslation other &&                ((this.LocaleCode == null && other.LocaleCode == null) || (this.LocaleCode?.Equals(other.LocaleCode) == true)) &&
                ((this.EquipmentName == null && other.EquipmentName == null) || (this.EquipmentName?.Equals(other.EquipmentName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocaleCode = {(this.LocaleCode == null ? "null" : this.LocaleCode)}");
            toStringOutput.Add($"this.EquipmentName = {(this.EquipmentName == null ? "null" : this.EquipmentName)}");
        }
    }
}