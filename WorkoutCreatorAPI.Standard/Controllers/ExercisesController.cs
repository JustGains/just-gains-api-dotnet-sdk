// <copyright file="ExercisesController.cs" company="APIMatic">
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
    /// ExercisesController.
    /// </summary>
    public class ExercisesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExercisesController"/> class.
        /// </summary>
        internal ExercisesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getExercises EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCodes">Optional parameter: List of exercise category codes to filter by.</param>
        /// <param name="exerciseTypeCodes">Optional parameter: List of exercise types to filter by.</param>
        /// <param name="exerciseEquipmentCodes">Optional parameter: List of exercise equipment to filter by.</param>
        /// <param name="exerciseMuscleCodes">Optional parameter: Example: .</param>
        /// <param name="exerciseMetricCodes">Optional parameter: List of exercise metrics to filter by.</param>
        /// <param name="publishedStatusCodes">Optional parameter: List of publish statuses to filter by.</param>
        /// <param name="localeCode">Optional parameter: Locale to filter by.</param>
        /// <param name="pageIndex">Optional parameter: Page index for pagination.</param>
        /// <param name="pageSize">Optional parameter: Page size for pagination.</param>
        /// <returns>Returns the Models.ExercisesResponse response from the API call.</returns>
        public Models.ExercisesResponse GetExercises(
                List<string> exerciseCategoryCodes = null,
                List<string> exerciseTypeCodes = null,
                List<string> exerciseEquipmentCodes = null,
                List<string> exerciseMuscleCodes = null,
                List<string> exerciseMetricCodes = null,
                List<string> publishedStatusCodes = null,
                string localeCode = "en-US",
                int? pageIndex = 1,
                int? pageSize = 100)
            => CoreHelper.RunTask(GetExercisesAsync(exerciseCategoryCodes, exerciseTypeCodes, exerciseEquipmentCodes, exerciseMuscleCodes, exerciseMetricCodes, publishedStatusCodes, localeCode, pageIndex, pageSize));

        /// <summary>
        /// getExercises EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCodes">Optional parameter: List of exercise category codes to filter by.</param>
        /// <param name="exerciseTypeCodes">Optional parameter: List of exercise types to filter by.</param>
        /// <param name="exerciseEquipmentCodes">Optional parameter: List of exercise equipment to filter by.</param>
        /// <param name="exerciseMuscleCodes">Optional parameter: Example: .</param>
        /// <param name="exerciseMetricCodes">Optional parameter: List of exercise metrics to filter by.</param>
        /// <param name="publishedStatusCodes">Optional parameter: List of publish statuses to filter by.</param>
        /// <param name="localeCode">Optional parameter: Locale to filter by.</param>
        /// <param name="pageIndex">Optional parameter: Page index for pagination.</param>
        /// <param name="pageSize">Optional parameter: Page size for pagination.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesResponse response from the API call.</returns>
        public async Task<Models.ExercisesResponse> GetExercisesAsync(
                List<string> exerciseCategoryCodes = null,
                List<string> exerciseTypeCodes = null,
                List<string> exerciseEquipmentCodes = null,
                List<string> exerciseMuscleCodes = null,
                List<string> exerciseMetricCodes = null,
                List<string> publishedStatusCodes = null,
                string localeCode = "en-US",
                int? pageIndex = 1,
                int? pageSize = 100,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("exerciseCategoryCodes", exerciseCategoryCodes))
                      .Query(_query => _query.Setup("exerciseTypeCodes", exerciseTypeCodes))
                      .Query(_query => _query.Setup("exerciseEquipmentCodes", exerciseEquipmentCodes))
                      .Query(_query => _query.Setup("exerciseMuscleCodes", exerciseMuscleCodes))
                      .Query(_query => _query.Setup("exerciseMetricCodes", exerciseMetricCodes))
                      .Query(_query => _query.Setup("publishedStatusCodes", publishedStatusCodes))
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))
                      .Query(_query => _query.Setup("pageIndex", pageIndex ?? 1))
                      .Query(_query => _query.Setup("pageSize", pageSize ?? 100))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new Exercises400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new exercise EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="localeCode">Optional parameter: Locale code to specify the language to return the newly created exercise in..</param>
        /// <returns>Returns the Models.ExercisesResponse1 response from the API call.</returns>
        public Models.ExercisesResponse1 CreateANewExercise(
                Models.Exercise body,
                string localeCode = "en-US")
            => CoreHelper.RunTask(CreateANewExerciseAsync(body, localeCode));

        /// <summary>
        /// Create a new exercise EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="localeCode">Optional parameter: Locale code to specify the language to return the newly created exercise in..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesResponse1 response from the API call.</returns>
        public async Task<Models.ExercisesResponse1> CreateANewExerciseAsync(
                Models.Exercise body,
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/exercises")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise data", (_reason, _context) => new Exercises400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getExercise EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="localeCode">Optional parameter: Locale code to specify the language for exercise details.</param>
        /// <returns>Returns the Models.ExercisesResponse2 response from the API call.</returns>
        public Models.ExercisesResponse2 GetExercise(
                string exerciseCode,
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetExerciseAsync(exerciseCode, localeCode));

        /// <summary>
        /// getExercise EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="localeCode">Optional parameter: Locale code to specify the language for exercise details.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesResponse2 response from the API call.</returns>
        public async Task<Models.ExercisesResponse2> GetExerciseAsync(
                string exerciseCode,
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises/{exerciseCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new Exercises400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise not found", (_reason, _context) => new Exercises404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update an exercise EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExercisesResponse2 response from the API call.</returns>
        public Models.ExercisesResponse2 UpdateAnExercise(
                string exerciseCode,
                Models.Exercise body)
            => CoreHelper.RunTask(UpdateAnExerciseAsync(exerciseCode, body));

        /// <summary>
        /// Update an exercise EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesResponse2 response from the API call.</returns>
        public async Task<Models.ExercisesResponse2> UpdateAnExerciseAsync(
                string exerciseCode,
                Models.Exercise body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercises/{exerciseCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid exercise data", (_reason, _context) => new Exercises400ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error", (_reason, _context) => new Exercises500ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an exercise EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExercisesResponse4 response from the API call.</returns>
        public Models.ExercisesResponse4 DeleteAnExercise(
                string exerciseCode)
            => CoreHelper.RunTask(DeleteAnExerciseAsync(exerciseCode));

        /// <summary>
        /// Delete an exercise EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesResponse4 response from the API call.</returns>
        public async Task<Models.ExercisesResponse4> DeleteAnExerciseAsync(
                string exerciseCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/exercises/{exerciseCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new Exercises400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new Exercises401ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise not found", (_reason, _context) => new Exercises404ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error", (_reason, _context) => new Exercises500ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getExerciseTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The unique code of the exercise.</param>
        /// <returns>Returns the Models.ExercisesTranslationsResponse response from the API call.</returns>
        public Models.ExercisesTranslationsResponse GetExerciseTranslations(
                string exerciseCode)
            => CoreHelper.RunTask(GetExerciseTranslationsAsync(exerciseCode));

        /// <summary>
        /// getExerciseTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The unique code of the exercise.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesTranslationsResponse response from the API call.</returns>
        public async Task<Models.ExercisesTranslationsResponse> GetExerciseTranslationsAsync(
                string exerciseCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesTranslationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises/{exerciseCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExercisesTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise translations not found", (_reason, _context) => new ExercisesTranslations404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateExerciseTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The unique code of the exercise.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExercisesTranslationsResponse1 response from the API call.</returns>
        public Models.ExercisesTranslationsResponse1 UpdateExerciseTranslations(
                string exerciseCode,
                List<Models.ExerciseTranslation> body)
            => CoreHelper.RunTask(UpdateExerciseTranslationsAsync(exerciseCode, body));

        /// <summary>
        /// updateExerciseTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The unique code of the exercise.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesTranslationsResponse1 response from the API call.</returns>
        public async Task<Models.ExercisesTranslationsResponse1> UpdateExerciseTranslationsAsync(
                string exerciseCode,
                List<Models.ExerciseTranslation> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesTranslationsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercises/{exerciseCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExercisesTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise not found", (_reason, _context) => new ExercisesTranslations404ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Validation error", (_reason, _context) => new ExercisesTranslations422ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getExerciseMuscleGroup EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The unique code of the exercise.</param>
        /// <param name="localeCode">Optional parameter: The locale code for the muscle group names (e.g., 'en-US', 'es-ES').</param>
        /// <returns>Returns the Models.ExercisesMuscleGroupsResponse response from the API call.</returns>
        public Models.ExercisesMuscleGroupsResponse GetExerciseMuscleGroup(
                string exerciseCode,
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetExerciseMuscleGroupAsync(exerciseCode, localeCode));

        /// <summary>
        /// getExerciseMuscleGroup EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The unique code of the exercise.</param>
        /// <param name="localeCode">Optional parameter: The locale code for the muscle group names (e.g., 'en-US', 'es-ES').</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesMuscleGroupsResponse response from the API call.</returns>
        public async Task<Models.ExercisesMuscleGroupsResponse> GetExerciseMuscleGroupAsync(
                string exerciseCode,
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesMuscleGroupsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises/{exerciseCode}/muscle-groups")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExercisesMuscleGroups400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise not found", (_reason, _context) => new ExercisesMuscleGroups404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}