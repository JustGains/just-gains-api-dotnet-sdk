// <copyright file="ExercisesVideosResponse2.cs" company="APIMatic">
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
    /// ExercisesVideosResponse2.
    /// </summary>
    public class ExercisesVideosResponse2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExercisesVideosResponse2"/> class.
        /// </summary>
        public ExercisesVideosResponse2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExercisesVideosResponse2"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="message">message.</param>
        public ExercisesVideosResponse2(
            List<Models.ExerciseVideoResponse> data = null,
            object message = null)
        {
            this.Data = data;
            this.Message = message;
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ExerciseVideoResponse> Data { get; set; }

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

            return $"ExercisesVideosResponse2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExercisesVideosResponse2 other &&                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"Message = {(this.Message == null ? "null" : this.Message.ToString())}");
        }
    }
}