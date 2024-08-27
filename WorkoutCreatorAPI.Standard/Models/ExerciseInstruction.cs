// <copyright file="ExerciseInstruction.cs" company="APIMatic">
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
    /// ExerciseInstruction.
    /// </summary>
    public class ExerciseInstruction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseInstruction"/> class.
        /// </summary>
        public ExerciseInstruction()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseInstruction"/> class.
        /// </summary>
        /// <param name="exerciseCode">exerciseCode.</param>
        /// <param name="localeCode">localeCode.</param>
        /// <param name="instructionJSON">instructionJSON.</param>
        /// <param name="userId">userId.</param>
        public ExerciseInstruction(
            string exerciseCode,
            string localeCode,
            Models.InstructionJSON1 instructionJSON,
            string userId = null)
        {
            this.ExerciseCode = exerciseCode;
            this.UserId = userId;
            this.LocaleCode = localeCode;
            this.InstructionJSON = instructionJSON;
        }

        /// <summary>
        /// The exerciseCode of the exercise to add instructions to.
        /// </summary>
        [JsonProperty("exerciseCode")]
        public string ExerciseCode { get; set; }

        /// <summary>
        /// The userId of the creator related to this instruction
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// Language code for the instructions
        /// </summary>
        [JsonProperty("localeCode")]
        public string LocaleCode { get; set; }

        /// <summary>
        /// JSON object containing the exercise instructions in EditorJS format
        /// </summary>
        [JsonProperty("instructionJSON")]
        public Models.InstructionJSON1 InstructionJSON { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExerciseInstruction : ({string.Join(", ", toStringOutput)})";
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
            return obj is ExerciseInstruction other &&                ((this.ExerciseCode == null && other.ExerciseCode == null) || (this.ExerciseCode?.Equals(other.ExerciseCode) == true)) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.LocaleCode == null && other.LocaleCode == null) || (this.LocaleCode?.Equals(other.LocaleCode) == true)) &&
                ((this.InstructionJSON == null && other.InstructionJSON == null) || (this.InstructionJSON?.Equals(other.InstructionJSON) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExerciseCode = {(this.ExerciseCode == null ? "null" : this.ExerciseCode)}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId)}");
            toStringOutput.Add($"this.LocaleCode = {(this.LocaleCode == null ? "null" : this.LocaleCode)}");
            toStringOutput.Add($"this.InstructionJSON = {(this.InstructionJSON == null ? "null" : this.InstructionJSON.ToString())}");
        }
    }
}