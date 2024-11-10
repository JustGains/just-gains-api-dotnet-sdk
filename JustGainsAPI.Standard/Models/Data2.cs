// <copyright file="Data2.cs" company="APIMatic">
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
    /// Data2.
    /// </summary>
    public class Data2
    {
        private Guid? creatorProfileId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "creatorProfileId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Data2"/> class.
        /// </summary>
        public Data2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data2"/> class.
        /// </summary>
        /// <param name="isAvailable">isAvailable.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="validation">validation.</param>
        /// <param name="creatorProfileId">creatorProfileId.</param>
        public Data2(
            bool? isAvailable = null,
            bool? isValid = null,
            string validation = null,
            Guid? creatorProfileId = null)
        {
            this.IsAvailable = isAvailable;
            this.IsValid = isValid;
            this.Validation = validation;
            if (creatorProfileId != null)
            {
                this.CreatorProfileId = creatorProfileId;
            }

        }

        /// <summary>
        /// Whether the username is available
        /// </summary>
        [JsonProperty("isAvailable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// Whether the username is valid
        /// </summary>
        [JsonProperty("isValid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// The validation result
        /// </summary>
        [JsonProperty("validation", NullValueHandling = NullValueHandling.Ignore)]
        public string Validation { get; set; }

        /// <summary>
        /// The CreatorProfileId of the creator who has this username. Only present if isAvailable is false.
        /// </summary>
        [JsonProperty("creatorProfileId")]
        public Guid? CreatorProfileId
        {
            get
            {
                return this.creatorProfileId;
            }

            set
            {
                this.shouldSerialize["creatorProfileId"] = true;
                this.creatorProfileId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreatorProfileId()
        {
            this.shouldSerialize["creatorProfileId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreatorProfileId()
        {
            return this.shouldSerialize["creatorProfileId"];
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
            return obj is Data2 other &&                ((this.IsAvailable == null && other.IsAvailable == null) || (this.IsAvailable?.Equals(other.IsAvailable) == true)) &&
                ((this.IsValid == null && other.IsValid == null) || (this.IsValid?.Equals(other.IsValid) == true)) &&
                ((this.Validation == null && other.Validation == null) || (this.Validation?.Equals(other.Validation) == true)) &&
                ((this.CreatorProfileId == null && other.CreatorProfileId == null) || (this.CreatorProfileId?.Equals(other.CreatorProfileId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.IsAvailable = {(this.IsAvailable == null ? "null" : this.IsAvailable.ToString())}");
            toStringOutput.Add($"this.IsValid = {(this.IsValid == null ? "null" : this.IsValid.ToString())}");
            toStringOutput.Add($"this.Validation = {(this.Validation == null ? "null" : this.Validation)}");
            toStringOutput.Add($"this.CreatorProfileId = {(this.CreatorProfileId == null ? "null" : this.CreatorProfileId.ToString())}");
        }
    }
}