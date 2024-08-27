// <copyright file="Data17.cs" company="APIMatic">
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
    /// Data17.
    /// </summary>
    public class Data17
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data17"/> class.
        /// </summary>
        public Data17()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data17"/> class.
        /// </summary>
        /// <param name="mediaId">mediaId.</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="filePath">filePath.</param>
        /// <param name="fileUrl">fileUrl.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="fileFormat">fileFormat.</param>
        /// <param name="description">description.</param>
        public Data17(
            Guid? mediaId = null,
            string fileName = null,
            string filePath = null,
            string fileUrl = null,
            int? fileSize = null,
            string fileFormat = null,
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
        [JsonProperty("mediaId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MediaId { get; set; }

        /// <summary>
        /// The name of the file, which may be useful for generating URLs or simple validations.
        /// </summary>
        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// The relative path to the file within the storage system, useful for constructing URLs.
        /// </summary>
        [JsonProperty("filePath", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// The URL to the media file, which may be useful for embedding or downloading.
        /// </summary>
        [JsonProperty("fileUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string FileUrl { get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        [JsonProperty("fileSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileSize { get; set; }

        /// <summary>
        /// File format, extension
        /// </summary>
        [JsonProperty("fileFormat", NullValueHandling = NullValueHandling.Ignore)]
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

            return $"Data17 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data17 other &&                ((this.MediaId == null && other.MediaId == null) || (this.MediaId?.Equals(other.MediaId) == true)) &&
                ((this.FileName == null && other.FileName == null) || (this.FileName?.Equals(other.FileName) == true)) &&
                ((this.FilePath == null && other.FilePath == null) || (this.FilePath?.Equals(other.FilePath) == true)) &&
                ((this.FileUrl == null && other.FileUrl == null) || (this.FileUrl?.Equals(other.FileUrl) == true)) &&
                ((this.FileSize == null && other.FileSize == null) || (this.FileSize?.Equals(other.FileSize) == true)) &&
                ((this.FileFormat == null && other.FileFormat == null) || (this.FileFormat?.Equals(other.FileFormat) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MediaId = {(this.MediaId == null ? "null" : this.MediaId.ToString())}");
            toStringOutput.Add($"this.FileName = {(this.FileName == null ? "null" : this.FileName)}");
            toStringOutput.Add($"this.FilePath = {(this.FilePath == null ? "null" : this.FilePath)}");
            toStringOutput.Add($"this.FileUrl = {(this.FileUrl == null ? "null" : this.FileUrl)}");
            toStringOutput.Add($"this.FileSize = {(this.FileSize == null ? "null" : this.FileSize.ToString())}");
            toStringOutput.Add($"this.FileFormat = {(this.FileFormat == null ? "null" : this.FileFormat)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
        }
    }
}