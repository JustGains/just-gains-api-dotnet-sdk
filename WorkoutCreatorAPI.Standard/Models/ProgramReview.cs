// <copyright file="ProgramReview.cs" company="APIMatic">
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
    /// ProgramReview.
    /// </summary>
    public class ProgramReview
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramReview"/> class.
        /// </summary>
        public ProgramReview()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramReview"/> class.
        /// </summary>
        /// <param name="reviewId">reviewId.</param>
        /// <param name="programId">programId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="rating">rating.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="reviewText">reviewText.</param>
        public ProgramReview(
            int reviewId,
            int programId,
            Guid userId,
            int rating,
            DateTime createdAt,
            string reviewText = null)
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
        [JsonProperty("reviewId")]
        public int ReviewId { get; set; }

        /// <summary>
        /// Identifier of the reviewed program.
        /// </summary>
        [JsonProperty("programId")]
        public int ProgramId { get; set; }

        /// <summary>
        /// Identifier of the user who wrote the review.
        /// </summary>
        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        /// <summary>
        /// Numeric rating given by the user (1 to 5).
        /// </summary>
        [JsonProperty("rating")]
        public int Rating { get; set; }

        /// <summary>
        /// Text content of the review.
        /// </summary>
        [JsonProperty("reviewText", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewText { get; set; }

        /// <summary>
        /// Timestamp of when the review was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProgramReview : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProgramReview other &&                this.ReviewId.Equals(other.ReviewId) &&
                this.ProgramId.Equals(other.ProgramId) &&
                this.UserId.Equals(other.UserId) &&
                this.Rating.Equals(other.Rating) &&
                ((this.ReviewText == null && other.ReviewText == null) || (this.ReviewText?.Equals(other.ReviewText) == true)) &&
                this.CreatedAt.Equals(other.CreatedAt);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReviewId = {this.ReviewId}");
            toStringOutput.Add($"this.ProgramId = {this.ProgramId}");
            toStringOutput.Add($"this.UserId = {this.UserId}");
            toStringOutput.Add($"this.Rating = {this.Rating}");
            toStringOutput.Add($"this.ReviewText = {(this.ReviewText == null ? "null" : this.ReviewText)}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
        }
    }
}