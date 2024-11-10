// <copyright file="ExerciseUpdateRequest.cs" company="APIMatic">
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
    /// ExerciseUpdateRequest.
    /// </summary>
    public class ExerciseUpdateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseUpdateRequest"/> class.
        /// </summary>
        public ExerciseUpdateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseUpdateRequest"/> class.
        /// </summary>
        /// <param name="exerciseCode">exerciseCode.</param>
        /// <param name="exerciseName">exerciseName.</param>
        /// <param name="exerciseEquipment">exerciseEquipment.</param>
        /// <param name="exerciseMuscles">exerciseMuscles.</param>
        /// <param name="exerciseCategories">exerciseCategories.</param>
        /// <param name="relatedExercises">relatedExercises.</param>
        /// <param name="exerciseTypeCode">exerciseTypeCode.</param>
        /// <param name="publishStatusCode">publishStatusCode.</param>
        /// <param name="difficulty">difficulty.</param>
        /// <param name="metabolicEquivalent">metabolicEquivalent.</param>
        /// <param name="isPlateloaded">isPlateloaded.</param>
        /// <param name="isCardio">isCardio.</param>
        /// <param name="olympicRating">olympicRating.</param>
        /// <param name="powerLifterRating">powerLifterRating.</param>
        /// <param name="calisthenicRating">calisthenicRating.</param>
        /// <param name="popularityRating">popularityRating.</param>
        /// <param name="isPlyometric">isPlyometric.</param>
        /// <param name="isIsometric">isIsometric.</param>
        /// <param name="isCalisthenic">isCalisthenic.</param>
        /// <param name="isWeighted">isWeighted.</param>
        /// <param name="isUnilateral">isUnilateral.</param>
        /// <param name="isBodyweight">isBodyweight.</param>
        /// <param name="isVariant">isVariant.</param>
        /// <param name="adminNotes">adminNotes.</param>
        public ExerciseUpdateRequest(
            string exerciseCode = null,
            string exerciseName = null,
            Models.ExerciseEquipment exerciseEquipment = null,
            List<Models.ExerciseMuscle> exerciseMuscles = null,
            List<string> exerciseCategories = null,
            List<Models.RelatedExerciseListItem> relatedExercises = null,
            string exerciseTypeCode = null,
            Models.PublishStatusCodeEnum? publishStatusCode = null,
            int? difficulty = null,
            double? metabolicEquivalent = null,
            bool? isPlateloaded = null,
            bool? isCardio = null,
            int? olympicRating = 0,
            int? powerLifterRating = 0,
            int? calisthenicRating = 0,
            int? popularityRating = 0,
            bool? isPlyometric = null,
            bool? isIsometric = null,
            bool? isCalisthenic = null,
            bool? isWeighted = null,
            bool? isUnilateral = null,
            bool? isBodyweight = null,
            bool? isVariant = null,
            string adminNotes = null)
        {
            this.ExerciseCode = exerciseCode;
            this.ExerciseName = exerciseName;
            this.ExerciseEquipment = exerciseEquipment;
            this.ExerciseMuscles = exerciseMuscles;
            this.ExerciseCategories = exerciseCategories;
            this.RelatedExercises = relatedExercises;
            this.ExerciseTypeCode = exerciseTypeCode;
            this.PublishStatusCode = publishStatusCode;
            this.Difficulty = difficulty;
            this.MetabolicEquivalent = metabolicEquivalent;
            this.IsPlateloaded = isPlateloaded;
            this.IsCardio = isCardio;
            this.OlympicRating = olympicRating;
            this.PowerLifterRating = powerLifterRating;
            this.CalisthenicRating = calisthenicRating;
            this.PopularityRating = popularityRating;
            this.IsPlyometric = isPlyometric;
            this.IsIsometric = isIsometric;
            this.IsCalisthenic = isCalisthenic;
            this.IsWeighted = isWeighted;
            this.IsUnilateral = isUnilateral;
            this.IsBodyweight = isBodyweight;
            this.IsVariant = isVariant;
            this.AdminNotes = adminNotes;
        }

        /// <summary>
        /// A unique identifier for the exercise.
        /// </summary>
        [JsonProperty("exerciseCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseCode { get; set; }

        /// <summary>
        /// Translated Primary Exercise Name
        /// </summary>
        [JsonProperty("exerciseName", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseName { get; set; }

        /// <summary>
        /// Gets or sets ExerciseEquipment.
        /// </summary>
        [JsonProperty("exerciseEquipment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExerciseEquipment ExerciseEquipment { get; set; }

        /// <summary>
        /// Gets or sets ExerciseMuscles.
        /// </summary>
        [JsonProperty("exerciseMuscles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ExerciseMuscle> ExerciseMuscles { get; set; }

        /// <summary>
        /// Array of category codes associated with this exercise
        /// </summary>
        [JsonProperty("exerciseCategories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExerciseCategories { get; set; }

        /// <summary>
        /// Gets or sets RelatedExercises.
        /// </summary>
        [JsonProperty("relatedExercises", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RelatedExerciseListItem> RelatedExercises { get; set; }

        /// <summary>
        /// The exerciseTypeCode of the exercise
        /// </summary>
        [JsonProperty("exerciseTypeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseTypeCode { get; set; }

        /// <summary>
        /// The publish status of the exercise
        /// </summary>
        [JsonProperty("publishStatusCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PublishStatusCodeEnum? PublishStatusCode { get; set; }

        /// <summary>
        /// Difficulty level of the exercise
        /// </summary>
        [JsonProperty("difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public int? Difficulty { get; set; }

        /// <summary>
        /// Metabolic equivalent of the exercise
        /// </summary>
        [JsonProperty("metabolicEquivalent", NullValueHandling = NullValueHandling.Ignore)]
        public double? MetabolicEquivalent { get; set; }

        /// <summary>
        /// Indicates if the exercise is plateloaded
        /// </summary>
        [JsonProperty("isPlateloaded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPlateloaded { get; set; }

        /// <summary>
        /// Indicates if the exercise is cardio
        /// </summary>
        [JsonProperty("isCardio", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCardio { get; set; }

        /// <summary>
        /// Olympic rating of the exercise
        /// </summary>
        [JsonProperty("olympicRating", NullValueHandling = NullValueHandling.Ignore)]
        public int? OlympicRating { get; set; }

        /// <summary>
        /// Power lifter rating of the exercise
        /// </summary>
        [JsonProperty("powerLifterRating", NullValueHandling = NullValueHandling.Ignore)]
        public int? PowerLifterRating { get; set; }

        /// <summary>
        /// Calisthenic rating of the exercise
        /// </summary>
        [JsonProperty("calisthenicRating", NullValueHandling = NullValueHandling.Ignore)]
        public int? CalisthenicRating { get; set; }

        /// <summary>
        /// Popularity rating of the exercise
        /// </summary>
        [JsonProperty("popularityRating", NullValueHandling = NullValueHandling.Ignore)]
        public int? PopularityRating { get; set; }

        /// <summary>
        /// Indicates if the exercise is plyometric
        /// </summary>
        [JsonProperty("isPlyometric", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPlyometric { get; set; }

        /// <summary>
        /// Indicates if the exercise is isometric
        /// </summary>
        [JsonProperty("isIsometric", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIsometric { get; set; }

        /// <summary>
        /// Indicates if the exercise is calisthenic
        /// </summary>
        [JsonProperty("isCalisthenic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCalisthenic { get; set; }

        /// <summary>
        /// Indicates if the exercise is weighted
        /// </summary>
        [JsonProperty("isWeighted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWeighted { get; set; }

        /// <summary>
        /// Indicates if the exercise is unilateral
        /// </summary>
        [JsonProperty("isUnilateral", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUnilateral { get; set; }

        /// <summary>
        /// Indicates if the exercise is bodyweight
        /// </summary>
        [JsonProperty("isBodyweight", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBodyweight { get; set; }

        /// <summary>
        /// Indicates if the exercise is a variant. When true, the exercise won't show up without being searched.
        /// </summary>
        [JsonProperty("isVariant", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVariant { get; set; }

        /// <summary>
        /// Admin notes for the exercise
        /// </summary>
        [JsonProperty("adminNotes", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminNotes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseUpdateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseUpdateRequest other &&                ((this.ExerciseCode == null && other.ExerciseCode == null) || (this.ExerciseCode?.Equals(other.ExerciseCode) == true)) &&
                ((this.ExerciseName == null && other.ExerciseName == null) || (this.ExerciseName?.Equals(other.ExerciseName) == true)) &&
                ((this.ExerciseEquipment == null && other.ExerciseEquipment == null) || (this.ExerciseEquipment?.Equals(other.ExerciseEquipment) == true)) &&
                ((this.ExerciseMuscles == null && other.ExerciseMuscles == null) || (this.ExerciseMuscles?.Equals(other.ExerciseMuscles) == true)) &&
                ((this.ExerciseCategories == null && other.ExerciseCategories == null) || (this.ExerciseCategories?.Equals(other.ExerciseCategories) == true)) &&
                ((this.RelatedExercises == null && other.RelatedExercises == null) || (this.RelatedExercises?.Equals(other.RelatedExercises) == true)) &&
                ((this.ExerciseTypeCode == null && other.ExerciseTypeCode == null) || (this.ExerciseTypeCode?.Equals(other.ExerciseTypeCode) == true)) &&
                ((this.PublishStatusCode == null && other.PublishStatusCode == null) || (this.PublishStatusCode?.Equals(other.PublishStatusCode) == true)) &&
                ((this.Difficulty == null && other.Difficulty == null) || (this.Difficulty?.Equals(other.Difficulty) == true)) &&
                ((this.MetabolicEquivalent == null && other.MetabolicEquivalent == null) || (this.MetabolicEquivalent?.Equals(other.MetabolicEquivalent) == true)) &&
                ((this.IsPlateloaded == null && other.IsPlateloaded == null) || (this.IsPlateloaded?.Equals(other.IsPlateloaded) == true)) &&
                ((this.IsCardio == null && other.IsCardio == null) || (this.IsCardio?.Equals(other.IsCardio) == true)) &&
                ((this.OlympicRating == null && other.OlympicRating == null) || (this.OlympicRating?.Equals(other.OlympicRating) == true)) &&
                ((this.PowerLifterRating == null && other.PowerLifterRating == null) || (this.PowerLifterRating?.Equals(other.PowerLifterRating) == true)) &&
                ((this.CalisthenicRating == null && other.CalisthenicRating == null) || (this.CalisthenicRating?.Equals(other.CalisthenicRating) == true)) &&
                ((this.PopularityRating == null && other.PopularityRating == null) || (this.PopularityRating?.Equals(other.PopularityRating) == true)) &&
                ((this.IsPlyometric == null && other.IsPlyometric == null) || (this.IsPlyometric?.Equals(other.IsPlyometric) == true)) &&
                ((this.IsIsometric == null && other.IsIsometric == null) || (this.IsIsometric?.Equals(other.IsIsometric) == true)) &&
                ((this.IsCalisthenic == null && other.IsCalisthenic == null) || (this.IsCalisthenic?.Equals(other.IsCalisthenic) == true)) &&
                ((this.IsWeighted == null && other.IsWeighted == null) || (this.IsWeighted?.Equals(other.IsWeighted) == true)) &&
                ((this.IsUnilateral == null && other.IsUnilateral == null) || (this.IsUnilateral?.Equals(other.IsUnilateral) == true)) &&
                ((this.IsBodyweight == null && other.IsBodyweight == null) || (this.IsBodyweight?.Equals(other.IsBodyweight) == true)) &&
                ((this.IsVariant == null && other.IsVariant == null) || (this.IsVariant?.Equals(other.IsVariant) == true)) &&
                ((this.AdminNotes == null && other.AdminNotes == null) || (this.AdminNotes?.Equals(other.AdminNotes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseCode = {(this.ExerciseCode == null ? "null" : this.ExerciseCode)}");
            toStringOutput.Add($"this.ExerciseName = {(this.ExerciseName == null ? "null" : this.ExerciseName)}");
            toStringOutput.Add($"this.ExerciseEquipment = {(this.ExerciseEquipment == null ? "null" : this.ExerciseEquipment.ToString())}");
            toStringOutput.Add($"this.ExerciseMuscles = {(this.ExerciseMuscles == null ? "null" : $"[{string.Join(", ", this.ExerciseMuscles)} ]")}");
            toStringOutput.Add($"this.ExerciseCategories = {(this.ExerciseCategories == null ? "null" : $"[{string.Join(", ", this.ExerciseCategories)} ]")}");
            toStringOutput.Add($"this.RelatedExercises = {(this.RelatedExercises == null ? "null" : $"[{string.Join(", ", this.RelatedExercises)} ]")}");
            toStringOutput.Add($"this.ExerciseTypeCode = {(this.ExerciseTypeCode == null ? "null" : this.ExerciseTypeCode)}");
            toStringOutput.Add($"this.PublishStatusCode = {(this.PublishStatusCode == null ? "null" : this.PublishStatusCode.ToString())}");
            toStringOutput.Add($"this.Difficulty = {(this.Difficulty == null ? "null" : this.Difficulty.ToString())}");
            toStringOutput.Add($"this.MetabolicEquivalent = {(this.MetabolicEquivalent == null ? "null" : this.MetabolicEquivalent.ToString())}");
            toStringOutput.Add($"this.IsPlateloaded = {(this.IsPlateloaded == null ? "null" : this.IsPlateloaded.ToString())}");
            toStringOutput.Add($"this.IsCardio = {(this.IsCardio == null ? "null" : this.IsCardio.ToString())}");
            toStringOutput.Add($"this.OlympicRating = {(this.OlympicRating == null ? "null" : this.OlympicRating.ToString())}");
            toStringOutput.Add($"this.PowerLifterRating = {(this.PowerLifterRating == null ? "null" : this.PowerLifterRating.ToString())}");
            toStringOutput.Add($"this.CalisthenicRating = {(this.CalisthenicRating == null ? "null" : this.CalisthenicRating.ToString())}");
            toStringOutput.Add($"this.PopularityRating = {(this.PopularityRating == null ? "null" : this.PopularityRating.ToString())}");
            toStringOutput.Add($"this.IsPlyometric = {(this.IsPlyometric == null ? "null" : this.IsPlyometric.ToString())}");
            toStringOutput.Add($"this.IsIsometric = {(this.IsIsometric == null ? "null" : this.IsIsometric.ToString())}");
            toStringOutput.Add($"this.IsCalisthenic = {(this.IsCalisthenic == null ? "null" : this.IsCalisthenic.ToString())}");
            toStringOutput.Add($"this.IsWeighted = {(this.IsWeighted == null ? "null" : this.IsWeighted.ToString())}");
            toStringOutput.Add($"this.IsUnilateral = {(this.IsUnilateral == null ? "null" : this.IsUnilateral.ToString())}");
            toStringOutput.Add($"this.IsBodyweight = {(this.IsBodyweight == null ? "null" : this.IsBodyweight.ToString())}");
            toStringOutput.Add($"this.IsVariant = {(this.IsVariant == null ? "null" : this.IsVariant.ToString())}");
            toStringOutput.Add($"this.AdminNotes = {(this.AdminNotes == null ? "null" : this.AdminNotes)}");
        }
    }
}