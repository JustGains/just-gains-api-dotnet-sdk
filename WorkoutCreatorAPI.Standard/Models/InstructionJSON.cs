// <copyright file="InstructionJSON.cs" company="APIMatic">
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
    /// InstructionJSON.
    /// </summary>
    public class InstructionJSON
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstructionJSON"/> class.
        /// </summary>
        public InstructionJSON()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstructionJSON"/> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="blocks">blocks.</param>
        /// <param name="version">version.</param>
        public InstructionJSON(
            long? time = null,
            List<Models.InstructionBlock> blocks = null,
            string version = null)
        {
            this.Time = time;
            this.Blocks = blocks;
            this.Version = version;
        }

        /// <summary>
        /// Gets or sets Time.
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public long? Time { get; set; }

        /// <summary>
        /// Gets or sets Blocks.
        /// </summary>
        [JsonProperty("blocks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InstructionBlock> Blocks { get; set; }

        /// <summary>
        /// Gets or sets Version.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstructionJSON : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstructionJSON other &&                ((this.Time == null && other.Time == null) || (this.Time?.Equals(other.Time) == true)) &&
                ((this.Blocks == null && other.Blocks == null) || (this.Blocks?.Equals(other.Blocks) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Time = {(this.Time == null ? "null" : this.Time.ToString())}");
            toStringOutput.Add($"this.Blocks = {(this.Blocks == null ? "null" : $"[{string.Join(", ", this.Blocks)} ]")}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
        }
    }
}