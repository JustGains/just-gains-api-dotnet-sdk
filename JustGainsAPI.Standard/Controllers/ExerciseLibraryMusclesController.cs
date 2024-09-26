// <copyright file="ExerciseLibraryMusclesController.cs" company="APIMatic">
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
    /// ExerciseLibraryMusclesController.
    /// </summary>
    public class ExerciseLibraryMusclesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseLibraryMusclesController"/> class.
        /// </summary>
        internal ExerciseLibraryMusclesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getMuscles EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: Locale code to filter muscles by language.</param>
        /// <returns>Returns the Models.MuscleListResponse response from the API call.</returns>
        public Models.MuscleListResponse GetMuscles(
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetMusclesAsync(localeCode));

        /// <summary>
        /// getMuscles EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: Locale code to filter muscles by language.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MuscleListResponse response from the API call.</returns>
        public async Task<Models.MuscleListResponse> GetMusclesAsync(
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MuscleListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/muscles")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to retrieve muscles", (_reason, _context) => new Muscles400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getMuscleTranslations EndPoint.
        /// </summary>
        /// <param name="muscleCode">Required parameter: The unique identifier code of the muscle to retrieve translations for.</param>
        /// <returns>Returns the Models.MuscleTranslationListResponse response from the API call.</returns>
        public Models.MuscleTranslationListResponse GetMuscleTranslations(
                string muscleCode)
            => CoreHelper.RunTask(GetMuscleTranslationsAsync(muscleCode));

        /// <summary>
        /// getMuscleTranslations EndPoint.
        /// </summary>
        /// <param name="muscleCode">Required parameter: The unique identifier code of the muscle to retrieve translations for.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MuscleTranslationListResponse response from the API call.</returns>
        public async Task<Models.MuscleTranslationListResponse> GetMuscleTranslationsAsync(
                string muscleCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MuscleTranslationListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/muscles/{muscleCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("muscleCode", muscleCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to retrieve muscle translations", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Muscle not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateMuscleTranslations EndPoint.
        /// </summary>
        /// <param name="muscleCode">Required parameter: The unique identifier code of the muscle to update translations for.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.MusclesTranslationsResponse1 response from the API call.</returns>
        public Models.MusclesTranslationsResponse1 UpdateMuscleTranslations(
                string muscleCode,
                List<Models.MuscleTranslation> body)
            => CoreHelper.RunTask(UpdateMuscleTranslationsAsync(muscleCode, body));

        /// <summary>
        /// updateMuscleTranslations EndPoint.
        /// </summary>
        /// <param name="muscleCode">Required parameter: The unique identifier code of the muscle to update translations for.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MusclesTranslationsResponse1 response from the API call.</returns>
        public async Task<Models.MusclesTranslationsResponse1> UpdateMuscleTranslationsAsync(
                string muscleCode,
                List<Models.MuscleTranslation> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MusclesTranslationsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/muscles/{muscleCode}/translations")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("muscleCode", muscleCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to update muscle translations", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Muscle not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}