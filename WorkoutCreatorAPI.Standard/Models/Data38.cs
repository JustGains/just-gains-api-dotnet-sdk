// <copyright file="Data38.cs" company="APIMatic">
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
    /// Data38.
    /// </summary>
    public class Data38
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data38"/> class.
        /// </summary>
        public Data38()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data38"/> class.
        /// </summary>
        /// <param name="exerciseCategoryCode">exerciseCategoryCode.</param>
        /// <param name="exerciseCategoryName">exerciseCategoryName.</param>
        public Data38(
            string exerciseCategoryCode = null,
            string exerciseCategoryName = null)
        {
            this.ExerciseCategoryCode = exerciseCategoryCode;
            this.ExerciseCategoryName = exerciseCategoryName;
        }

        /// <summary>
        /// Unique identifier for the exercise category.
        /// </summary>
        [JsonProperty("exerciseCategoryCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseCategoryCode { get; set; }

        /// <summary>
        /// The name of the exercise category in the default language (typically English). This is a read-only field derived from translations.
        /// </summary>
        [JsonProperty("exerciseCategoryName", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseCategoryName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data38 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data38 other &&                ((this.ExerciseCategoryCode == null && other.ExerciseCategoryCode == null) || (this.ExerciseCategoryCode?.Equals(other.ExerciseCategoryCode) == true)) &&
                ((this.ExerciseCategoryName == null && other.ExerciseCategoryName == null) || (this.ExerciseCategoryName?.Equals(other.ExerciseCategoryName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseCategoryCode = {(this.ExerciseCategoryCode == null ? "null" : this.ExerciseCategoryCode)}");
            toStringOutput.Add($"this.ExerciseCategoryName = {(this.ExerciseCategoryName == null ? "null" : this.ExerciseCategoryName)}");
        }
    }
}