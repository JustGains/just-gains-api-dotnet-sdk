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
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Exceptions;
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace JustGainsAPI.Standard.Controllers
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
        /// <returns>Returns the Models.ExerciseCategoryListResponse response from the API call.</returns>
        public Models.ExerciseCategoryListResponse GetExerciseCategories(
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetExerciseCategoriesAsync(localeCode));

        /// <summary>
        /// getExerciseCategories EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale for returned category names.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseCategoryListResponse response from the API call.</returns>
        public async Task<Models.ExerciseCategoryListResponse> GetExerciseCategoriesAsync(
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseCategoryListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercise-categories")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// createExerciseCategory EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse CreateExerciseCategory(
                Models.ExerciseCategory body)
            => CoreHelper.RunTask(CreateExerciseCategoryAsync(body));

        /// <summary>
        /// createExerciseCategory EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> CreateExerciseCategoryAsync(
                Models.ExerciseCategory body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/exercise-categories")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update an exercise category EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse UpdateAnExerciseCategory(
                string exerciseCategoryCode,
                Models.ExerciseCategory body)
            => CoreHelper.RunTask(UpdateAnExerciseCategoryAsync(exerciseCategoryCode, body));

        /// <summary>
        /// Update an exercise category EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> UpdateAnExerciseCategoryAsync(
                string exerciseCategoryCode,
                Models.ExerciseCategory body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercise-categories/{exerciseCategoryCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCategoryCode", exerciseCategoryCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Category not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an exercise category EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse DeleteAnExerciseCategory(
                string exerciseCategoryCode)
            => CoreHelper.RunTask(DeleteAnExerciseCategoryAsync(exerciseCategoryCode));

        /// <summary>
        /// Delete an exercise category EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> DeleteAnExerciseCategoryAsync(
                string exerciseCategoryCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/exercise-categories/{exerciseCategoryCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCategoryCode", exerciseCategoryCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Category not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getExerciseCategoryTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: The unique code of the exercise category.</param>
        /// <returns>Returns the Models.ExerciseCategoryTranslationListResponse response from the API call.</returns>
        public Models.ExerciseCategoryTranslationListResponse GetExerciseCategoryTranslations(
                string exerciseCategoryCode)
            => CoreHelper.RunTask(GetExerciseCategoryTranslationsAsync(exerciseCategoryCode));

        /// <summary>
        /// getExerciseCategoryTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: The unique code of the exercise category.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseCategoryTranslationListResponse response from the API call.</returns>
        public async Task<Models.ExerciseCategoryTranslationListResponse> GetExerciseCategoryTranslationsAsync(
                string exerciseCategoryCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseCategoryTranslationListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercise-categories/{exerciseCategoryCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCategoryCode", exerciseCategoryCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise category not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateExerciseCategoryTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: The unique code of the exercise category.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse UpdateExerciseCategoryTranslations(
                string exerciseCategoryCode,
                List<Models.ExerciseCategoryTranslation> body)
            => CoreHelper.RunTask(UpdateExerciseCategoryTranslationsAsync(exerciseCategoryCode, body));

        /// <summary>
        /// updateExerciseCategoryTranslations EndPoint.
        /// </summary>
        /// <param name="exerciseCategoryCode">Required parameter: The unique code of the exercise category.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> UpdateExerciseCategoryTranslationsAsync(
                string exerciseCategoryCode,
                List<Models.ExerciseCategoryTranslation> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercise-categories/{exerciseCategoryCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCategoryCode", exerciseCategoryCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise category not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Validation error", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}