// <copyright file="ExerciseLibraryExercisesExerciseThumbnailsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Exceptions;
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace JustGainsAPI.Standard.Controllers
{
    /// <summary>
    /// ExerciseLibraryExercisesExerciseThumbnailsController.
    /// </summary>
    public class ExerciseLibraryExercisesExerciseThumbnailsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseLibraryExercisesExerciseThumbnailsController"/> class.
        /// </summary>
        internal ExerciseLibraryExercisesExerciseThumbnailsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getExerciseThumbnails EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve thumbnails for.</param>
        /// <returns>Returns the Models.ExerciseThumbnailListResponse response from the API call.</returns>
        public Models.ExerciseThumbnailListResponse GetExerciseThumbnails(
                string exerciseCode)
            => CoreHelper.RunTask(GetExerciseThumbnailsAsync(exerciseCode));

        /// <summary>
        /// getExerciseThumbnails EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve thumbnails for.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseThumbnailListResponse response from the API call.</returns>
        public async Task<Models.ExerciseThumbnailListResponse> GetExerciseThumbnailsAsync(
                string exerciseCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseThumbnailListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises/{exerciseCode}/thumbnails")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise code", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise thumbnails not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getExerciseThumbnailByUserId EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve thumbnail for.</param>
        /// <param name="creatorProfileId">Required parameter: The creatorProfileId of the creator whose thumbnail we're referencing.</param>
        /// <returns>Returns the Models.ExerciseThumbnailResponse response from the API call.</returns>
        public Models.ExerciseThumbnailResponse GetExerciseThumbnailByUserId(
                string exerciseCode,
                string creatorProfileId)
            => CoreHelper.RunTask(GetExerciseThumbnailByUserIdAsync(exerciseCode, creatorProfileId));

        /// <summary>
        /// getExerciseThumbnailByUserId EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve thumbnail for.</param>
        /// <param name="creatorProfileId">Required parameter: The creatorProfileId of the creator whose thumbnail we're referencing.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseThumbnailResponse response from the API call.</returns>
        public async Task<Models.ExerciseThumbnailResponse> GetExerciseThumbnailByUserIdAsync(
                string exerciseCode,
                string creatorProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseThumbnailResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises/{exerciseCode}/thumbnails/{creatorProfileId}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise code or user ID", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise thumbnail not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Add or update exercise thumbnail EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to add or update thumbnail for.</param>
        /// <param name="creatorProfileId">Required parameter: The creatorProfileId of the thumbnail creator.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseThumbnailResponse response from the API call.</returns>
        public Models.ExerciseThumbnailResponse AddOrUpdateExerciseThumbnail(
                string exerciseCode,
                string creatorProfileId,
                Models.MediaAssetAssignment body)
            => CoreHelper.RunTask(AddOrUpdateExerciseThumbnailAsync(exerciseCode, creatorProfileId, body));

        /// <summary>
        /// Add or update exercise thumbnail EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to add or update thumbnail for.</param>
        /// <param name="creatorProfileId">Required parameter: The creatorProfileId of the thumbnail creator.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseThumbnailResponse response from the API call.</returns>
        public async Task<Models.ExerciseThumbnailResponse> AddOrUpdateExerciseThumbnailAsync(
                string exerciseCode,
                string creatorProfileId,
                Models.MediaAssetAssignment body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseThumbnailResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercises/{exerciseCode}/thumbnails/{creatorProfileId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise thumbnail data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an exercise thumbnail EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code.</param>
        /// <param name="creatorProfileId">Required parameter: The creatorProfileId of the thumbnail creator.</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse DeleteAnExerciseThumbnail(
                string exerciseCode,
                string creatorProfileId)
            => CoreHelper.RunTask(DeleteAnExerciseThumbnailAsync(exerciseCode, creatorProfileId));

        /// <summary>
        /// Delete an exercise thumbnail EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code.</param>
        /// <param name="creatorProfileId">Required parameter: The creatorProfileId of the thumbnail creator.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> DeleteAnExerciseThumbnailAsync(
                string exerciseCode,
                string creatorProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/exercises/{exerciseCode}/thumbnails/{creatorProfileId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise thumbnail not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}