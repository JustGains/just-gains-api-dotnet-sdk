// <copyright file="MusclesMuscleGroupsController.cs" company="APIMatic">
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
    /// MusclesMuscleGroupsController.
    /// </summary>
    public class MusclesMuscleGroupsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MusclesMuscleGroupsController"/> class.
        /// </summary>
        internal MusclesMuscleGroupsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getMuscleGroups EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized muscle group names..</param>
        /// <returns>Returns the Models.MuscleGroupsResponse response from the API call.</returns>
        public Models.MuscleGroupsResponse GetMuscleGroups(
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetMuscleGroupsAsync(localeCode));

        /// <summary>
        /// getMuscleGroups EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized muscle group names..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MuscleGroupsResponse response from the API call.</returns>
        public async Task<Models.MuscleGroupsResponse> GetMuscleGroupsAsync(
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MuscleGroupsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/muscle-groups")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new muscle group EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.MuscleGroupsResponse1 response from the API call.</returns>
        public Models.MuscleGroupsResponse1 CreateANewMuscleGroup(
                Models.MuscleGroup body)
            => CoreHelper.RunTask(CreateANewMuscleGroupAsync(body));

        /// <summary>
        /// Create a new muscle group EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MuscleGroupsResponse1 response from the API call.</returns>
        public async Task<Models.MuscleGroupsResponse1> CreateANewMuscleGroupAsync(
                Models.MuscleGroup body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MuscleGroupsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/muscle-groups")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid muscle group data", (_reason, _context) => new MuscleGroups400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new MuscleGroups401ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getMuscleGroup EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The muscle group code to retrieve..</param>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized muscle group names..</param>
        /// <returns>Returns the Models.MuscleGroupsResponse1 response from the API call.</returns>
        public Models.MuscleGroupsResponse1 GetMuscleGroup(
                string muscleGroupCode,
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetMuscleGroupAsync(muscleGroupCode, localeCode));

        /// <summary>
        /// getMuscleGroup EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The muscle group code to retrieve..</param>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized muscle group names..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MuscleGroupsResponse1 response from the API call.</returns>
        public async Task<Models.MuscleGroupsResponse1> GetMuscleGroupAsync(
                string muscleGroupCode,
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MuscleGroupsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/muscle-groups/{muscleGroupCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("muscleGroupCode", muscleGroupCode))
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update a muscle group EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The muscle group code to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.MuscleGroupsResponse1 response from the API call.</returns>
        public Models.MuscleGroupsResponse1 UpdateAMuscleGroup(
                string muscleGroupCode,
                Models.MuscleGroup body)
            => CoreHelper.RunTask(UpdateAMuscleGroupAsync(muscleGroupCode, body));

        /// <summary>
        /// Update a muscle group EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The muscle group code to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MuscleGroupsResponse1 response from the API call.</returns>
        public async Task<Models.MuscleGroupsResponse1> UpdateAMuscleGroupAsync(
                string muscleGroupCode,
                Models.MuscleGroup body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MuscleGroupsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/muscle-groups/{muscleGroupCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("muscleGroupCode", muscleGroupCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid muscle group data", (_reason, _context) => new MuscleGroups400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new MuscleGroups401ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Muscle group not found", (_reason, _context) => new MuscleGroups404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a muscle group EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The muscle group code to delete..</param>
        /// <returns>Returns the Models.MuscleGroupsResponse4 response from the API call.</returns>
        public Models.MuscleGroupsResponse4 DeleteAMuscleGroup(
                string muscleGroupCode)
            => CoreHelper.RunTask(DeleteAMuscleGroupAsync(muscleGroupCode));

        /// <summary>
        /// Delete a muscle group EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The muscle group code to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MuscleGroupsResponse4 response from the API call.</returns>
        public async Task<Models.MuscleGroupsResponse4> DeleteAMuscleGroupAsync(
                string muscleGroupCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MuscleGroupsResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/muscle-groups/{muscleGroupCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("muscleGroupCode", muscleGroupCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new MuscleGroups401ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Muscle group not found", (_reason, _context) => new MuscleGroups404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getMuscleGroupTranslations EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The unique code of the muscle group.</param>
        /// <returns>Returns the Models.MuscleGroupsTranslationsResponse response from the API call.</returns>
        public Models.MuscleGroupsTranslationsResponse GetMuscleGroupTranslations(
                string muscleGroupCode)
            => CoreHelper.RunTask(GetMuscleGroupTranslationsAsync(muscleGroupCode));

        /// <summary>
        /// getMuscleGroupTranslations EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The unique code of the muscle group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MuscleGroupsTranslationsResponse response from the API call.</returns>
        public async Task<Models.MuscleGroupsTranslationsResponse> GetMuscleGroupTranslationsAsync(
                string muscleGroupCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MuscleGroupsTranslationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/muscle-groups/{muscleGroupCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("muscleGroupCode", muscleGroupCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to retrieve muscle group translations", (_reason, _context) => new MuscleGroupsTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Muscle group not found", (_reason, _context) => new MuscleGroupsTranslations404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateMuscleGroupTranslations EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The unique code of the muscle group.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.MuscleGroupsTranslationsResponse1 response from the API call.</returns>
        public Models.MuscleGroupsTranslationsResponse1 UpdateMuscleGroupTranslations(
                string muscleGroupCode,
                List<Models.MuscleGroupTranslation> body)
            => CoreHelper.RunTask(UpdateMuscleGroupTranslationsAsync(muscleGroupCode, body));

        /// <summary>
        /// updateMuscleGroupTranslations EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The unique code of the muscle group.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MuscleGroupsTranslationsResponse1 response from the API call.</returns>
        public async Task<Models.MuscleGroupsTranslationsResponse1> UpdateMuscleGroupTranslationsAsync(
                string muscleGroupCode,
                List<Models.MuscleGroupTranslation> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MuscleGroupsTranslationsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/muscle-groups/{muscleGroupCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("muscleGroupCode", muscleGroupCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to update muscle group translations", (_reason, _context) => new MuscleGroupsTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Muscle group not found", (_reason, _context) => new MuscleGroupsTranslations404ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Validation error", (_reason, _context) => new MuscleGroupsTranslations422ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}