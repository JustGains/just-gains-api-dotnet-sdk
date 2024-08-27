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
using Newtonsoft.Json.Converters;
using System.Net.Http;
using WorkoutCreatorAPI.Standard;
using WorkoutCreatorAPI.Standard.Exceptions;
using WorkoutCreatorAPI.Standard.Http.Client;
using WorkoutCreatorAPI.Standard.Utilities;

namespace WorkoutCreatorAPI.Standard.Controllers
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
        /// <param name="sortBy">Optional parameter: The field to sort the results by.</param>
        /// <param name="sortOrder">Optional parameter: The order to sort the results in.</param>
        /// <returns>Returns the Models.WorkoutsResponse response from the API call.</returns>
        public Models.WorkoutsResponse GetAPaginatedListOfWorkouts(
                int? page = 1,
                int? pageSize = 20,
                Models.SortBy1Enum? sortBy = Models.SortBy1Enum.CreatedAt,
                Models.SortOrderEnum? sortOrder = Models.SortOrderEnum.Desc)
            => CoreHelper.RunTask(GetAPaginatedListOfWorkoutsAsync(page, pageSize, sortBy, sortOrder));

        /// <summary>
        /// Get a paginated list of workouts EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: The page number to retrieve.</param>
        /// <param name="pageSize">Optional parameter: The number of items to retrieve per page.</param>
        /// <param name="sortBy">Optional parameter: The field to sort the results by.</param>
        /// <param name="sortOrder">Optional parameter: The order to sort the results in.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutsResponse response from the API call.</returns>
        public async Task<Models.WorkoutsResponse> GetAPaginatedListOfWorkoutsAsync(
                int? page = 1,
                int? pageSize = 20,
                Models.SortBy1Enum? sortBy = Models.SortBy1Enum.CreatedAt,
                Models.SortOrderEnum? sortOrder = Models.SortOrderEnum.Desc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workouts")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page ?? 1))
                      .Query(_query => _query.Setup("pageSize", pageSize ?? 20))
                      .Query(_query => _query.Setup("sortBy", (sortBy.HasValue) ? ApiHelper.JsonSerialize(sortBy.Value).Trim('\"') : "createdAt"))
                      .Query(_query => _query.Setup("sortOrder", (sortOrder.HasValue) ? ApiHelper.JsonSerialize(sortOrder.Value).Trim('\"') : "desc"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid pagination parameters", (_reason, _context) => new Workouts400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new workout EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutsResponse1 response from the API call.</returns>
        public Models.WorkoutsResponse1 CreateANewWorkout(
                Models.Workout body)
            => CoreHelper.RunTask(CreateANewWorkoutAsync(body));

        /// <summary>
        /// Create a new workout EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutsResponse1 response from the API call.</returns>
        public async Task<Models.WorkoutsResponse1> CreateANewWorkoutAsync(
                Models.Workout body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workouts")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid workout data", (_reason, _context) => new Workouts400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get a workout by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutsResponse1 response from the API call.</returns>
        public Models.WorkoutsResponse1 GetAWorkoutByID(
                int workoutId)
            => CoreHelper.RunTask(GetAWorkoutByIDAsync(workoutId));

        /// <summary>
        /// Get a workout by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutsResponse1 response from the API call.</returns>
        public async Task<Models.WorkoutsResponse1> GetAWorkoutByIDAsync(
                int workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workouts/{workoutId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new Workouts404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a copy of an existing workout, preserving creator credits and adding the current user as a new contributor.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to duplicate.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutsDuplicateResponse response from the API call.</returns>
        public Models.WorkoutsDuplicateResponse DuplicateAWorkout(
                int workoutId,
                Models.WorkoutsDuplicateRequest body)
            => CoreHelper.RunTask(DuplicateAWorkoutAsync(workoutId, body));

        /// <summary>
        /// Creates a copy of an existing workout, preserving creator credits and adding the current user as a new contributor.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to duplicate.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutsDuplicateResponse response from the API call.</returns>
        public async Task<Models.WorkoutsDuplicateResponse> DuplicateAWorkoutAsync(
                int workoutId,
                Models.WorkoutsDuplicateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutsDuplicateResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workouts/{workoutId}/duplicate")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("workoutId", workoutId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid request data", (_reason, _context) => new WorkoutsDuplicate400ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission denied", (_reason, _context) => new WorkoutsDuplicate403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new WorkoutsDuplicate404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}