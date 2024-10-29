// <copyright file="WorkoutContent.cs" company="APIMatic">
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
    /// WorkoutContent.
    /// </summary>
    public class WorkoutContent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutContent"/> class.
        /// </summary>
        public WorkoutContent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutContent"/> class.
        /// </summary>
        /// <param name="workoutID">workoutID.</param>
        /// <param name="workoutContentProp">workoutContent.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public WorkoutContent(
            Guid? workoutID = null,
            object workoutContentProp = null,
            DateTime? updatedAt = null)
        {
            this.WorkoutID = workoutID;
            this.WorkoutContentProp = workoutContentProp;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// The ID of the workout
        /// </summary>
        [JsonProperty("workoutID", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? WorkoutID { get; set; }

        /// <summary>
        /// The content of the workout (JSON formatted output from the JS Editor)
        /// </summary>
        [JsonProperty("workoutContent", NullValueHandling = NullValueHandling.Ignore)]
        public object WorkoutContentProp { get; set; }

        /// <summary>
        /// The date and time when the workout content was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WorkoutContent : ({string.Join(", ", toStringOutput)})";
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
            return obj is WorkoutContent other &&                ((this.WorkoutID == null && other.WorkoutID == null) || (this.WorkoutID?.Equals(other.WorkoutID) == true)) &&
                ((this.WorkoutContentProp == null && other.WorkoutContentProp == null) || (this.WorkoutContentProp?.Equals(other.WorkoutContentProp) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WorkoutID = {(this.WorkoutID == null ? "null" : this.WorkoutID.ToString())}");
            toStringOutput.Add($"WorkoutContentProp = {(this.WorkoutContentProp == null ? "null" : this.WorkoutContentProp.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
        }
    }
}