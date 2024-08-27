// <copyright file="Data71.cs" company="APIMatic">
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
    /// Data71.
    /// </summary>
    public class Data71
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data71"/> class.
        /// </summary>
        public Data71()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data71"/> class.
        /// </summary>
        /// <param name="weekId">weekId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="weekTitle">weekTitle.</param>
        /// <param name="weekContent">weekContent.</param>
        /// <param name="weekThumbnail">weekThumbnail.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="deletedAt">deletedAt.</param>
        /// <param name="deletedBy">deletedBy.</param>
        public Data71(
            int? weekId = null,
            Guid? userId = null,
            string weekTitle = null,
            string weekContent = null,
            Models.WeekThumbnail weekThumbnail = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            DateTime? deletedAt = null,
            Guid? deletedBy = null)
        {
            this.WeekId = weekId;
            this.UserId = userId;
            this.WeekTitle = weekTitle;
            this.WeekContent = weekContent;
            this.WeekThumbnail = weekThumbnail;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
            this.DeletedBy = deletedBy;
        }

        /// <summary>
        /// Unique identifier for the week.
        /// </summary>
        [JsonProperty("weekId", NullValueHandling = NullValueHandling.Ignore)]
        public int? WeekId { get; set; }

        /// <summary>
        /// Identifier of the user who created or owns this week.
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Title or name of the week.
        /// </summary>
        [JsonProperty("weekTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string WeekTitle { get; set; }

        /// <summary>
        /// JSON string containing the structured content of the week, including workout plans and notes.
        /// </summary>
        [JsonProperty("weekContent", NullValueHandling = NullValueHandling.Ignore)]
        public string WeekContent { get; set; }

        /// <summary>
        /// Thumbnail image representing the week.
        /// </summary>
        [JsonProperty("weekThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WeekThumbnail WeekThumbnail { get; set; }

        /// <summary>
        /// Timestamp of when the week was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the week was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the week was soft deleted, if applicable.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deletedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Identifier of the user who deleted the week, if applicable.
        /// </summary>
        [JsonProperty("deletedBy", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DeletedBy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data71 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data71 other &&                ((this.WeekId == null && other.WeekId == null) || (this.WeekId?.Equals(other.WeekId) == true)) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.WeekTitle == null && other.WeekTitle == null) || (this.WeekTitle?.Equals(other.WeekTitle) == true)) &&
                ((this.WeekContent == null && other.WeekContent == null) || (this.WeekContent?.Equals(other.WeekContent) == true)) &&
                ((this.WeekThumbnail == null && other.WeekThumbnail == null) || (this.WeekThumbnail?.Equals(other.WeekThumbnail) == true)) &&
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
            toStringOutput.Add($"this.WeekId = {(this.WeekId == null ? "null" : this.WeekId.ToString())}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId.ToString())}");
            toStringOutput.Add($"this.WeekTitle = {(this.WeekTitle == null ? "null" : this.WeekTitle)}");
            toStringOutput.Add($"this.WeekContent = {(this.WeekContent == null ? "null" : this.WeekContent)}");
            toStringOutput.Add($"this.WeekThumbnail = {(this.WeekThumbnail == null ? "null" : this.WeekThumbnail.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
            toStringOutput.Add($"this.DeletedBy = {(this.DeletedBy == null ? "null" : this.DeletedBy.ToString())}");
        }
    }
}