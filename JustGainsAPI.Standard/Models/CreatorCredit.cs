// <copyright file="CreatorCredit.cs" company="APIMatic">
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
    /// CreatorCredit.
    /// </summary>
    public class CreatorCredit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorCredit"/> class.
        /// </summary>
        public CreatorCredit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorCredit"/> class.
        /// </summary>
        /// <param name="creatorProfileId">creatorProfileId.</param>
        /// <param name="workoutSourceURL">workoutSourceURL.</param>
        /// <param name="contributionType">contributionType.</param>
        /// <param name="creatorProfile">creatorProfile.</param>
        public CreatorCredit(
            Guid? creatorProfileId = null,
            string workoutSourceURL = null,
            Models.ContributionTypeEnum? contributionType = null,
            Models.CreatorProfile1 creatorProfile = null)
        {
            this.CreatorProfileId = creatorProfileId;
            this.WorkoutSourceURL = workoutSourceURL;
            this.ContributionType = contributionType;
            this.CreatorProfile = creatorProfile;
        }

        /// <summary>
        /// Unique identifier for the creator profile.
        /// </summary>
        [JsonProperty("creatorProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CreatorProfileId { get; set; }

        /// <summary>
        /// URL source of the workout, if applicable.
        /// </summary>
        [JsonProperty("workoutSourceURL", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkoutSourceURL { get; set; }

        /// <summary>
        /// Type of contribution made by the creator.
        /// </summary>
        [JsonProperty("contributionType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ContributionTypeEnum? ContributionType { get; set; }

        /// <summary>
        /// Gets or sets CreatorProfile.
        /// </summary>
        [JsonProperty("creatorProfile", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorProfile1 CreatorProfile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreatorCredit : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreatorCredit other &&                ((this.CreatorProfileId == null && other.CreatorProfileId == null) || (this.CreatorProfileId?.Equals(other.CreatorProfileId) == true)) &&
                ((this.WorkoutSourceURL == null && other.WorkoutSourceURL == null) || (this.WorkoutSourceURL?.Equals(other.WorkoutSourceURL) == true)) &&
                ((this.ContributionType == null && other.ContributionType == null) || (this.ContributionType?.Equals(other.ContributionType) == true)) &&
                ((this.CreatorProfile == null && other.CreatorProfile == null) || (this.CreatorProfile?.Equals(other.CreatorProfile) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreatorProfileId = {(this.CreatorProfileId == null ? "null" : this.CreatorProfileId.ToString())}");
            toStringOutput.Add($"this.WorkoutSourceURL = {(this.WorkoutSourceURL == null ? "null" : this.WorkoutSourceURL)}");
            toStringOutput.Add($"this.ContributionType = {(this.ContributionType == null ? "null" : this.ContributionType.ToString())}");
            toStringOutput.Add($"this.CreatorProfile = {(this.CreatorProfile == null ? "null" : this.CreatorProfile.ToString())}");
        }
    }
}