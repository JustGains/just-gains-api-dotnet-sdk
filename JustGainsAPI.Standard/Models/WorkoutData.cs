// <copyright file="WorkoutData.cs" company="APIMatic">
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
    /// WorkoutData.
    /// </summary>
    public class WorkoutData
    {
        private int? exerciseGroupID;
        private Models.ExerciseGroupTypeEnum? exerciseGroupType;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "exerciseGroupID", false },
            { "exerciseGroupType", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutData"/> class.
        /// </summary>
        public WorkoutData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutData"/> class.
        /// </summary>
        /// <param name="exerciseCode">exerciseCode.</param>
        /// <param name="exerciseNotes">exerciseNotes.</param>
        /// <param name="exerciseThumbnail">exerciseThumbnail.</param>
        /// <param name="exerciseMetrics">exerciseMetrics.</param>
        /// <param name="exerciseOrder">exerciseOrder.</param>
        /// <param name="exerciseGroupID">exerciseGroupID.</param>
        /// <param name="exerciseGroupType">exerciseGroupType.</param>
        /// <param name="exerciseData">exerciseData.</param>
        public WorkoutData(
            string exerciseCode = null,
            string exerciseNotes = null,
            Models.MediaAsset exerciseThumbnail = null,
            List<Models.ExerciseMetric1> exerciseMetrics = null,
            int? exerciseOrder = null,
            int? exerciseGroupID = null,
            Models.ExerciseGroupTypeEnum? exerciseGroupType = null,
            List<Models.ExerciseSet> exerciseData = null)
        {
            this.ExerciseCode = exerciseCode;
            this.ExerciseNotes = exerciseNotes;
            this.ExerciseThumbnail = exerciseThumbnail;
            this.ExerciseMetrics = exerciseMetrics;
            this.ExerciseOrder = exerciseOrder;
            if (exerciseGroupID != null)
            {
                this.ExerciseGroupID = exerciseGroupID;
            }

            if (exerciseGroupType != null)
            {
                this.ExerciseGroupType = exerciseGroupType;
            }

            this.ExerciseData = exerciseData;
        }

        /// <summary>
        /// Unique identifier for the exercise.
        /// </summary>
        [JsonProperty("exerciseCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseCode { get; set; }

        /// <summary>
        /// Additional notes or instructions for this specific instance of the exercise.
        /// </summary>
        [JsonProperty("exerciseNotes", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseNotes { get; set; }

        /// <summary>
        /// Gets or sets ExerciseThumbnail.
        /// </summary>
        [JsonProperty("exerciseThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset ExerciseThumbnail { get; set; }

        /// <summary>
        /// List of metric codes and their units used for this exercise, in order
        /// </summary>
        [JsonProperty("exerciseMetrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ExerciseMetric1> ExerciseMetrics { get; set; }

        /// <summary>
        /// The order of this exercise within the workout or its group.
        /// </summary>
        [JsonProperty("exerciseOrder", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExerciseOrder { get; set; }

        /// <summary>
        /// Identifier for the group this exercise belongs to, if any. Null if not part of a group.
        /// </summary>
        [JsonProperty("exerciseGroupID")]
        public int? ExerciseGroupID
        {
            get
            {
                return this.exerciseGroupID;
            }

            set
            {
                this.shouldSerialize["exerciseGroupID"] = true;
                this.exerciseGroupID = value;
            }
        }

        /// <summary>
        /// The type of group this exercise belongs to, if any. Null if not part of a group.
        /// </summary>
        [JsonProperty("exerciseGroupType")]
        public Models.ExerciseGroupTypeEnum? ExerciseGroupType
        {
            get
            {
                return this.exerciseGroupType;
            }

            set
            {
                this.shouldSerialize["exerciseGroupType"] = true;
                this.exerciseGroupType = value;
            }
        }

        /// <summary>
        /// Gets or sets ExerciseData.
        /// </summary>
        [JsonProperty("exerciseData", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ExerciseSet> ExerciseData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WorkoutData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExerciseGroupID()
        {
            this.shouldSerialize["exerciseGroupID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExerciseGroupType()
        {
            this.shouldSerialize["exerciseGroupType"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExerciseGroupID()
        {
            return this.shouldSerialize["exerciseGroupID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExerciseGroupType()
        {
            return this.shouldSerialize["exerciseGroupType"];
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
            return obj is WorkoutData other &&                ((this.ExerciseCode == null && other.ExerciseCode == null) || (this.ExerciseCode?.Equals(other.ExerciseCode) == true)) &&
                ((this.ExerciseNotes == null && other.ExerciseNotes == null) || (this.ExerciseNotes?.Equals(other.ExerciseNotes) == true)) &&
                ((this.ExerciseThumbnail == null && other.ExerciseThumbnail == null) || (this.ExerciseThumbnail?.Equals(other.ExerciseThumbnail) == true)) &&
                ((this.ExerciseMetrics == null && other.ExerciseMetrics == null) || (this.ExerciseMetrics?.Equals(other.ExerciseMetrics) == true)) &&
                ((this.ExerciseOrder == null && other.ExerciseOrder == null) || (this.ExerciseOrder?.Equals(other.ExerciseOrder) == true)) &&
                ((this.ExerciseGroupID == null && other.ExerciseGroupID == null) || (this.ExerciseGroupID?.Equals(other.ExerciseGroupID) == true)) &&
                ((this.ExerciseGroupType == null && other.ExerciseGroupType == null) || (this.ExerciseGroupType?.Equals(other.ExerciseGroupType) == true)) &&
                ((this.ExerciseData == null && other.ExerciseData == null) || (this.ExerciseData?.Equals(other.ExerciseData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseCode = {(this.ExerciseCode == null ? "null" : this.ExerciseCode)}");
            toStringOutput.Add($"this.ExerciseNotes = {(this.ExerciseNotes == null ? "null" : this.ExerciseNotes)}");
            toStringOutput.Add($"this.ExerciseThumbnail = {(this.ExerciseThumbnail == null ? "null" : this.ExerciseThumbnail.ToString())}");
            toStringOutput.Add($"this.ExerciseMetrics = {(this.ExerciseMetrics == null ? "null" : $"[{string.Join(", ", this.ExerciseMetrics)} ]")}");
            toStringOutput.Add($"this.ExerciseOrder = {(this.ExerciseOrder == null ? "null" : this.ExerciseOrder.ToString())}");
            toStringOutput.Add($"this.ExerciseGroupID = {(this.ExerciseGroupID == null ? "null" : this.ExerciseGroupID.ToString())}");
            toStringOutput.Add($"this.ExerciseGroupType = {(this.ExerciseGroupType == null ? "null" : this.ExerciseGroupType.ToString())}");
            toStringOutput.Add($"this.ExerciseData = {(this.ExerciseData == null ? "null" : $"[{string.Join(", ", this.ExerciseData)} ]")}");
        }
    }
}