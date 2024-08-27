// <copyright file="Data46.cs" company="APIMatic">
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
    /// Data46.
    /// </summary>
    public class Data46
    {
        private string localeCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "localeCode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Data46"/> class.
        /// </summary>
        public Data46()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data46"/> class.
        /// </summary>
        /// <param name="localeCode">localeCode.</param>
        /// <param name="equipmentName">equipmentName.</param>
        public Data46(
            string localeCode = null,
            string equipmentName = null)
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
        [JsonProperty("equipmentName", NullValueHandling = NullValueHandling.Ignore)]
        public string EquipmentName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data46 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data46 other &&                ((this.LocaleCode == null && other.LocaleCode == null) || (this.LocaleCode?.Equals(other.LocaleCode) == true)) &&
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