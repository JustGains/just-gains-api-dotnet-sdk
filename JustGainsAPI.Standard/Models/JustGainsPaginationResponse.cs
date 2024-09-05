// <copyright file="JustGainsPaginationResponse.cs" company="APIMatic">
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
    /// JustGainsPaginationResponse.
    /// </summary>
    public class JustGainsPaginationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JustGainsPaginationResponse"/> class.
        /// </summary>
        public JustGainsPaginationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JustGainsPaginationResponse"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        /// <param name="data">data.</param>
        /// <param name="pagination">pagination.</param>
        public JustGainsPaginationResponse(
            string status,
            string message,
            object data,
            Models.Pagination pagination = null)
        {
            this.Status = status;
            this.Message = message;
            this.Data = data;
            this.Pagination = pagination;
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
        public object Data { get; set; }

        /// <summary>
        /// Gets or sets Pagination.
        /// </summary>
        [JsonProperty("pagination", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Pagination Pagination { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JustGainsPaginationResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is JustGainsPaginationResponse other &&                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Pagination == null && other.Pagination == null) || (this.Pagination?.Equals(other.Pagination) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"Data = {(this.Data == null ? "null" : this.Data.ToString())}");
            toStringOutput.Add($"this.Pagination = {(this.Pagination == null ? "null" : this.Pagination.ToString())}");
        }
    }
}