// <copyright file="Data67.cs" company="APIMatic">
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
    /// Data67.
    /// </summary>
    public class Data67
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data67"/> class.
        /// </summary>
        public Data67()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data67"/> class.
        /// </summary>
        /// <param name="programId">programId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="programName">programName.</param>
        /// <param name="programDescription">programDescription.</param>
        /// <param name="programThumbnail">programThumbnail.</param>
        /// <param name="publishStatusCode">publishStatusCode.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="deletedAt">deletedAt.</param>
        /// <param name="deletedBy">deletedBy.</param>
        public Data67(
            int? programId = null,
            Guid? userId = null,
            string programName = null,
            string programDescription = null,
            Models.ProgramThumbnail programThumbnail = null,
            string publishStatusCode = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            DateTime? deletedAt = null,
            Guid? deletedBy = null)
        {
            this.ProgramId = programId;
            this.UserId = userId;
            this.ProgramName = programName;
            this.ProgramDescription = programDescription;
            this.ProgramThumbnail = programThumbnail;
            this.PublishStatusCode = publishStatusCode;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
            this.DeletedBy = deletedBy;
        }

        /// <summary>
        /// Unique identifier for the program.
        /// </summary>
        [JsonProperty("programId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProgramId { get; set; }

        /// <summary>
        /// Identifier of the user who created the program.
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Name of the training program.
        /// </summary>
        [JsonProperty("programName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgramName { get; set; }

        /// <summary>
        /// Detailed description of the program, its goals, and target audience.
        /// </summary>
        [JsonProperty("programDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgramDescription { get; set; }

        /// <summary>
        /// Thumbnail image representing the program.
        /// </summary>
        [JsonProperty("programThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProgramThumbnail ProgramThumbnail { get; set; }

        /// <summary>
        /// Code indicating the publish status of the program (e.g., draft, published, archived).
        /// </summary>
        [JsonProperty("publishStatusCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishStatusCode { get; set; }

        /// <summary>
        /// Timestamp of when the program was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the program was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the program was soft deleted, if applicable.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deletedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Identifier of the user who deleted the program, if applicable.
        /// </summary>
        [JsonProperty("deletedBy", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DeletedBy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data67 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data67 other &&                ((this.ProgramId == null && other.ProgramId == null) || (this.ProgramId?.Equals(other.ProgramId) == true)) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.ProgramName == null && other.ProgramName == null) || (this.ProgramName?.Equals(other.ProgramName) == true)) &&
                ((this.ProgramDescription == null && other.ProgramDescription == null) || (this.ProgramDescription?.Equals(other.ProgramDescription) == true)) &&
                ((this.ProgramThumbnail == null && other.ProgramThumbnail == null) || (this.ProgramThumbnail?.Equals(other.ProgramThumbnail) == true)) &&
                ((this.PublishStatusCode == null && other.PublishStatusCode == null) || (this.PublishStatusCode?.Equals(other.PublishStatusCode) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true)) &&
                ((this.DeletedBy == null && other.DeletedBy == null) || (this.DeletedBy?.Equals(other.DeletedBy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProgramId = {(this.ProgramId == null ? "null" : this.ProgramId.ToString())}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId.ToString())}");
            toStringOutput.Add($"this.ProgramName = {(this.ProgramName == null ? "null" : this.ProgramName)}");
            toStringOutput.Add($"this.ProgramDescription = {(this.ProgramDescription == null ? "null" : this.ProgramDescription)}");
            toStringOutput.Add($"this.ProgramThumbnail = {(this.ProgramThumbnail == null ? "null" : this.ProgramThumbnail.ToString())}");
            toStringOutput.Add($"this.PublishStatusCode = {(this.PublishStatusCode == null ? "null" : this.PublishStatusCode)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
            toStringOutput.Add($"this.DeletedBy = {(this.DeletedBy == null ? "null" : this.DeletedBy.ToString())}");
        }
    }
}