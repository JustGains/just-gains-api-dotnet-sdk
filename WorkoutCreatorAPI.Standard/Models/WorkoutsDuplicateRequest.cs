// <copyright file="WorkoutsDuplicateRequest.cs" company="APIMatic">
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
    /// WorkoutsDuplicateRequest.
    /// </summary>
    public class WorkoutsDuplicateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsDuplicateRequest"/> class.
        /// </summary>
        public WorkoutsDuplicateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsDuplicateRequest"/> class.
        /// </summary>
        /// <param name="newWorkoutTitle">newWorkoutTitle.</param>
        public WorkoutsDuplicateRequest(
            string newWorkoutTitle)
        {
            this.NewWorkoutTitle = newWorkoutTitle;
        }

        /// <summary>
        /// The title for the new duplicated workout
        /// </summary>
        [JsonProperty("newWorkoutTitle")]
        public string NewWorkoutTitle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WorkoutsDuplicateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is WorkoutsDuplicateRequest other &&                ((this.NewWorkoutTitle == null && other.NewWorkoutTitle == null) || (this.NewWorkoutTitle?.Equals(other.NewWorkoutTitle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NewWorkoutTitle = {(this.NewWorkoutTitle == null ? "null" : this.NewWorkoutTitle)}");
        }
    }
}