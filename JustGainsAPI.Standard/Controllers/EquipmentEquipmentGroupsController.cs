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
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Exceptions;
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace JustGainsAPI.Standard.Controllers
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
        /// <returns>Returns the Models.EquipmentGroupListResponse response from the API call.</returns>
        public Models.EquipmentGroupListResponse GetEquipmentGroups(
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetEquipmentGroupsAsync(localeCode));

        /// <summary>
        /// getEquipmentGroups EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment group names..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentGroupListResponse response from the API call.</returns>
        public async Task<Models.EquipmentGroupListResponse> GetEquipmentGroupsAsync(
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentGroupListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/equipment-groups")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// addEquipmentGroup EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse AddEquipmentGroup(
                Models.EquipmentGroup body)
            => CoreHelper.RunTask(AddEquipmentGroupAsync(body));

        /// <summary>
        /// addEquipmentGroup EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> AddEquipmentGroupAsync(
                Models.EquipmentGroup body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/equipment-groups")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update an existing equipment group EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The equipment group code to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse UpdateAnExistingEquipmentGroup(
                string equipmentGroupCode,
                Models.EquipmentGroup body)
            => CoreHelper.RunTask(UpdateAnExistingEquipmentGroupAsync(equipmentGroupCode, body));

        /// <summary>
        /// Update an existing equipment group EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The equipment group code to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> UpdateAnExistingEquipmentGroupAsync(
                string equipmentGroupCode,
                Models.EquipmentGroup body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/equipment-groups/{equipmentGroupCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("equipmentGroupCode", equipmentGroupCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an equipment group EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The equipment group code to delete..</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse DeleteAnEquipmentGroup(
                string equipmentGroupCode)
            => CoreHelper.RunTask(DeleteAnEquipmentGroupAsync(equipmentGroupCode));

        /// <summary>
        /// Delete an equipment group EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The equipment group code to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> DeleteAnEquipmentGroupAsync(
                string equipmentGroupCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
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
        /// <returns>Returns the Models.EquipmentGroupTranslationListResponse response from the API call.</returns>
        public Models.EquipmentGroupTranslationListResponse GetEquipmentGroupTranslations(
                string equipmentGroupCode)
            => CoreHelper.RunTask(GetEquipmentGroupTranslationsAsync(equipmentGroupCode));

        /// <summary>
        /// getEquipmentGroupTranslations EndPoint.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The unique code of the equipment group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentGroupTranslationListResponse response from the API call.</returns>
        public async Task<Models.EquipmentGroupTranslationListResponse> GetEquipmentGroupTranslationsAsync(
                string equipmentGroupCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentGroupTranslationListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/equipment-groups/{equipmentGroupCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("equipmentGroupCode", equipmentGroupCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Equipment group not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the translations for a specific equipment group identified by its code.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The unique code of the equipment group.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse UpdateEquipmentGroupTranslations(
                string equipmentGroupCode,
                List<Models.EquipmentGroupTranslation> body)
            => CoreHelper.RunTask(UpdateEquipmentGroupTranslationsAsync(equipmentGroupCode, body));

        /// <summary>
        /// Updates the translations for a specific equipment group identified by its code.
        /// </summary>
        /// <param name="equipmentGroupCode">Required parameter: The unique code of the equipment group.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> UpdateEquipmentGroupTranslationsAsync(
                string equipmentGroupCode,
                List<Models.EquipmentGroupTranslation> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/equipment-groups/{equipmentGroupCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("equipmentGroupCode", equipmentGroupCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Equipment group not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Validation error", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}