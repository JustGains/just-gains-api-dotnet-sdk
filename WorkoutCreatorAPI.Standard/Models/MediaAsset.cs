// <copyright file="MediaAsset.cs" company="APIMatic">
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
    /// MediaAsset.
    /// </summary>
    public class MediaAsset
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAsset"/> class.
        /// </summary>
        public MediaAsset()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAsset"/> class.
        /// </summary>
        /// <param name="mediaId">mediaId.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="filePath">filePath.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="fileFormat">fileFormat.</param>
        /// <param name="fileUrl">fileUrl.</param>
        /// <param name="description">description.</param>
        public MediaAsset(
            Guid mediaId,
            string fileName,
            string filePath,
            int fileSize,
            string fileFormat,
            string fileUrl = null,
            string description = null)
        {
            this.MediaId = mediaId;
            this.FileName = fileName;
            this.FilePath = filePath;
            this.FileUrl = fileUrl;
            this.FileSize = fileSize;
            this.FileFormat = fileFormat;
            this.Description = description;
        }

        /// <summary>
        /// Unique identifier for the media element.
        /// </summary>
        [JsonProperty("mediaId")]
        public Guid MediaId { get; set; }

        /// <summary>
        /// The name of the file, which may be useful for generating URLs or simple validations.
        /// </summary>
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// The relative path to the file within the storage system, useful for constructing URLs.
        /// </summary>
        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// The URL to the media file, which may be useful for embedding or downloading.
        /// </summary>
        [JsonProperty("fileUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string FileUrl { get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        /// <summary>
        /// File format, extension
        /// </summary>
        [JsonProperty("fileFormat")]
        public string FileFormat { get; set; }

        /// <summary>
        /// Description of the media element
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MediaAsset : ({string.Join(", ", toStringOutput)})";
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
            return obj is MediaAsset other &&                this.MediaId.Equals(other.MediaId) &&
                ((this.FileName == null && other.FileName == null) || (this.FileName?.Equals(other.FileName) == true)) &&
                ((this.FilePath == null && other.FilePath == null) || (this.FilePath?.Equals(other.FilePath) == true)) &&
                ((this.FileUrl == null && other.FileUrl == null) || (this.FileUrl?.Equals(other.FileUrl) == true)) &&
                this.FileSize.Equals(other.FileSize) &&
                ((this.FileFormat == null && other.FileFormat == null) || (this.FileFormat?.Equals(other.FileFormat) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MediaId = {this.MediaId}");
            toStringOutput.Add($"this.FileName = {(this.FileName == null ? "null" : this.FileName)}");
            toStringOutput.Add($"this.FilePath = {(this.FilePath == null ? "null" : this.FilePath)}");
            toStringOutput.Add($"this.FileUrl = {(this.FileUrl == null ? "null" : this.FileUrl)}");
            toStringOutput.Add($"this.FileSize = {this.FileSize}");
            toStringOutput.Add($"this.FileFormat = {(this.FileFormat == null ? "null" : this.FileFormat)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
        }
    }
}