// <copyright file="WorkoutsController.cs" company="APIMatic">
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
    /// WorkoutsController.
    /// </summary>
    public class WorkoutsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsController"/> class.
        /// </summary>
        internal WorkoutsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Get a paginated list of workouts EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: The page number to retrieve.</param>
        /// <param name="pageSize">Optional parameter: The number of items to retrieve per page.</param>
        /// <param name="sortBy">Optional parameter: Example: .</param>
        /// <param name="sortOrder">Optional parameter: The order to sort the results in.</param>
        /// <returns>Returns the Models.WorkoutTableListResponse response from the API call.</returns>
        public Models.WorkoutTableListResponse GetAPaginatedListOfWorkouts(
                int? page = 1,
                int? pageSize = 20,
                string sortBy = null,
                Models.SortOrderEnum? sortOrder = Models.SortOrderEnum.Desc)
            => CoreHelper.RunTask(GetAPaginatedListOfWorkoutsAsync(page, pageSize, sortBy, sortOrder));

        /// <summary>
        /// Get a paginated list of workouts EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: The page number to retrieve.</param>
        /// <param name="pageSize">Optional parameter: The number of items to retrieve per page.</param>
        /// <param name="sortBy">Optional parameter: Example: .</param>
        /// <param name="sortOrder">Optional parameter: The order to sort the results in.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutTableListResponse response from the API call.</returns>
        public async Task<Models.WorkoutTableListResponse> GetAPaginatedListOfWorkoutsAsync(
                int? page = 1,
                int? pageSize = 20,
                string sortBy = null,
                Models.SortOrderEnum? sortOrder = Models.SortOrderEnum.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutTableListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workouts")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page ?? 1))
                      .Query(_query => _query.Setup("pageSize", pageSize ?? 20))
                      .Query(_query => _query.Setup("sortBy", sortBy))
                      .Query(_query => _query.Setup("sortOrder", (sortOrder.HasValue) ? ApiHelper.JsonSerialize(sortOrder.Value).Trim('\"') : "desc"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid pagination parameters", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new workout EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public Models.WorkoutResponse CreateANewWorkout(
                Models.Workout body)
            => CoreHelper.RunTask(CreateANewWorkoutAsync(body));

        /// <summary>
        /// Create a new workout EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public async Task<Models.WorkoutResponse> CreateANewWorkoutAsync(
                Models.Workout body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workouts")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid workout data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get a workout by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public Models.WorkoutResponse GetAWorkoutByID(
                int workoutId)
            => CoreHelper.RunTask(GetAWorkoutByIDAsync(workoutId));

        /// <summary>
        /// Get a workout by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public async Task<Models.WorkoutResponse> GetAWorkoutByIDAsync(
                int workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workouts/{workoutId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a copy of an existing workout, preserving creator credits and adding the current user as a new contributor.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to duplicate.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public Models.WorkoutResponse DuplicateAWorkout(
                int workoutId,
                Models.WorkoutsDuplicateRequest body)
            => CoreHelper.RunTask(DuplicateAWorkoutAsync(workoutId, body));

        /// <summary>
        /// Creates a copy of an existing workout, preserving creator credits and adding the current user as a new contributor.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to duplicate.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public async Task<Models.WorkoutResponse> DuplicateAWorkoutAsync(
                int workoutId,
                Models.WorkoutsDuplicateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workouts/{workoutId}/duplicate")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("workoutId", workoutId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid request data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission denied", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}