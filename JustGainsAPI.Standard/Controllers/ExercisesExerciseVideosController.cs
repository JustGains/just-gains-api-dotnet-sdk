// <copyright file="ExercisesExerciseVideosController.cs" company="APIMatic">
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
    /// ExercisesExerciseVideosController.
    /// </summary>
    public class ExercisesExerciseVideosController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExercisesExerciseVideosController"/> class.
        /// </summary>
        internal ExercisesExerciseVideosController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getExerciseVideoOn EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve videos for.</param>
        /// <returns>Returns the Models.ExerciseVideoListResponse response from the API call.</returns>
        public Models.ExerciseVideoListResponse GetExerciseVideoOn(
                string exerciseCode)
            => CoreHelper.RunTask(GetExerciseVideoOnAsync(exerciseCode));

        /// <summary>
        /// getExerciseVideoOn EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve videos for.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseVideoListResponse response from the API call.</returns>
        public async Task<Models.ExerciseVideoListResponse> GetExerciseVideoOnAsync(
                string exerciseCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseVideoListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises/{exerciseCode}/videos")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise code", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise videos not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Add new exercise videos EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to add videos to.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseVideoResponse response from the API call.</returns>
        public Models.ExerciseVideoResponse AddNewExerciseVideos(
                string exerciseCode,
                Models.ExerciseVideo body)
            => CoreHelper.RunTask(AddNewExerciseVideosAsync(exerciseCode, body));

        /// <summary>
        /// Add new exercise videos EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to add videos to.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseVideoResponse response from the API call.</returns>
        public async Task<Models.ExerciseVideoResponse> AddNewExerciseVideosAsync(
                string exerciseCode,
                Models.ExerciseVideo body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseVideoResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/exercises/{exerciseCode}/videos")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise video data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update exercise videos EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code of the exercise videos to update.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExercisesVideosResponse2 response from the API call.</returns>
        public Models.ExercisesVideosResponse2 UpdateExerciseVideos(
                string exerciseCode,
                List<Models.ExerciseVideo> body)
            => CoreHelper.RunTask(UpdateExerciseVideosAsync(exerciseCode, body));

        /// <summary>
        /// Update exercise videos EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code of the exercise videos to update.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesVideosResponse2 response from the API call.</returns>
        public async Task<Models.ExercisesVideosResponse2> UpdateExerciseVideosAsync(
                string exerciseCode,
                List<Models.ExerciseVideo> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesVideosResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercises/{exerciseCode}/videos")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise video data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise videos not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getExerciseVideoByUserId EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve videos for.</param>
        /// <param name="userId">Required parameter: The userId of the creator whose videos we're referencing.</param>
        /// <returns>Returns the Models.ExercisesVideosResponse2 response from the API call.</returns>
        public Models.ExercisesVideosResponse2 GetExerciseVideoByUserId(
                string exerciseCode,
                string userId)
            => CoreHelper.RunTask(GetExerciseVideoByUserIdAsync(exerciseCode, userId));

        /// <summary>
        /// getExerciseVideoByUserId EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve videos for.</param>
        /// <param name="userId">Required parameter: The userId of the creator whose videos we're referencing.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesVideosResponse2 response from the API call.</returns>
        public async Task<Models.ExercisesVideosResponse2> GetExerciseVideoByUserIdAsync(
                string exerciseCode,
                string userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesVideosResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises/{exerciseCode}/videos/{userId}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("userId", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise code", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise videos not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an exercise video EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code.</param>
        /// <param name="userId">Required parameter: The userId of the video creator.</param>
        /// <param name="exerciseVideoId">Required parameter: The exercise video ID to delete.</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse DeleteAnExerciseVideo(
                string exerciseCode,
                string userId,
                int exerciseVideoId)
            => CoreHelper.RunTask(DeleteAnExerciseVideoAsync(exerciseCode, userId, exerciseVideoId));

        /// <summary>
        /// Delete an exercise video EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code.</param>
        /// <param name="userId">Required parameter: The userId of the video creator.</param>
        /// <param name="exerciseVideoId">Required parameter: The exercise video ID to delete.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> DeleteAnExerciseVideoAsync(
                string exerciseCode,
                string userId,
                int exerciseVideoId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/exercises/{exerciseCode}/videos/{userId}/{exerciseVideoId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("userId", userId))
                      .Template(_template => _template.Setup("exerciseVideoId", exerciseVideoId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise video not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}