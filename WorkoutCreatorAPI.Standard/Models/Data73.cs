// <copyright file="Data73.cs" company="APIMatic">
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
    /// Data73.
    /// </summary>
    public class Data73
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data73"/> class.
        /// </summary>
        public Data73()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data73"/> class.
        /// </summary>
        /// <param name="programViewId">programViewId.</param>
        /// <param name="programId">programId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="viewedAt">viewedAt.</param>
        /// <param name="viewDuration">viewDuration.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="userAgent">userAgent.</param>
        /// <param name="isAuthenticated">isAuthenticated.</param>
        public Data73(
            int? programViewId = null,
            int? programId = null,
            Guid? userId = null,
            string sessionId = null,
            DateTime? viewedAt = null,
            int? viewDuration = null,
            string ipAddress = null,
            string userAgent = null,
            bool? isAuthenticated = null)
        {
            this.ProgramViewId = programViewId;
            this.ProgramId = programId;
            this.UserId = userId;
            this.SessionId = sessionId;
            this.ViewedAt = viewedAt;
            this.ViewDuration = viewDuration;
            this.IpAddress = ipAddress;
            this.UserAgent = userAgent;
            this.IsAuthenticated = isAuthenticated;
        }

        /// <summary>
        /// Unique identifier for this program view.
        /// </summary>
        [JsonProperty("programViewId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProgramViewId { get; set; }

        /// <summary>
        /// Identifier of the viewed program.
        /// </summary>
        [JsonProperty("programId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProgramId { get; set; }

        /// <summary>
        /// Identifier of the user who viewed the program, if authenticated.
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Unique identifier for the user's session.
        /// </summary>
        [JsonProperty("sessionId", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionId { get; set; }

        /// <summary>
        /// Timestamp of when the program was viewed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("viewedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ViewedAt { get; set; }

        /// <summary>
        /// Duration of the view in seconds.
        /// </summary>
        [JsonProperty("viewDuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? ViewDuration { get; set; }

        /// <summary>
        /// IP address of the viewer.
        /// </summary>
        [JsonProperty("ipAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// User agent string of the viewer's browser.
        /// </summary>
        [JsonProperty("userAgent", NullValueHandling = NullValueHandling.Ignore)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Indicates whether the viewer was authenticated during this view.
        /// </summary>
        [JsonProperty("isAuthenticated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAuthenticated { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data73 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data73 other &&                ((this.ProgramViewId == null && other.ProgramViewId == null) || (this.ProgramViewId?.Equals(other.ProgramViewId) == true)) &&
                ((this.ProgramId == null && other.ProgramId == null) || (this.ProgramId?.Equals(other.ProgramId) == true)) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.SessionId == null && other.SessionId == null) || (this.SessionId?.Equals(other.SessionId) == true)) &&
                ((this.ViewedAt == null && other.ViewedAt == null) || (this.ViewedAt?.Equals(other.ViewedAt) == true)) &&
                ((this.ViewDuration == null && other.ViewDuration == null) || (this.ViewDuration?.Equals(other.ViewDuration) == true)) &&
                ((this.IpAddress == null && other.IpAddress == null) || (this.IpAddress?.Equals(other.IpAddress) == true)) &&
                ((this.UserAgent == null && other.UserAgent == null) || (this.UserAgent?.Equals(other.UserAgent) == true)) &&
                ((this.IsAuthenticated == null && other.IsAuthenticated == null) || (this.IsAuthenticated?.Equals(other.IsAuthenticated) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProgramViewId = {(this.ProgramViewId == null ? "null" : this.ProgramViewId.ToString())}");
            toStringOutput.Add($"this.ProgramId = {(this.ProgramId == null ? "null" : this.ProgramId.ToString())}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId.ToString())}");
            toStringOutput.Add($"this.SessionId = {(this.SessionId == null ? "null" : this.SessionId)}");
            toStringOutput.Add($"this.ViewedAt = {(this.ViewedAt == null ? "null" : this.ViewedAt.ToString())}");
            toStringOutput.Add($"this.ViewDuration = {(this.ViewDuration == null ? "null" : this.ViewDuration.ToString())}");
            toStringOutput.Add($"this.IpAddress = {(this.IpAddress == null ? "null" : this.IpAddress)}");
            toStringOutput.Add($"this.UserAgent = {(this.UserAgent == null ? "null" : this.UserAgent)}");
            toStringOutput.Add($"this.IsAuthenticated = {(this.IsAuthenticated == null ? "null" : this.IsAuthenticated.ToString())}");
        }
    }
}