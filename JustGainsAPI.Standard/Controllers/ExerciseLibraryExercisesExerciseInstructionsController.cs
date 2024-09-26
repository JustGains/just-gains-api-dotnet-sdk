// <copyright file="ExerciseLibraryExercisesExerciseInstructionsController.cs" company="APIMatic">
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
    /// ExerciseLibraryExercisesExerciseInstructionsController.
    /// </summary>
    public class ExerciseLibraryExercisesExerciseInstructionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseLibraryExercisesExerciseInstructionsController"/> class.
        /// </summary>
        internal ExerciseLibraryExercisesExerciseInstructionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getExerciseInstructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve instruction models for.</param>
        /// <param name="localeCodes">Optional parameter: The array of locales for the instructions (e.g., 'en-US', 'es-ES').</param>
        /// <returns>Returns the Models.ExerciseInstructionListResponse response from the API call.</returns>
        public Models.ExerciseInstructionListResponse GetExerciseInstructions(
                string exerciseCode,
                List<string> localeCodes = null)
            => CoreHelper.RunTask(GetExerciseInstructionsAsync(exerciseCode, localeCodes));

        /// <summary>
        /// getExerciseInstructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve instruction models for.</param>
        /// <param name="localeCodes">Optional parameter: The array of locales for the instructions (e.g., 'en-US', 'es-ES').</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseInstructionListResponse response from the API call.</returns>
        public async Task<Models.ExerciseInstructionListResponse> GetExerciseInstructionsAsync(
                string exerciseCode,
                List<string> localeCodes = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseInstructionListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises/{exerciseCode}/instructions")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Query(_query => _query.Setup("localeCodes", localeCodes))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise instructions not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getExerciseInstruction EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve instructions for.</param>
        /// <param name="localeCode">Required parameter: The locale for the instructions (e.g., 'en-US', 'es-ES').</param>
        /// <param name="creatorProfileId">Required parameter: The creatorProfileId that belongs to the instructions being requested.</param>
        /// <returns>Returns the Models.ExerciseInstructionResponse response from the API call.</returns>
        public Models.ExerciseInstructionResponse GetExerciseInstruction(
                string exerciseCode,
                string localeCode,
                string creatorProfileId)
            => CoreHelper.RunTask(GetExerciseInstructionAsync(exerciseCode, localeCode, creatorProfileId));

        /// <summary>
        /// getExerciseInstruction EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve instructions for.</param>
        /// <param name="localeCode">Required parameter: The locale for the instructions (e.g., 'en-US', 'es-ES').</param>
        /// <param name="creatorProfileId">Required parameter: The creatorProfileId that belongs to the instructions being requested.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseInstructionResponse response from the API call.</returns>
        public async Task<Models.ExerciseInstructionResponse> GetExerciseInstructionAsync(
                string exerciseCode,
                string localeCode,
                string creatorProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseInstructionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises/{exerciseCode}/instructions/{localeCode}/{creatorProfileId}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("localeCode", localeCode))
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise instructions not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update exercise instructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code of the instructions to update.</param>
        /// <param name="localeCode">Required parameter: The locale code for the instructions to update.</param>
        /// <param name="creatorProfileId">Required parameter: The creatorProfileId of the creator for the instructions to update.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseInstructionResponse response from the API call.</returns>
        public Models.ExerciseInstructionResponse UpdateExerciseInstructions(
                string exerciseCode,
                string localeCode,
                string creatorProfileId,
                Models.ExerciseInstruction body)
            => CoreHelper.RunTask(UpdateExerciseInstructionsAsync(exerciseCode, localeCode, creatorProfileId, body));

        /// <summary>
        /// Update exercise instructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code of the instructions to update.</param>
        /// <param name="localeCode">Required parameter: The locale code for the instructions to update.</param>
        /// <param name="creatorProfileId">Required parameter: The creatorProfileId of the creator for the instructions to update.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseInstructionResponse response from the API call.</returns>
        public async Task<Models.ExerciseInstructionResponse> UpdateExerciseInstructionsAsync(
                string exerciseCode,
                string localeCode,
                string creatorProfileId,
                Models.ExerciseInstruction body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseInstructionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercises/{exerciseCode}/instructions/{localeCode}/{creatorProfileId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("localeCode", localeCode))
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise instructions not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}