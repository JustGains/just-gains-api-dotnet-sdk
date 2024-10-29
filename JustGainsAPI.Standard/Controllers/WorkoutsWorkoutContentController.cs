// <copyright file="WorkoutsWorkoutContentController.cs" company="APIMatic">
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
    /// WorkoutsWorkoutContentController.
    /// </summary>
    public class WorkoutsWorkoutContentController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsWorkoutContentController"/> class.
        /// </summary>
        internal WorkoutsWorkoutContentController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Get workout content by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to retrieve.</param>
        /// <returns>Returns the Models.WorkoutContentResponse response from the API call.</returns>
        public Models.WorkoutContentResponse GetWorkoutContentByID(
                Guid workoutId)
            => CoreHelper.RunTask(GetWorkoutContentByIDAsync(workoutId));

        /// <summary>
        /// Get workout content by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to retrieve.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutContentResponse response from the API call.</returns>
        public async Task<Models.WorkoutContentResponse> GetWorkoutContentByIDAsync(
                Guid workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutContentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workouts/{workoutId}/content")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update workout content by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to update.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutContentResponse response from the API call.</returns>
        public Models.WorkoutContentResponse UpdateWorkoutContentByID(
                Guid workoutId,
                Models.WorkoutContent body = null)
            => CoreHelper.RunTask(UpdateWorkoutContentByIDAsync(workoutId, body));

        /// <summary>
        /// Update workout content by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to update.</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutContentResponse response from the API call.</returns>
        public async Task<Models.WorkoutContentResponse> UpdateWorkoutContentByIDAsync(
                Guid workoutId,
                Models.WorkoutContent body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutContentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/workouts/{workoutId}/content")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("workoutId", workoutId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}