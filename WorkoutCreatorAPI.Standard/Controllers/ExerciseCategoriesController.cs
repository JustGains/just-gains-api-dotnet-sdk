// <copyright file="ExerciseCategoriesController.cs" company="APIMatic">
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
    /// ExerciseCategoriesController.
    /// </summary>
    public class ExerciseCategoriesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseCategoriesController"/> class.
        /// </summary>
        internal ExerciseCategoriesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getExerciseCategories EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale for returned category names.</param>
        /// <returns>Returns the Models.ExerciseCategoriesResponse response from the API call.</returns>
        public Models.ExerciseCategoriesResponse GetExerciseCategories(
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetExerciseCategoriesAsync(localeCode));

        /// <summary>
        /// getExerciseCategories EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale for returned category names.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseCategoriesResponse response from the API call.</returns>
        public async Task<Models.ExerciseCategoriesResponse> GetExerciseCategoriesAsync(
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseCategoriesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercise-categories")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// createExerciseCategory EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseCategoriesResponse1 response from the API call.</returns>
        public Models.ExerciseCategoriesResponse1 CreateExerciseCategory(
                Models.ExerciseCategory body)
            => CoreHelper.RunTask(CreateExerciseCategoryAsync(body));

        /// <summary>
        /// createExerciseCategory EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseCategoriesResponse1 response from the API call.</returns>
        public async Task<Models.ExerciseCategoriesResponse1> CreateExerciseCategoryAsync(
                Models.ExerciseCategory body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseCategoriesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/exercise-categories")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ExerciseCategories400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getExerciseCategory EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: Example: .</param>
        /// <param name="localeCode">Optional parameter: The locale for returned category name.</param>
        /// <returns>Returns the Models.ExerciseCategoriesResponse1 response from the API call.</returns>
        public Models.ExerciseCategoriesResponse1 GetExerciseCategory(
                string exerciseCategoryCode,
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetExerciseCategoryAsync(exerciseCategoryCode, localeCode));

        /// <summary>
        /// getExerciseCategory EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: Example: .</param>
        /// <param name="localeCode">Optional parameter: The locale for returned category name.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseCategoriesResponse1 response from the API call.</returns>
        public async Task<Models.ExerciseCategoriesResponse1> GetExerciseCategoryAsync(
                string exerciseCategoryCode,
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseCategoriesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercise-categories/{exerciseCategoryCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCategoryCode", exerciseCategoryCode))
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Exercise Category Not Found", (_reason, _context) => new ExerciseCategories404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update an exercise category EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseCategoriesResponse1 response from the API call.</returns>
        public Models.ExerciseCategoriesResponse1 UpdateAnExerciseCategory(
                string exerciseCategoryCode,
                Models.ExerciseCategory body)
            => CoreHelper.RunTask(UpdateAnExerciseCategoryAsync(exerciseCategoryCode, body));

        /// <summary>
        /// Update an exercise category EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseCategoriesResponse1 response from the API call.</returns>
        public async Task<Models.ExerciseCategoriesResponse1> UpdateAnExerciseCategoryAsync(
                string exerciseCategoryCode,
                Models.ExerciseCategory body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseCategoriesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercise-categories/{exerciseCategoryCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCategoryCode", exerciseCategoryCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ExerciseCategories400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Category not found", (_reason, _context) => new ExerciseCategories404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an exercise category EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseCategoriesResponse4 response from the API call.</returns>
        public Models.ExerciseCategoriesResponse4 DeleteAnExerciseCategory(
                string exerciseCategoryCode)
            => CoreHelper.RunTask(DeleteAnExerciseCategoryAsync(exerciseCategoryCode));

        /// <summary>
        /// Delete an exercise category EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseCategoriesResponse4 response from the API call.</returns>
        public async Task<Models.ExerciseCategoriesResponse4> DeleteAnExerciseCategoryAsync(
                string exerciseCategoryCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseCategoriesResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/exercise-categories/{exerciseCategoryCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCategoryCode", exerciseCategoryCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Category not found", (_reason, _context) => new ExerciseCategories404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getExerciseCategoryTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: The unique code of the exercise category.</param>
        /// <returns>Returns the Models.ExerciseCategoriesTranslationsResponse response from the API call.</returns>
        public Models.ExerciseCategoriesTranslationsResponse GetExerciseCategoryTranslations(
                string exerciseCategoryCode)
            => CoreHelper.RunTask(GetExerciseCategoryTranslationsAsync(exerciseCategoryCode));

        /// <summary>
        /// getExerciseCategoryTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: The unique code of the exercise category.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseCategoriesTranslationsResponse response from the API call.</returns>
        public async Task<Models.ExerciseCategoriesTranslationsResponse> GetExerciseCategoryTranslationsAsync(
                string exerciseCategoryCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseCategoriesTranslationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercise-categories/{exerciseCategoryCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCategoryCode", exerciseCategoryCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExerciseCategoriesTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise category not found", (_reason, _context) => new ExerciseCategoriesTranslations404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateExerciseCategoryTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: The unique code of the exercise category.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseCategoriesTranslationsResponse1 response from the API call.</returns>
        public Models.ExerciseCategoriesTranslationsResponse1 UpdateExerciseCategoryTranslations(
                string exerciseCategoryCode,
                List<Models.ExerciseCategoryTranslation> body)
            => CoreHelper.RunTask(UpdateExerciseCategoryTranslationsAsync(exerciseCategoryCode, body));

        /// <summary>
        /// updateExerciseCategoryTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: The unique code of the exercise category.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseCategoriesTranslationsResponse1 response from the API call.</returns>
        public async Task<Models.ExerciseCategoriesTranslationsResponse1> UpdateExerciseCategoryTranslationsAsync(
                string exerciseCategoryCode,
                List<Models.ExerciseCategoryTranslation> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseCategoriesTranslationsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercise-categories/{exerciseCategoryCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCategoryCode", exerciseCategoryCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExerciseCategoriesTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise category not found", (_reason, _context) => new ExerciseCategoriesTranslations404ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Validation error", (_reason, _context) => new ExerciseCategoriesTranslations422ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}