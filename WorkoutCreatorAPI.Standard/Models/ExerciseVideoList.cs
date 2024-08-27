// <copyright file="ExerciseVideoList.cs" company="APIMatic">
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
    /// ExerciseVideoList.
    /// </summary>
    public class ExerciseVideoList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseVideoList"/> class.
        /// </summary>
        public ExerciseVideoList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseVideoList"/> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="dateUpdated">dateUpdated.</param>
        /// <param name="dateCreated">dateCreated.</param>
        public ExerciseVideoList(
            string userId = null,
            DateTime? dateUpdated = null,
            DateTime? dateCreated = null)
        {
            this.UserId = userId;
            this.DateUpdated = dateUpdated;
            this.DateCreated = dateCreated;
        }

        /// <summary>
        /// Gets or sets UserId.
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets DateUpdated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateUpdated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets DateCreated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("dateCreated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateCreated { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseVideoList : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseVideoList other &&                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.DateUpdated == null && other.DateUpdated == null) || (this.DateUpdated?.Equals(other.DateUpdated) == true)) &&
                ((this.DateCreated == null && other.DateCreated == null) || (this.DateCreated?.Equals(other.DateCreated) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId)}");
            toStringOutput.Add($"this.DateUpdated = {(this.DateUpdated == null ? "null" : this.DateUpdated.ToString())}");
            toStringOutput.Add($"this.DateCreated = {(this.DateCreated == null ? "null" : this.DateCreated.ToString())}");
        }
    }
}