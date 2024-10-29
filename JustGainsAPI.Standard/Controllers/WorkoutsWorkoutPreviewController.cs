// <copyright file="WorkoutsWorkoutPreviewController.cs" company="APIMatic">
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
    /// WorkoutsWorkoutPreviewController.
    /// </summary>
    public class WorkoutsWorkoutPreviewController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsWorkoutPreviewController"/> class.
        /// </summary>
        internal WorkoutsWorkoutPreviewController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Get workout preview by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to retrieve.</param>
        /// <returns>Returns the Models.WorkoutPreviewResponse response from the API call.</returns>
        public Models.WorkoutPreviewResponse GetWorkoutPreviewByID(
                Guid workoutId)
            => CoreHelper.RunTask(GetWorkoutPreviewByIDAsync(workoutId));

        /// <summary>
        /// Get workout preview by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to retrieve.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutPreviewResponse response from the API call.</returns>
        public async Task<Models.WorkoutPreviewResponse> GetWorkoutPreviewByIDAsync(
                Guid workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutPreviewResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workouts/{workoutId}/preview")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}