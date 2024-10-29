// <copyright file="AuthCallbackResponse.cs" company="APIMatic">
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
    /// AuthCallbackResponse.
    /// </summary>
    public class AuthCallbackResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthCallbackResponse"/> class.
        /// </summary>
        public AuthCallbackResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthCallbackResponse"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        /// <param name="data">data.</param>
        public AuthCallbackResponse(
            string status,
            string message,
            Models.Data3 data)
        {
            this.Status = status;
            this.Message = message;
            this.Data = data;
        }

        /// <summary>
        /// The status of the response, corresponding to standard HTTP status codes.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// A human-readable message describing the result of the operation.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public Models.Data3 Data { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuthCallbackResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is AuthCallbackResponse other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
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
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data.ToString())}");
        }
    }
}