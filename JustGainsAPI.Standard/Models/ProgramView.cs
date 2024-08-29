// <copyright file="ProgramView.cs" company="APIMatic">
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
    /// ProgramView.
    /// </summary>
    public class ProgramView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramView"/> class.
        /// </summary>
        public ProgramView()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramView"/> class.
        /// </summary>
        /// <param name="programViewId">programViewId.</param>
        /// <param name="programId">programId.</param>
        /// <param name="sessionId">sessionId.</param>
        /// <param name="viewedAt">viewedAt.</param>
        /// <param name="viewDuration">viewDuration.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="userAgent">userAgent.</param>
        /// <param name="isAuthenticated">isAuthenticated.</param>
        /// <param name="userId">userId.</param>
        public ProgramView(
            int programViewId,
            int programId,
            string sessionId,
            DateTime viewedAt,
            int viewDuration,
            string ipAddress,
            string userAgent,
            bool isAuthenticated,
            Guid? userId = null)
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
        [JsonProperty("programViewId")]
        public int ProgramViewId { get; set; }

        /// <summary>
        /// Identifier of the viewed program.
        /// </summary>
        [JsonProperty("programId")]
        public int ProgramId { get; set; }

        /// <summary>
        /// Identifier of the user who viewed the program, if authenticated.
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Unique identifier for the user's session.
        /// </summary>
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// Timestamp of when the program was viewed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("viewedAt")]
        public DateTime ViewedAt { get; set; }

        /// <summary>
        /// Duration of the view in seconds.
        /// </summary>
        [JsonProperty("viewDuration")]
        public int ViewDuration { get; set; }

        /// <summary>
        /// IP address of the viewer.
        /// </summary>
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// User agent string of the viewer's browser.
        /// </summary>
        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// Indicates whether the viewer was authenticated during this view.
        /// </summary>
        [JsonProperty("isAuthenticated")]
        public bool IsAuthenticated { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProgramView : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProgramView other &&                this.ProgramViewId.Equals(other.ProgramViewId) &&
                this.ProgramId.Equals(other.ProgramId) &&
                ((this.UserId == null && other.UserId == null) || (this.UserId?.Equals(other.UserId) == true)) &&
                ((this.SessionId == null && other.SessionId == null) || (this.SessionId?.Equals(other.SessionId) == true)) &&
                this.ViewedAt.Equals(other.ViewedAt) &&
                this.ViewDuration.Equals(other.ViewDuration) &&
                ((this.IpAddress == null && other.IpAddress == null) || (this.IpAddress?.Equals(other.IpAddress) == true)) &&
                ((this.UserAgent == null && other.UserAgent == null) || (this.UserAgent?.Equals(other.UserAgent) == true)) &&
                this.IsAuthenticated.Equals(other.IsAuthenticated);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProgramViewId = {this.ProgramViewId}");
            toStringOutput.Add($"this.ProgramId = {this.ProgramId}");
            toStringOutput.Add($"this.UserId = {(this.UserId == null ? "null" : this.UserId.ToString())}");
            toStringOutput.Add($"this.SessionId = {(this.SessionId == null ? "null" : this.SessionId)}");
            toStringOutput.Add($"this.ViewedAt = {this.ViewedAt}");
            toStringOutput.Add($"this.ViewDuration = {this.ViewDuration}");
            toStringOutput.Add($"this.IpAddress = {(this.IpAddress == null ? "null" : this.IpAddress)}");
            toStringOutput.Add($"this.UserAgent = {(this.UserAgent == null ? "null" : this.UserAgent)}");
            toStringOutput.Add($"this.IsAuthenticated = {this.IsAuthenticated}");
        }
    }
}