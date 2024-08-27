// <copyright file="Pagination.cs" company="APIMatic">
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
    /// Pagination.
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination"/> class.
        /// </summary>
        public Pagination()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination"/> class.
        /// </summary>
        /// <param name="currentPage">currentPage.</param>
        /// <param name="totalPages">totalPages.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="hasPrevious">hasPrevious.</param>
        /// <param name="hasNext">hasNext.</param>
        public Pagination(
            int? currentPage = null,
            int? totalPages = null,
            int? pageSize = null,
            int? totalCount = null,
            bool? hasPrevious = null,
            bool? hasNext = null)
        {
            this.CurrentPage = currentPage;
            this.TotalPages = totalPages;
            this.PageSize = pageSize;
            this.TotalCount = totalCount;
            this.HasPrevious = hasPrevious;
            this.HasNext = hasNext;
        }

        /// <summary>
        /// The current page number
        /// </summary>
        [JsonProperty("currentPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The total number of pages
        /// </summary>
        [JsonProperty("totalPages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// The number of items per page
        /// </summary>
        [JsonProperty("pageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The total number of items across all pages
        /// </summary>
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Indicates if there is a previous page
        /// </summary>
        [JsonProperty("hasPrevious", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasPrevious { get; set; }

        /// <summary>
        /// Indicates if there is a next page
        /// </summary>
        [JsonProperty("hasNext", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasNext { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Pagination : ({string.Join(", ", toStringOutput)})";
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
            return obj is Pagination other &&                ((this.CurrentPage == null && other.CurrentPage == null) || (this.CurrentPage?.Equals(other.CurrentPage) == true)) &&
                ((this.TotalPages == null && other.TotalPages == null) || (this.TotalPages?.Equals(other.TotalPages) == true)) &&
                ((this.PageSize == null && other.PageSize == null) || (this.PageSize?.Equals(other.PageSize) == true)) &&
                ((this.TotalCount == null && other.TotalCount == null) || (this.TotalCount?.Equals(other.TotalCount) == true)) &&
                ((this.HasPrevious == null && other.HasPrevious == null) || (this.HasPrevious?.Equals(other.HasPrevious) == true)) &&
                ((this.HasNext == null && other.HasNext == null) || (this.HasNext?.Equals(other.HasNext) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"this.TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
            toStringOutput.Add($"this.TotalCount = {(this.TotalCount == null ? "null" : this.TotalCount.ToString())}");
            toStringOutput.Add($"this.HasPrevious = {(this.HasPrevious == null ? "null" : this.HasPrevious.ToString())}");
            toStringOutput.Add($"this.HasNext = {(this.HasNext == null ? "null" : this.HasNext.ToString())}");
        }
    }
}