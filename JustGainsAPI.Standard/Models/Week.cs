// <copyright file="Week.cs" company="APIMatic">
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
    /// Week.
    /// </summary>
    public class Week
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Week"/> class.
        /// </summary>
        public Week()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Week"/> class.
        /// </summary>
        /// <param name="weekId">weekId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="weekTitle">weekTitle.</param>
        /// <param name="weekContent">weekContent.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="weekThumbnail">weekThumbnail.</param>
        /// <param name="deletedAt">deletedAt.</param>
        /// <param name="deletedBy">deletedBy.</param>
        public Week(
            int weekId,
            Guid userId,
            string weekTitle,
            string weekContent,
            DateTime createdAt,
            DateTime updatedAt,
            Models.MediaAsset weekThumbnail = null,
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
        [JsonProperty("weekId")]
        public int WeekId { get; set; }

        /// <summary>
        /// Identifier of the user who created or owns this week.
        /// </summary>
        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        /// <summary>
        /// Title or name of the week.
        /// </summary>
        [JsonProperty("weekTitle")]
        public string WeekTitle { get; set; }

        /// <summary>
        /// JSON string containing the structured content of the week, including workout plans and notes.
        /// </summary>
        [JsonProperty("weekContent")]
        public string WeekContent { get; set; }

        /// <summary>
        /// Gets or sets WeekThumbnail.
        /// </summary>
        [JsonProperty("weekThumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Models.MediaAsset WeekThumbnail { get; set; }

        /// <summary>
        /// Timestamp of when the week was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the week was last updated.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

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

            return $"Week : ({string.Join(", ", toStringOutput)})";
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
            return obj is Week other &&                this.WeekId.Equals(other.WeekId) &&
                this.UserId.Equals(other.UserId) &&
                ((this.WeekTitle == null && other.WeekTitle == null) || (this.WeekTitle?.Equals(other.WeekTitle) == true)) &&
                ((this.WeekContent == null && other.WeekContent == null) || (this.WeekContent?.Equals(other.WeekContent) == true)) &&
                ((this.WeekThumbnail == null && other.WeekThumbnail == null) || (this.WeekThumbnail?.Equals(other.WeekThumbnail) == true)) &&
                this.CreatedAt.Equals(other.CreatedAt) &&
                this.UpdatedAt.Equals(other.UpdatedAt) &&
                ((this.DeletedAt == null && other.DeletedAt == null) || (this.DeletedAt?.Equals(other.DeletedAt) == true)) &&
                ((this.DeletedBy == null && other.DeletedBy == null) || (this.DeletedBy?.Equals(other.DeletedBy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WeekId = {this.WeekId}");
            toStringOutput.Add($"this.UserId = {this.UserId}");
            toStringOutput.Add($"this.WeekTitle = {(this.WeekTitle == null ? "null" : this.WeekTitle)}");
            toStringOutput.Add($"this.WeekContent = {(this.WeekContent == null ? "null" : this.WeekContent)}");
            toStringOutput.Add($"this.WeekThumbnail = {(this.WeekThumbnail == null ? "null" : this.WeekThumbnail.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"this.UpdatedAt = {this.UpdatedAt}");
            toStringOutput.Add($"this.DeletedAt = {(this.DeletedAt == null ? "null" : this.DeletedAt.ToString())}");
            toStringOutput.Add($"this.DeletedBy = {(this.DeletedBy == null ? "null" : this.DeletedBy.ToString())}");
        }
    }
}