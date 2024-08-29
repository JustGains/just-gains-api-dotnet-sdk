// <copyright file="ExerciseMetrics400Error2Exception.cs" company="APIMatic">
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
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Models;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JustGainsAPI.Standard.Exceptions
{
    /// <summary>
    /// ExerciseMetrics400Error2Exception.
    /// </summary>
    public class ExerciseMetrics400Error2Exception : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMetrics400Error2Exception"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ExerciseMetrics400Error2Exception(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// The status of the response, corresponding to standard HTTP status codes.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// A human-readable message describing the result of the operation.
        /// </summary>
        [JsonProperty("message")]
        public new string Message { get; set; }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public object Errors { get; set; }
    }
}