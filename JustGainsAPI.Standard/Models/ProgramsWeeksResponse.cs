// <copyright file="ProgramsWeeksResponse.cs" company="APIMatic">
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
    /// ProgramsWeeksResponse.
    /// </summary>
    public class ProgramsWeeksResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramsWeeksResponse"/> class.
        /// </summary>
        public ProgramsWeeksResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramsWeeksResponse"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        public ProgramsWeeksResponse(
            object message = null)
        {
            this.Message = message;
        }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public object Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProgramsWeeksResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProgramsWeeksResponse other &&                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Message = {(this.Message == null ? "null" : this.Message.ToString())}");
        }
    }
}