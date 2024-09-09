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
                int workoutId)
            => CoreHelper.RunTask(GetWorkoutDataByIdAsync(workoutId));

        /// <summary>
        /// getWorkoutDataById EndPoint.
        /// </summary>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutDataListResponse response from the API call.</returns>
        public async Task<Models.WorkoutDataListResponse> GetWorkoutDataByIdAsync(
                int workoutId,
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
        /// getWorkoutDetailById EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutDataResponse response from the API call.</returns>
        public Models.WorkoutDataResponse GetWorkoutDetailById(
                string exerciseCode,
                int workoutId)
            => CoreHelper.RunTask(GetWorkoutDetailByIdAsync(exerciseCode, workoutId));

        /// <summary>
        /// getWorkoutDetailById EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutDataResponse response from the API call.</returns>
        public async Task<Models.WorkoutDataResponse> GetWorkoutDetailByIdAsync(
                string exerciseCode,
                int workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutDataResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/workouts/{workoutId}/data/{exerciseCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Workout or exercise not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Add new exercise to the workout EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutDataResponse response from the API call.</returns>
        public Models.WorkoutDataResponse AddNewExerciseToTheWorkout(
                Models.WorkoutData body,
                string exerciseCode,
                int workoutId)
            => CoreHelper.RunTask(AddNewExerciseToTheWorkoutAsync(body, exerciseCode, workoutId));

        /// <summary>
        /// Add new exercise to the workout EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutDataResponse response from the API call.</returns>
        public async Task<Models.WorkoutDataResponse> AddNewExerciseToTheWorkoutAsync(
                Models.WorkoutData body,
                string exerciseCode,
                int workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutDataResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/workouts/{workoutId}/data/{exerciseCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Workout not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update exercise in the workout EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.WorkoutDataResponse response from the API call.</returns>
        public Models.WorkoutDataResponse UpdateExerciseInTheWorkout(
                Models.WorkoutData body,
                string exerciseCode,
                int workoutId)
            => CoreHelper.RunTask(UpdateExerciseInTheWorkoutAsync(body, exerciseCode, workoutId));

        /// <summary>
        /// Update exercise in the workout EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WorkoutDataResponse response from the API call.</returns>
        public async Task<Models.WorkoutDataResponse> UpdateExerciseInTheWorkoutAsync(
                Models.WorkoutData body,
                string exerciseCode,
                int workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WorkoutDataResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/workouts/{workoutId}/data/{exerciseCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Workout or exercise not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deletes an exercise from the workout EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse DeletesAnExerciseFromTheWorkout(
                string exerciseCode,
                int workoutId)
            => CoreHelper.RunTask(DeletesAnExerciseFromTheWorkoutAsync(exerciseCode, workoutId));

        /// <summary>
        /// Deletes an exercise from the workout EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="workoutId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> DeletesAnExerciseFromTheWorkoutAsync(
                string exerciseCode,
                int workoutId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/workouts/{workoutId}/data/{exerciseCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("workoutId", workoutId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Workout or exercise not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}