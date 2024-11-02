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
                Models.WorkoutRequest body)
            => CoreHelper.RunTask(CreateANewWorkoutAsync(body));

        /// <summary>
        /// Create a new workout EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public async Task<Models.WorkoutResponse> CreateANewWorkoutAsync(
                Models.WorkoutRequest body,
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
        /// <param name="workoutId">Required parameter: The ID of the workout to retrieve.</param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public Models.WorkoutResponse GetAWorkoutByID(
                Guid workoutId)
            => CoreHelper.RunTask(GetAWorkoutByIDAsync(workoutId));

        /// <summary>
        /// Get a workout by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to retrieve.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public async Task<Models.WorkoutResponse> GetAWorkoutByIDAsync(
                Guid workoutId,
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
        /// Update a workout by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to update.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public Models.WorkoutResponse UpdateAWorkoutByID(
                Guid workoutId,
                Models.WorkoutUpdate body)
            => CoreHelper.RunTask(UpdateAWorkoutByIDAsync(workoutId, body));

        /// <summary>
        /// Update a workout by ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to update.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public async Task<Models.WorkoutResponse> UpdateAWorkoutByIDAsync(
                Guid workoutId,
                Models.WorkoutUpdate body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/workouts/{workoutId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("workoutId", workoutId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid workout data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission denied", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Soft-deletes a workout and all associated data.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to delete.</param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public Models.WorkoutResponse DeleteAWorkout(
                Guid workoutId)
            => CoreHelper.RunTask(DeleteAWorkoutAsync(workoutId));

        /// <summary>
        /// Soft-deletes a workout and all associated data.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to delete.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public async Task<Models.WorkoutResponse> DeleteAWorkoutAsync(
                Guid workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/workouts/{workoutId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid workout ID format", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Permission denied", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get a workout by workout slug EndPoint.
        /// </summary>
        /// <param name="workoutSlug">Required parameter: The URL slug of the workout.</param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public Models.WorkoutResponse GetAWorkoutByWorkoutSlug(
                string workoutSlug)
            => CoreHelper.RunTask(GetAWorkoutByWorkoutSlugAsync(workoutSlug));

        /// <summary>
        /// Get a workout by workout slug EndPoint.
        /// </summary>
        /// <param name="workoutSlug">Required parameter: The URL slug of the workout.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public async Task<Models.WorkoutResponse> GetAWorkoutByWorkoutSlugAsync(
                string workoutSlug,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workouts/{workoutSlug}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("workoutSlug", workoutSlug))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Adds the specified workout to the current user's bookmarks. If the workout is already bookmarked, the request is idempotent and will not create a duplicate.
        /// </summary>
        /// <param name="workoutId">Required parameter: The unique identifier of the workout to bookmark.</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse BookmarkWorkout(
                Guid workoutId)
            => CoreHelper.RunTask(BookmarkWorkoutAsync(workoutId));

        /// <summary>
        /// Adds the specified workout to the current user's bookmarks. If the workout is already bookmarked, the request is idempotent and will not create a duplicate.
        /// </summary>
        /// <param name="workoutId">Required parameter: The unique identifier of the workout to bookmark.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> BookmarkWorkoutAsync(
                Guid workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/workouts/{workoutId}/bookmark")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Removes the specified workout from the current user's bookmarks. If the workout is not bookmarked, the request is idempotent and will not result in an error.
        /// </summary>
        /// <param name="workoutId">Required parameter: The unique identifier of the workout to remove from bookmarks.</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse RemoveWorkoutBookmark(
                Guid workoutId)
            => CoreHelper.RunTask(RemoveWorkoutBookmarkAsync(workoutId));

        /// <summary>
        /// Removes the specified workout from the current user's bookmarks. If the workout is not bookmarked, the request is idempotent and will not result in an error.
        /// </summary>
        /// <param name="workoutId">Required parameter: The unique identifier of the workout to remove from bookmarks.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> RemoveWorkoutBookmarkAsync(
                Guid workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/workouts/{workoutId}/bookmark")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Creates a copy of an existing workout, preserving creator credits and adding the current user as a new contributor.
        /// </summary>
        /// <param name="workoutId">Required parameter: The ID of the workout to duplicate.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutResponse response from the API call.</returns>
        public Models.WorkoutResponse DuplicateAWorkout(
                Guid workoutId,
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
                Guid workoutId,
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