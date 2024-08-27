// <copyright file="Data75.cs" company="APIMatic">
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
    /// Data75.
    /// </summary>
    public class Data75
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data75"/> class.
        /// </summary>
        public Data75()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data75"/> class.
        /// </summary>
        /// <param name="reviewId">reviewId.</param>
        /// <param name="programId">programId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="rating">rating.</param>
        /// <param name="reviewText">reviewText.</param>
        /// <param name="createdAt">createdAt.</param>
        public Data75(
            int? reviewId = null,
            int? programId = null,
            Guid? userId = null,
            int? rating = null,
            string reviewText = null,
            DateTime? createdAt = null)
        {
            this.ReviewId = reviewId;
            this.ProgramId = programId;
            this.UserId = userId;
            this.Rating = rating;
            this.ReviewText = reviewText;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Unique identifier for this review.
        /// </summary>
        [JsonProperty("reviewId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReviewId { get; set; }

        /// <summary>
        /// Identifier of the reviewed program.
        /// </summary>
        [JsonProperty("programId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProgramId { get; set; }

        /// <summary>
        /// Identifier of the user who wrote the review.
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Numeric rating given by the user (1 to 5).
        /// </summary>
        [JsonProperty("rating", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rating { get; set; }

        /// <summary>
        /// Text content of the review.
        /// </summary>
        [JsonProperty("reviewText", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewText { get; set; }

        /// <summary>
        /// Timestamp of when the review was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data75 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data75 other &&                ((this.ReviewId == null && other.ReviewId == null) || (this.ReviewId?.Equals(other.ReviewId) == true)) &&
                ((this.ProgramId == null && other.ProgramId == null) || (this.ProgramId?.Equals(other.ProgramId) == true)) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.Rating == null && other.Rating == null) || (this.Rating?.Equals(other.Rating) == true)) &&
                ((this.ReviewText == null && other.ReviewText == null) || (this.ReviewText?.Equals(other.ReviewText) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReviewId = {(this.ReviewId == null ? "null" : this.ReviewId.ToString())}");
            toStringOutput.Add($"this.ProgramId = {(this.ProgramId == null ? "null" : this.ProgramId.ToString())}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId.ToString())}");
            toStringOutput.Add($"this.Rating = {(this.Rating == null ? "null" : this.Rating.ToString())}");
            toStringOutput.Add($"this.ReviewText = {(this.ReviewText == null ? "null" : this.ReviewText)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
        }
    }
}