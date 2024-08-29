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
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Exceptions;
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace JustGainsAPI.Standard.Controllers
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
        /// <returns>Returns the Models.MuscleGroupListResponse response from the API call.</returns>
        public Models.MuscleGroupListResponse GetMuscleGroups(
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetMuscleGroupsAsync(localeCode));

        /// <summary>
        /// getMuscleGroups EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized muscle group names..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MuscleGroupListResponse response from the API call.</returns>
        public async Task<Models.MuscleGroupListResponse> GetMuscleGroupsAsync(
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MuscleGroupListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/muscle-groups")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new muscle group EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse CreateANewMuscleGroup(
                Models.MuscleGroup body)
            => CoreHelper.RunTask(CreateANewMuscleGroupAsync(body));

        /// <summary>
        /// Create a new muscle group EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> CreateANewMuscleGroupAsync(
                Models.MuscleGroup body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/muscle-groups")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid muscle group data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update a muscle group EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The muscle group code to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse UpdateAMuscleGroup(
                string muscleGroupCode,
                Models.MuscleGroup body)
            => CoreHelper.RunTask(UpdateAMuscleGroupAsync(muscleGroupCode, body));

        /// <summary>
        /// Update a muscle group EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The muscle group code to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> UpdateAMuscleGroupAsync(
                string muscleGroupCode,
                Models.MuscleGroup body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/muscle-groups/{muscleGroupCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("muscleGroupCode", muscleGroupCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid muscle group data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Muscle group not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a muscle group EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The muscle group code to delete..</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse DeleteAMuscleGroup(
                string muscleGroupCode)
            => CoreHelper.RunTask(DeleteAMuscleGroupAsync(muscleGroupCode));

        /// <summary>
        /// Delete a muscle group EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The muscle group code to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> DeleteAMuscleGroupAsync(
                string muscleGroupCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/muscle-groups/{muscleGroupCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("muscleGroupCode", muscleGroupCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Muscle group not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getMuscleGroupTranslations EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The unique code of the muscle group.</param>
        /// <returns>Returns the Models.MuscleGroupTranslationListResponse response from the API call.</returns>
        public Models.MuscleGroupTranslationListResponse GetMuscleGroupTranslations(
                string muscleGroupCode)
            => CoreHelper.RunTask(GetMuscleGroupTranslationsAsync(muscleGroupCode));

        /// <summary>
        /// getMuscleGroupTranslations EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The unique code of the muscle group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MuscleGroupTranslationListResponse response from the API call.</returns>
        public async Task<Models.MuscleGroupTranslationListResponse> GetMuscleGroupTranslationsAsync(
                string muscleGroupCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MuscleGroupTranslationListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/muscle-groups/{muscleGroupCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("muscleGroupCode", muscleGroupCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to retrieve muscle group translations", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Muscle group not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateMuscleGroupTranslations EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The unique code of the muscle group.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse UpdateMuscleGroupTranslations(
                string muscleGroupCode,
                List<Models.MuscleGroupTranslation> body)
            => CoreHelper.RunTask(UpdateMuscleGroupTranslationsAsync(muscleGroupCode, body));

        /// <summary>
        /// updateMuscleGroupTranslations EndPoint.
        /// </summary>
        /// <param name="muscleGroupCode">Required parameter: The unique code of the muscle group.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> UpdateMuscleGroupTranslationsAsync(
                string muscleGroupCode,
                List<Models.MuscleGroupTranslation> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/muscle-groups/{muscleGroupCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("muscleGroupCode", muscleGroupCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to update muscle group translations", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Muscle group not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Validation error", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}