// <copyright file="JustGainsDefaultResponse.cs" company="APIMatic">
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
    /// JustGainsDefaultResponse.
    /// </summary>
    public class JustGainsDefaultResponse
    {
        private List<string> errors;
        private object data;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "errors", false },
            { "Data", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="JustGainsDefaultResponse"/> class.
        /// </summary>
        public JustGainsDefaultResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JustGainsDefaultResponse"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        /// <param name="errors">errors.</param>
        /// <param name="data">Data.</param>
        public JustGainsDefaultResponse(
            string status,
            string message,
            List<string> errors = null,
            object data = null)
        {
            this.Status = status;
            this.Message = message;
            if (errors != null)
            {
                this.Errors = errors;
            }

            if (data != null)
            {
                this.Data = data;
            }

        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Error Responses
        /// </summary>
        [JsonProperty("errors")]
        public List<string> Errors
        {
            get
            {
                return this.errors;
            }

            set
            {
                this.shouldSerialize["errors"] = true;
                this.errors = value;
            }
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("Data")]
        public object Data
        {
            get
            {
                return this.data;
            }

            set
            {
                this.shouldSerialize["Data"] = true;
                this.data = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JustGainsDefaultResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetErrors()
        {
            this.shouldSerialize["errors"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetData()
        {
            this.shouldSerialize["Data"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrors()
        {
            return this.shouldSerialize["errors"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeData()
        {
            return this.shouldSerialize["Data"];
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
            return obj is JustGainsDefaultResponse other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.Errors = {(this.Errors == null ? "null" : $"[{string.Join(", ", this.Errors)} ]")}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}