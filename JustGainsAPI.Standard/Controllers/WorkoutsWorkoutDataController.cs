// <copyright file="WorkoutsWorkoutDataController.cs" company="APIMatic">
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
    /// WorkoutsWorkoutDataController.
    /// </summary>
    public class WorkoutsWorkoutDataController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkoutsWorkoutDataController"/> class.
        /// </summary>
        internal WorkoutsWorkoutDataController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getWorkoutDataById EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutDataListResponse response from the API call.</returns>
        public Models.WorkoutDataListResponse GetWorkoutDataById(
                Guid workoutId)
            => CoreHelper.RunTask(GetWorkoutDataByIdAsync(workoutId));

        /// <summary>
        /// getWorkoutDataById EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutDataListResponse response from the API call.</returns>
        public async Task<Models.WorkoutDataListResponse> GetWorkoutDataByIdAsync(
                Guid workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutDataListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workouts/{workoutId}/data")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update workout data by workout ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutDataListResponse response from the API call.</returns>
        public Models.WorkoutDataListResponse UpdateWorkoutDataByWorkoutID(
                Guid workoutId,
                List<Models.WorkoutData> body)
            => CoreHelper.RunTask(UpdateWorkoutDataByWorkoutIDAsync(workoutId, body));

        /// <summary>
        /// Update workout data by workout ID EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutDataListResponse response from the API call.</returns>
        public async Task<Models.WorkoutDataListResponse> UpdateWorkoutDataByWorkoutIDAsync(
                Guid workoutId,
                List<Models.WorkoutData> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutDataListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/workouts/{workoutId}/data")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("workoutId", workoutId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid workout data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getWorkoutDetailById EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The unique identifier code of the workout to retrieve the exercise from.</param>
        /// <param name="exerciseCode">Required parameter: The unique identifier code of the exercise to retrieve.</param>
        /// <returns>Returns the Models.WorkoutDataResponse response from the API call.</returns>
        public Models.WorkoutDataResponse GetWorkoutDetailById(
                Guid workoutId,
                string exerciseCode)
            => CoreHelper.RunTask(GetWorkoutDetailByIdAsync(workoutId, exerciseCode));

        /// <summary>
        /// getWorkoutDetailById EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The unique identifier code of the workout to retrieve the exercise from.</param>
        /// <param name="exerciseCode">Required parameter: The unique identifier code of the exercise to retrieve.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutDataResponse response from the API call.</returns>
        public async Task<Models.WorkoutDataResponse> GetWorkoutDetailByIdAsync(
                Guid workoutId,
                string exerciseCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutDataResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workouts/{workoutId}/data/{exerciseCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("workoutId", workoutId))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Workout or exercise not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update exercise in the workout EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The unique identifier code of the workout to update the exercise in.</param>
        /// <param name="exerciseCode">Required parameter: The unique identifier code of the exercise to update.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutDataResponse response from the API call.</returns>
        public Models.WorkoutDataResponse UpdateExerciseInTheWorkout(
                Guid workoutId,
                string exerciseCode,
                Models.WorkoutData body)
            => CoreHelper.RunTask(UpdateExerciseInTheWorkoutAsync(workoutId, exerciseCode, body));

        /// <summary>
        /// Update exercise in the workout EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The unique identifier code of the workout to update the exercise in.</param>
        /// <param name="exerciseCode">Required parameter: The unique identifier code of the exercise to update.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutDataResponse response from the API call.</returns>
        public async Task<Models.WorkoutDataResponse> UpdateExerciseInTheWorkoutAsync(
                Guid workoutId,
                string exerciseCode,
                Models.WorkoutData body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutDataResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/workouts/{workoutId}/data/{exerciseCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("workoutId", workoutId))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Workout or exercise not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes an exercise from the workout EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The unique identifier code of the workout to remove the exercise from.</param>
        /// <param name="exerciseCode">Required parameter: The unique identifier code of the exercise to remove.</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse DeletesAnExerciseFromTheWorkout(
                Guid workoutId,
                string exerciseCode)
            => CoreHelper.RunTask(DeletesAnExerciseFromTheWorkoutAsync(workoutId, exerciseCode));

        /// <summary>
        /// Deletes an exercise from the workout EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: The unique identifier code of the workout to remove the exercise from.</param>
        /// <param name="exerciseCode">Required parameter: The unique identifier code of the exercise to remove.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> DeletesAnExerciseFromTheWorkoutAsync(
                Guid workoutId,
                string exerciseCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/workouts/{workoutId}/data/{exerciseCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("workoutId", workoutId))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Workout or exercise not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}