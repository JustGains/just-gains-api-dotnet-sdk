// <copyright file="RelatedExerciseListItem.cs" company="APIMatic">
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
    /// RelatedExerciseListItem.
    /// </summary>
    public class RelatedExerciseListItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedExerciseListItem"/> class.
        /// </summary>
        public RelatedExerciseListItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedExerciseListItem"/> class.
        /// </summary>
        /// <param name="exerciseCode">exerciseCode.</param>
        /// <param name="variantSlug">VariantSlug.</param>
        public RelatedExerciseListItem(
            string exerciseCode,
            string variantSlug = null)
        {
            this.ExerciseCode = exerciseCode;
            this.VariantSlug = variantSlug;
        }

        /// <summary>
        /// Unique identifier for the exercise.
        /// </summary>
        [JsonProperty("exerciseCode")]
        public string ExerciseCode { get; set; }

        /// <summary>
        /// A short slug that explains the variation of the exercise.
        /// </summary>
        [JsonProperty("VariantSlug", NullValueHandling = NullValueHandling.Ignore)]
        public string VariantSlug { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RelatedExerciseListItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is RelatedExerciseListItem other &&                ((this.ExerciseCode == null && other.ExerciseCode == null) || (this.ExerciseCode?.Equals(other.ExerciseCode) == true)) &&
                ((this.VariantSlug == null && other.VariantSlug == null) || (this.VariantSlug?.Equals(other.VariantSlug) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseCode = {(this.ExerciseCode == null ? "null" : this.ExerciseCode)}");
            toStringOutput.Add($"this.VariantSlug = {(this.VariantSlug == null ? "null" : this.VariantSlug)}");
        }
    }
}