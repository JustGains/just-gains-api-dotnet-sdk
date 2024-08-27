// <copyright file="ExercisesExerciseInstructionsController.cs" company="APIMatic">
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
    /// ExercisesExerciseInstructionsController.
    /// </summary>
    public class ExercisesExerciseInstructionsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExercisesExerciseInstructionsController"/> class.
        /// </summary>
        internal ExercisesExerciseInstructionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getExerciseInstructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve instruction models for.</param>
        /// <param name="localeCodes">Optional parameter: The array of locales for the instructions (e.g., 'en-US', 'es-ES').</param>
        /// <returns>Returns the Models.ExercisesInstructionsResponse response from the API call.</returns>
        public Models.ExercisesInstructionsResponse GetExerciseInstructions(
                string exerciseCode,
                List<string> localeCodes = null)
            => CoreHelper.RunTask(GetExerciseInstructionsAsync(exerciseCode, localeCodes));

        /// <summary>
        /// getExerciseInstructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve instruction models for.</param>
        /// <param name="localeCodes">Optional parameter: The array of locales for the instructions (e.g., 'en-US', 'es-ES').</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesInstructionsResponse response from the API call.</returns>
        public async Task<Models.ExercisesInstructionsResponse> GetExerciseInstructionsAsync(
                string exerciseCode,
                List<string> localeCodes = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesInstructionsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises/{exerciseCode}/instructions")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Query(_query => _query.Setup("localeCodes", localeCodes))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExercisesInstructions400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise instructions not found", (_reason, _context) => new ExercisesInstructions404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create new exercise instructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to create instructions for.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExercisesInstructionsResponse1 response from the API call.</returns>
        public Models.ExercisesInstructionsResponse1 CreateNewExerciseInstructions(
                string exerciseCode,
                Models.ExerciseInstruction body)
            => CoreHelper.RunTask(CreateNewExerciseInstructionsAsync(exerciseCode, body));

        /// <summary>
        /// Create new exercise instructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to create instructions for.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesInstructionsResponse1 response from the API call.</returns>
        public async Task<Models.ExercisesInstructionsResponse1> CreateNewExerciseInstructionsAsync(
                string exerciseCode,
                Models.ExerciseInstruction body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesInstructionsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/exercises/{exerciseCode}/instructions")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExercisesInstructions400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ExercisesInstructions401ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getExerciseInstruction EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve instructions for.</param>
        /// <param name="localeCode">Required parameter: The locale for the instructions (e.g., 'en-US', 'es-ES').</param>
        /// <param name="userId">Required parameter: The UserID that belongs to the instructions being requested.</param>
        /// <returns>Returns the Models.ExercisesInstructionsUserIdResponse response from the API call.</returns>
        public Models.ExercisesInstructionsUserIdResponse GetExerciseInstruction(
                string exerciseCode,
                string localeCode,
                string userId)
            => CoreHelper.RunTask(GetExerciseInstructionAsync(exerciseCode, localeCode, userId));

        /// <summary>
        /// getExerciseInstruction EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code to retrieve instructions for.</param>
        /// <param name="localeCode">Required parameter: The locale for the instructions (e.g., 'en-US', 'es-ES').</param>
        /// <param name="userId">Required parameter: The UserID that belongs to the instructions being requested.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesInstructionsUserIdResponse response from the API call.</returns>
        public async Task<Models.ExercisesInstructionsUserIdResponse> GetExerciseInstructionAsync(
                string exerciseCode,
                string localeCode,
                string userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesInstructionsUserIdResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercises/{exerciseCode}/instructions/{localeCode}/{userId}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("localeCode", localeCode))
                      .Template(_template => _template.Setup("userId", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExercisesInstructionsUserId400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise instructions not found", (_reason, _context) => new ExercisesInstructionsUserId404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update exercise instructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code of the instructions to update.</param>
        /// <param name="localeCode">Required parameter: The locale code for the instructions to update.</param>
        /// <param name="userId">Required parameter: The userId of the creator for the instructions to update.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExercisesInstructionsUserIdResponse response from the API call.</returns>
        public Models.ExercisesInstructionsUserIdResponse UpdateExerciseInstructions(
                string exerciseCode,
                string localeCode,
                string userId,
                Models.ExerciseInstruction body)
            => CoreHelper.RunTask(UpdateExerciseInstructionsAsync(exerciseCode, localeCode, userId, body));

        /// <summary>
        /// Update exercise instructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code of the instructions to update.</param>
        /// <param name="localeCode">Required parameter: The locale code for the instructions to update.</param>
        /// <param name="userId">Required parameter: The userId of the creator for the instructions to update.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesInstructionsUserIdResponse response from the API call.</returns>
        public async Task<Models.ExercisesInstructionsUserIdResponse> UpdateExerciseInstructionsAsync(
                string exerciseCode,
                string localeCode,
                string userId,
                Models.ExerciseInstruction body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesInstructionsUserIdResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercises/{exerciseCode}/instructions/{localeCode}/{userId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("localeCode", localeCode))
                      .Template(_template => _template.Setup("userId", userId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExercisesInstructionsUserId400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ExercisesInstructionsUserId401ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise instructions not found", (_reason, _context) => new ExercisesInstructionsUserId404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete exercise instructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code of the instructions to delete.</param>
        /// <param name="localeCode">Required parameter: The locale code for the instructions to delete.</param>
        /// <param name="userId">Required parameter: The user ID of the instructions to delete.</param>
        /// <returns>Returns the Models.ExercisesInstructionsUserIdResponse2 response from the API call.</returns>
        public Models.ExercisesInstructionsUserIdResponse2 DeleteExerciseInstructions(
                string exerciseCode,
                string localeCode,
                string userId)
            => CoreHelper.RunTask(DeleteExerciseInstructionsAsync(exerciseCode, localeCode, userId));

        /// <summary>
        /// Delete exercise instructions EndPoint.
        /// </summary>
        /// <param name="exerciseCode">Required parameter: The exercise code of the instructions to delete.</param>
        /// <param name="localeCode">Required parameter: The locale code for the instructions to delete.</param>
        /// <param name="userId">Required parameter: The user ID of the instructions to delete.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExercisesInstructionsUserIdResponse2 response from the API call.</returns>
        public async Task<Models.ExercisesInstructionsUserIdResponse2> DeleteExerciseInstructionsAsync(
                string exerciseCode,
                string localeCode,
                string userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExercisesInstructionsUserIdResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/exercises/{exerciseCode}/instructions/{localeCode}/{userId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("exerciseCode", exerciseCode))
                      .Template(_template => _template.Setup("localeCode", localeCode))
                      .Template(_template => _template.Setup("userId", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ExercisesInstructionsUserId401ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise instructions not found", (_reason, _context) => new ExercisesInstructionsUserId404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}