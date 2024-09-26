// <copyright file="MediaAssetAssignment.cs" company="APIMatic">
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
    /// MediaAssetAssignment.
    /// </summary>
    public class MediaAssetAssignment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAssetAssignment"/> class.
        /// </summary>
        public MediaAssetAssignment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAssetAssignment"/> class.
        /// </summary>
        /// <param name="mediaId">mediaId.</param>
        public MediaAssetAssignment(
            Guid? mediaId = null)
        {
            this.MediaId = mediaId;
        }

        /// <summary>
        /// Unique identifier for the media element.
        /// </summary>
        [JsonProperty("mediaId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MediaId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MediaAssetAssignment : ({string.Join(", ", toStringOutput)})";
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
            return obj is MediaAssetAssignment other &&                ((this.MediaId == null && other.MediaId == null) || (this.MediaId?.Equals(other.MediaId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MediaId = {(this.MediaId == null ? "null" : this.MediaId.ToString())}");
        }
    }
}