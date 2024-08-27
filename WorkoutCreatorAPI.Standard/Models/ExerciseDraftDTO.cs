// <copyright file="ExerciseDraftDTO.cs" company="APIMatic">
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
    /// ExerciseDraftDTO.
    /// </summary>
    public class ExerciseDraftDTO
    {
        private int? exerciseTechnicalComplexity;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "exercise_technical_complexity", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseDraftDTO"/> class.
        /// </summary>
        public ExerciseDraftDTO()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseDraftDTO"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="fileName">file_name.</param>
        /// <param name="exerciseCode">exercise_code.</param>
        /// <param name="exerciseName">exercise_name.</param>
        /// <param name="alternateNames">alternate_names.</param>
        /// <param name="publishStatus">publish_status.</param>
        /// <param name="models">models.</param>
        /// <param name="exerciseType">exercise_type.</param>
        /// <param name="exerciseMetrics">exercise_metrics.</param>
        /// <param name="exerciseDifficulty">exercise_difficulty.</param>
        /// <param name="metabolicEquivalent">metabolic_equivalent.</param>
        /// <param name="equipmentRequired">equipment_required.</param>
        /// <param name="primaryMuscleGroups">primary_muscle_groups.</param>
        /// <param name="secondaryMuscleGroups">secondary_muscle_groups.</param>
        /// <param name="isPlateloaded">is_plateloaded.</param>
        /// <param name="isCardio">is_cardio.</param>
        /// <param name="olympicRating">olympic_rating.</param>
        /// <param name="powerlifterRating">powerlifter_rating.</param>
        /// <param name="calisthenicRating">calisthenic_rating.</param>
        /// <param name="popularityRating">popularity_rating.</param>
        /// <param name="exerciseTechnicalComplexity">exercise_technical_complexity.</param>
        /// <param name="isPlyometric">is_plyometric.</param>
        /// <param name="isIsometric">is_isometric.</param>
        /// <param name="isCalisthenic">is_calisthenic.</param>
        /// <param name="isWeighted">is_weighted.</param>
        /// <param name="isUnilateral">is_unilateral.</param>
        /// <param name="isBodyweight">is_bodyweight.</param>
        /// <param name="aiNotes">ai_notes.</param>
        /// <param name="exerciseInstructions">exercise_instructions.</param>
        public ExerciseDraftDTO(
            int? id = null,
            string fileName = null,
            string exerciseCode = null,
            string exerciseName = null,
            List<string> alternateNames = null,
            Models.PublishStatusEnum? publishStatus = null,
            List<Models.ExerciseModelDTO> models = null,
            List<string> exerciseType = null,
            List<string> exerciseMetrics = null,
            int? exerciseDifficulty = null,
            double? metabolicEquivalent = null,
            Models.EquipmentRequired equipmentRequired = null,
            List<Models.TargetMuscleDTO> primaryMuscleGroups = null,
            List<Models.TargetMuscleDTO> secondaryMuscleGroups = null,
            bool? isPlateloaded = null,
            bool? isCardio = null,
            int? olympicRating = null,
            int? powerlifterRating = null,
            int? calisthenicRating = null,
            int? popularityRating = null,
            int? exerciseTechnicalComplexity = null,
            bool? isPlyometric = null,
            bool? isIsometric = null,
            bool? isCalisthenic = null,
            bool? isWeighted = null,
            bool? isUnilateral = null,
            bool? isBodyweight = null,
            string aiNotes = null,
            Models.ExerciseInstruction exerciseInstructions = null)
        {
            this.Id = id;
            this.FileName = fileName;
            this.ExerciseCode = exerciseCode;
            this.ExerciseName = exerciseName;
            this.AlternateNames = alternateNames;
            this.PublishStatus = publishStatus;
            this.Models = models;
            this.ExerciseType = exerciseType;
            this.ExerciseMetrics = exerciseMetrics;
            this.ExerciseDifficulty = exerciseDifficulty;
            this.MetabolicEquivalent = metabolicEquivalent;
            this.EquipmentRequired = equipmentRequired;
            this.PrimaryMuscleGroups = primaryMuscleGroups;
            this.SecondaryMuscleGroups = secondaryMuscleGroups;
            this.IsPlateloaded = isPlateloaded;
            this.IsCardio = isCardio;
            this.OlympicRating = olympicRating;
            this.PowerlifterRating = powerlifterRating;
            this.CalisthenicRating = calisthenicRating;
            this.PopularityRating = popularityRating;
            if (exerciseTechnicalComplexity != null)
            {
                this.ExerciseTechnicalComplexity = exerciseTechnicalComplexity;
            }

            this.IsPlyometric = isPlyometric;
            this.IsIsometric = isIsometric;
            this.IsCalisthenic = isCalisthenic;
            this.IsWeighted = isWeighted;
            this.IsUnilateral = isUnilateral;
            this.IsBodyweight = isBodyweight;
            this.AiNotes = aiNotes;
            this.ExerciseInstructions = exerciseInstructions;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets FileName.
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets ExerciseCode.
        /// </summary>
        [JsonProperty("exercise_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseCode { get; set; }

        /// <summary>
        /// Gets or sets ExerciseName.
        /// </summary>
        [JsonProperty("exercise_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseName { get; set; }

        /// <summary>
        /// Gets or sets AlternateNames.
        /// </summary>
        [JsonProperty("alternate_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlternateNames { get; set; }

        /// <summary>
        /// Gets or sets PublishStatus.
        /// </summary>
        [JsonProperty("publish_status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PublishStatusEnum? PublishStatus { get; set; }

        /// <summary>
        /// Gets or sets Models.
        /// </summary>
        [JsonProperty("models", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ExerciseModelDTO> Models { get; set; }

        /// <summary>
        /// Gets or sets ExerciseType.
        /// </summary>
        [JsonProperty("exercise_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExerciseType { get; set; }

        /// <summary>
        /// Gets or sets ExerciseMetrics.
        /// </summary>
        [JsonProperty("exercise_metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExerciseMetrics { get; set; }

        /// <summary>
        /// Gets or sets ExerciseDifficulty.
        /// </summary>
        [JsonProperty("exercise_difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExerciseDifficulty { get; set; }

        /// <summary>
        /// Gets or sets MetabolicEquivalent.
        /// </summary>
        [JsonProperty("metabolic_equivalent", NullValueHandling = NullValueHandling.Ignore)]
        public double? MetabolicEquivalent { get; set; }

        /// <summary>
        /// Gets or sets EquipmentRequired.
        /// </summary>
        [JsonProperty("equipment_required", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EquipmentRequired EquipmentRequired { get; set; }

        /// <summary>
        /// Gets or sets PrimaryMuscleGroups.
        /// </summary>
        [JsonProperty("primary_muscle_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TargetMuscleDTO> PrimaryMuscleGroups { get; set; }

        /// <summary>
        /// Gets or sets SecondaryMuscleGroups.
        /// </summary>
        [JsonProperty("secondary_muscle_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.TargetMuscleDTO> SecondaryMuscleGroups { get; set; }

        /// <summary>
        /// Gets or sets IsPlateloaded.
        /// </summary>
        [JsonProperty("is_plateloaded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPlateloaded { get; set; }

        /// <summary>
        /// Gets or sets IsCardio.
        /// </summary>
        [JsonProperty("is_cardio", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCardio { get; set; }

        /// <summary>
        /// Gets or sets OlympicRating.
        /// </summary>
        [JsonProperty("olympic_rating", NullValueHandling = NullValueHandling.Ignore)]
        public int? OlympicRating { get; set; }

        /// <summary>
        /// Gets or sets PowerlifterRating.
        /// </summary>
        [JsonProperty("powerlifter_rating", NullValueHandling = NullValueHandling.Ignore)]
        public int? PowerlifterRating { get; set; }

        /// <summary>
        /// Gets or sets CalisthenicRating.
        /// </summary>
        [JsonProperty("calisthenic_rating", NullValueHandling = NullValueHandling.Ignore)]
        public int? CalisthenicRating { get; set; }

        /// <summary>
        /// Gets or sets PopularityRating.
        /// </summary>
        [JsonProperty("popularity_rating", NullValueHandling = NullValueHandling.Ignore)]
        public int? PopularityRating { get; set; }

        /// <summary>
        /// Gets or sets ExerciseTechnicalComplexity.
        /// </summary>
        [JsonProperty("exercise_technical_complexity")]
        public int? ExerciseTechnicalComplexity
        {
            get
            {
                return this.exerciseTechnicalComplexity;
            }

            set
            {
                this.shouldSerialize["exercise_technical_complexity"] = true;
                this.exerciseTechnicalComplexity = value;
            }
        }

        /// <summary>
        /// Gets or sets IsPlyometric.
        /// </summary>
        [JsonProperty("is_plyometric", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPlyometric { get; set; }

        /// <summary>
        /// Gets or sets IsIsometric.
        /// </summary>
        [JsonProperty("is_isometric", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIsometric { get; set; }

        /// <summary>
        /// Gets or sets IsCalisthenic.
        /// </summary>
        [JsonProperty("is_calisthenic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCalisthenic { get; set; }

        /// <summary>
        /// Gets or sets IsWeighted.
        /// </summary>
        [JsonProperty("is_weighted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWeighted { get; set; }

        /// <summary>
        /// Gets or sets IsUnilateral.
        /// </summary>
        [JsonProperty("is_unilateral", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUnilateral { get; set; }

        /// <summary>
        /// Gets or sets IsBodyweight.
        /// </summary>
        [JsonProperty("is_bodyweight", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBodyweight { get; set; }

        /// <summary>
        /// Gets or sets AiNotes.
        /// </summary>
        [JsonProperty("ai_notes", NullValueHandling = NullValueHandling.Ignore)]
        public string AiNotes { get; set; }

        /// <summary>
        /// Gets or sets ExerciseInstructions.
        /// </summary>
        [JsonProperty("exercise_instructions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ExerciseInstruction ExerciseInstructions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseDraftDTO : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExerciseTechnicalComplexity()
        {
            this.shouldSerialize["exercise_technical_complexity"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExerciseTechnicalComplexity()
        {
            return this.shouldSerialize["exercise_technical_complexity"];
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
            return obj is ExerciseDraftDTO other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.FileName == null && other.FileName == null) || (this.FileName?.Equals(other.FileName) == true)) &&
                ((this.ExerciseCode == null && other.ExerciseCode == null) || (this.ExerciseCode?.Equals(other.ExerciseCode) == true)) &&
                ((this.ExerciseName == null && other.ExerciseName == null) || (this.ExerciseName?.Equals(other.ExerciseName) == true)) &&
                ((this.AlternateNames == null && other.AlternateNames == null) || (this.AlternateNames?.Equals(other.AlternateNames) == true)) &&
                ((this.PublishStatus == null && other.PublishStatus == null) || (this.PublishStatus?.Equals(other.PublishStatus) == true)) &&
                ((this.Models == null && other.Models == null) || (this.Models?.Equals(other.Models) == true)) &&
                ((this.ExerciseType == null && other.ExerciseType == null) || (this.ExerciseType?.Equals(other.ExerciseType) == true)) &&
                ((this.ExerciseMetrics == null && other.ExerciseMetrics == null) || (this.ExerciseMetrics?.Equals(other.ExerciseMetrics) == true)) &&
                ((this.ExerciseDifficulty == null && other.ExerciseDifficulty == null) || (this.ExerciseDifficulty?.Equals(other.ExerciseDifficulty) == true)) &&
                ((this.MetabolicEquivalent == null && other.MetabolicEquivalent == null) || (this.MetabolicEquivalent?.Equals(other.MetabolicEquivalent) == true)) &&
                ((this.EquipmentRequired == null && other.EquipmentRequired == null) || (this.EquipmentRequired?.Equals(other.EquipmentRequired) == true)) &&
                ((this.PrimaryMuscleGroups == null && other.PrimaryMuscleGroups == null) || (this.PrimaryMuscleGroups?.Equals(other.PrimaryMuscleGroups) == true)) &&
                ((this.SecondaryMuscleGroups == null && other.SecondaryMuscleGroups == null) || (this.SecondaryMuscleGroups?.Equals(other.SecondaryMuscleGroups) == true)) &&
                ((this.IsPlateloaded == null && other.IsPlateloaded == null) || (this.IsPlateloaded?.Equals(other.IsPlateloaded) == true)) &&
                ((this.IsCardio == null && other.IsCardio == null) || (this.IsCardio?.Equals(other.IsCardio) == true)) &&
                ((this.OlympicRating == null && other.OlympicRating == null) || (this.OlympicRating?.Equals(other.OlympicRating) == true)) &&
                ((this.PowerlifterRating == null && other.PowerlifterRating == null) || (this.PowerlifterRating?.Equals(other.PowerlifterRating) == true)) &&
                ((this.CalisthenicRating == null && other.CalisthenicRating == null) || (this.CalisthenicRating?.Equals(other.CalisthenicRating) == true)) &&
                ((this.PopularityRating == null && other.PopularityRating == null) || (this.PopularityRating?.Equals(other.PopularityRating) == true)) &&
                ((this.ExerciseTechnicalComplexity == null && other.ExerciseTechnicalComplexity == null) || (this.ExerciseTechnicalComplexity?.Equals(other.ExerciseTechnicalComplexity) == true)) &&
                ((this.IsPlyometric == null && other.IsPlyometric == null) || (this.IsPlyometric?.Equals(other.IsPlyometric) == true)) &&
                ((this.IsIsometric == null && other.IsIsometric == null) || (this.IsIsometric?.Equals(other.IsIsometric) == true)) &&
                ((this.IsCalisthenic == null && other.IsCalisthenic == null) || (this.IsCalisthenic?.Equals(other.IsCalisthenic) == true)) &&
                ((this.IsWeighted == null && other.IsWeighted == null) || (this.IsWeighted?.Equals(other.IsWeighted) == true)) &&
                ((this.IsUnilateral == null && other.IsUnilateral == null) || (this.IsUnilateral?.Equals(other.IsUnilateral) == true)) &&
                ((this.IsBodyweight == null && other.IsBodyweight == null) || (this.IsBodyweight?.Equals(other.IsBodyweight) == true)) &&
                ((this.AiNotes == null && other.AiNotes == null) || (this.AiNotes?.Equals(other.AiNotes) == true)) &&
                ((this.ExerciseInstructions == null && other.ExerciseInstructions == null) || (this.ExerciseInstructions?.Equals(other.ExerciseInstructions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.FileName = {(this.FileName == null ? "null" : this.FileName)}");
            toStringOutput.Add($"this.ExerciseCode = {(this.ExerciseCode == null ? "null" : this.ExerciseCode)}");
            toStringOutput.Add($"this.ExerciseName = {(this.ExerciseName == null ? "null" : this.ExerciseName)}");
            toStringOutput.Add($"this.AlternateNames = {(this.AlternateNames == null ? "null" : $"[{string.Join(", ", this.AlternateNames)} ]")}");
            toStringOutput.Add($"this.PublishStatus = {(this.PublishStatus == null ? "null" : this.PublishStatus.ToString())}");
            toStringOutput.Add($"this.Models = {(this.Models == null ? "null" : $"[{string.Join(", ", this.Models)} ]")}");
            toStringOutput.Add($"this.ExerciseType = {(this.ExerciseType == null ? "null" : $"[{string.Join(", ", this.ExerciseType)} ]")}");
            toStringOutput.Add($"this.ExerciseMetrics = {(this.ExerciseMetrics == null ? "null" : $"[{string.Join(", ", this.ExerciseMetrics)} ]")}");
            toStringOutput.Add($"this.ExerciseDifficulty = {(this.ExerciseDifficulty == null ? "null" : this.ExerciseDifficulty.ToString())}");
            toStringOutput.Add($"this.MetabolicEquivalent = {(this.MetabolicEquivalent == null ? "null" : this.MetabolicEquivalent.ToString())}");
            toStringOutput.Add($"this.EquipmentRequired = {(this.EquipmentRequired == null ? "null" : this.EquipmentRequired.ToString())}");
            toStringOutput.Add($"this.PrimaryMuscleGroups = {(this.PrimaryMuscleGroups == null ? "null" : $"[{string.Join(", ", this.PrimaryMuscleGroups)} ]")}");
            toStringOutput.Add($"this.SecondaryMuscleGroups = {(this.SecondaryMuscleGroups == null ? "null" : $"[{string.Join(", ", this.SecondaryMuscleGroups)} ]")}");
            toStringOutput.Add($"this.IsPlateloaded = {(this.IsPlateloaded == null ? "null" : this.IsPlateloaded.ToString())}");
            toStringOutput.Add($"this.IsCardio = {(this.IsCardio == null ? "null" : this.IsCardio.ToString())}");
            toStringOutput.Add($"this.OlympicRating = {(this.OlympicRating == null ? "null" : this.OlympicRating.ToString())}");
            toStringOutput.Add($"this.PowerlifterRating = {(this.PowerlifterRating == null ? "null" : this.PowerlifterRating.ToString())}");
            toStringOutput.Add($"this.CalisthenicRating = {(this.CalisthenicRating == null ? "null" : this.CalisthenicRating.ToString())}");
            toStringOutput.Add($"this.PopularityRating = {(this.PopularityRating == null ? "null" : this.PopularityRating.ToString())}");
            toStringOutput.Add($"this.ExerciseTechnicalComplexity = {(this.ExerciseTechnicalComplexity == null ? "null" : this.ExerciseTechnicalComplexity.ToString())}");
            toStringOutput.Add($"this.IsPlyometric = {(this.IsPlyometric == null ? "null" : this.IsPlyometric.ToString())}");
            toStringOutput.Add($"this.IsIsometric = {(this.IsIsometric == null ? "null" : this.IsIsometric.ToString())}");
            toStringOutput.Add($"this.IsCalisthenic = {(this.IsCalisthenic == null ? "null" : this.IsCalisthenic.ToString())}");
            toStringOutput.Add($"this.IsWeighted = {(this.IsWeighted == null ? "null" : this.IsWeighted.ToString())}");
            toStringOutput.Add($"this.IsUnilateral = {(this.IsUnilateral == null ? "null" : this.IsUnilateral.ToString())}");
            toStringOutput.Add($"this.IsBodyweight = {(this.IsBodyweight == null ? "null" : this.IsBodyweight.ToString())}");
            toStringOutput.Add($"this.AiNotes = {(this.AiNotes == null ? "null" : this.AiNotes)}");
            toStringOutput.Add($"this.ExerciseInstructions = {(this.ExerciseInstructions == null ? "null" : this.ExerciseInstructions.ToString())}");
        }
    }
}