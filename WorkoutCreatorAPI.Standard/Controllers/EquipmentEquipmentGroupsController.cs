// <copyright file="EquipmentEquipmentGroupsController.cs" company="APIMatic">
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
    /// EquipmentEquipmentGroupsController.
    /// </summary>
    public class EquipmentEquipmentGroupsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentEquipmentGroupsController"/> class.
        /// </summary>
        internal EquipmentEquipmentGroupsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getEquipmentGroups EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment group names..</param>
        /// <returns>Returns the Models.EquipmentGroupsResponse response from the API call.</returns>
        public Models.EquipmentGroupsResponse GetEquipmentGroups(
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetEquipmentGroupsAsync(localeCode));

        /// <summary>
        /// getEquipmentGroups EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment group names..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentGroupsResponse response from the API call.</returns>
        public async Task<Models.EquipmentGroupsResponse> GetEquipmentGroupsAsync(
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentGroupsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/equipment-groups")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new EquipmentGroups400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// addEquipmentGroup EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.EquipmentGroupsResponse1 response from the API call.</returns>
        public Models.EquipmentGroupsResponse1 AddEquipmentGroup(
                Models.EquipmentGroup body)
            => CoreHelper.RunTask(AddEquipmentGroupAsync(body));

        /// <summary>
        /// addEquipmentGroup EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentGroupsResponse1 response from the API call.</returns>
        public async Task<Models.EquipmentGroupsResponse1> AddEquipmentGroupAsync(
                Models.EquipmentGroup body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentGroupsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/equipment-groups")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new EquipmentGroups400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getEquipmentGroup EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The equipment group code to retrieve..</param>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment group names..</param>
        /// <returns>Returns the Models.EquipmentGroupsResponse1 response from the API call.</returns>
        public Models.EquipmentGroupsResponse1 GetEquipmentGroup(
                string equipmentGroupCode,
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetEquipmentGroupAsync(equipmentGroupCode, localeCode));

        /// <summary>
        /// getEquipmentGroup EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The equipment group code to retrieve..</param>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment group names..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentGroupsResponse1 response from the API call.</returns>
        public async Task<Models.EquipmentGroupsResponse1> GetEquipmentGroupAsync(
                string equipmentGroupCode,
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentGroupsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/equipment-groups/{equipmentGroupCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("equipmentGroupCode", equipmentGroupCode))
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Equipment group not found", (_reason, _context) => new EquipmentGroups404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update an existing equipment group EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The equipment group code to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.EquipmentGroupsResponse1 response from the API call.</returns>
        public Models.EquipmentGroupsResponse1 UpdateAnExistingEquipmentGroup(
                string equipmentGroupCode,
                Models.EquipmentGroup body)
            => CoreHelper.RunTask(UpdateAnExistingEquipmentGroupAsync(equipmentGroupCode, body));

        /// <summary>
        /// Update an existing equipment group EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The equipment group code to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentGroupsResponse1 response from the API call.</returns>
        public async Task<Models.EquipmentGroupsResponse1> UpdateAnExistingEquipmentGroupAsync(
                string equipmentGroupCode,
                Models.EquipmentGroup body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentGroupsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/equipment-groups/{equipmentGroupCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("equipmentGroupCode", equipmentGroupCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new EquipmentGroups400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an equipment group EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The equipment group code to delete..</param>
        /// <returns>Returns the Models.EquipmentGroupsResponse4 response from the API call.</returns>
        public Models.EquipmentGroupsResponse4 DeleteAnEquipmentGroup(
                string equipmentGroupCode)
            => CoreHelper.RunTask(DeleteAnEquipmentGroupAsync(equipmentGroupCode));

        /// <summary>
        /// Delete an equipment group EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The equipment group code to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentGroupsResponse4 response from the API call.</returns>
        public async Task<Models.EquipmentGroupsResponse4> DeleteAnEquipmentGroupAsync(
                string equipmentGroupCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentGroupsResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/equipment-groups/{equipmentGroupCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("equipmentGroupCode", equipmentGroupCode))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getEquipmentGroupTranslations EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The unique code of the equipment group.</param>
        /// <returns>Returns the Models.EquipmentGroupsTranslationsResponse response from the API call.</returns>
        public Models.EquipmentGroupsTranslationsResponse GetEquipmentGroupTranslations(
                string equipmentGroupCode)
            => CoreHelper.RunTask(GetEquipmentGroupTranslationsAsync(equipmentGroupCode));

        /// <summary>
        /// getEquipmentGroupTranslations EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The unique code of the equipment group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentGroupsTranslationsResponse response from the API call.</returns>
        public async Task<Models.EquipmentGroupsTranslationsResponse> GetEquipmentGroupTranslationsAsync(
                string equipmentGroupCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentGroupsTranslationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/equipment-groups/{equipmentGroupCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("equipmentGroupCode", equipmentGroupCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new EquipmentGroupsTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Equipment group not found", (_reason, _context) => new EquipmentGroupsTranslations404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the translations for a specific equipment group identified by its code.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The unique code of the equipment group.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.EquipmentGroupsTranslationsResponse1 response from the API call.</returns>
        public Models.EquipmentGroupsTranslationsResponse1 UpdateEquipmentGroupTranslations(
                string equipmentGroupCode,
                List<Models.EquipmentGroupTranslation> body)
            => CoreHelper.RunTask(UpdateEquipmentGroupTranslationsAsync(equipmentGroupCode, body));

        /// <summary>
        /// Updates the translations for a specific equipment group identified by its code.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The unique code of the equipment group.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentGroupsTranslationsResponse1 response from the API call.</returns>
        public async Task<Models.EquipmentGroupsTranslationsResponse1> UpdateEquipmentGroupTranslationsAsync(
                string equipmentGroupCode,
                List<Models.EquipmentGroupTranslation> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentGroupsTranslationsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/equipment-groups/{equipmentGroupCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("equipmentGroupCode", equipmentGroupCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new EquipmentGroupsTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Equipment group not found", (_reason, _context) => new EquipmentGroupsTranslations404ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Validation error", (_reason, _context) => new EquipmentGroupsTranslations422ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}