// <copyright file="ExerciseLibraryEquipmentController.cs" company="APIMatic">
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
    /// ExerciseLibraryEquipmentController.
    /// </summary>
    public class ExerciseLibraryEquipmentController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseLibraryEquipmentController"/> class.
        /// </summary>
        internal ExerciseLibraryEquipmentController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getEquipments EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment names..</param>
        /// <returns>Returns the Models.EquipmentListResponse response from the API call.</returns>
        public Models.EquipmentListResponse GetEquipments(
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetEquipmentsAsync(localeCode));

        /// <summary>
        /// getEquipments EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment names..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentListResponse response from the API call.</returns>
        public async Task<Models.EquipmentListResponse> GetEquipmentsAsync(
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/equipment")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// createEquipment EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse CreateEquipment(
                Models.Equipment body)
            => CoreHelper.RunTask(CreateEquipmentAsync(body));

        /// <summary>
        /// createEquipment EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> CreateEquipmentAsync(
                Models.Equipment body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/equipment")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid request data.", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment..</param>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment names..</param>
        /// <returns>Returns the Models.EquipmentResponse response from the API call.</returns>
        public Models.EquipmentResponse GetEquipment(
                string equipmentCode,
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetEquipmentAsync(equipmentCode, localeCode));

        /// <summary>
        /// getEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment..</param>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment names..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentResponse response from the API call.</returns>
        public async Task<Models.EquipmentResponse> GetEquipmentAsync(
                string equipmentCode,
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/equipment/{equipmentCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("equipmentCode", equipmentCode))
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Equipment not found with the given code.", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// UpdateEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse UpdateEquipment(
                string equipmentCode,
                Models.Equipment body)
            => CoreHelper.RunTask(UpdateEquipmentAsync(equipmentCode, body));

        /// <summary>
        /// UpdateEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> UpdateEquipmentAsync(
                string equipmentCode,
                Models.Equipment body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/equipment/{equipmentCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("equipmentCode", equipmentCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request. Invalid input data.", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Equipment not found with the given code.", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict. The equipment code already exists for a different equipment.", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// deleteEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment to delete..</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse DeleteEquipment(
                string equipmentCode)
            => CoreHelper.RunTask(DeleteEquipmentAsync(equipmentCode));

        /// <summary>
        /// deleteEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> DeleteEquipmentAsync(
                string equipmentCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/equipment/{equipmentCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("equipmentCode", equipmentCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to delete the equipment or equipment does not exist.", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getEquipmentTranslations EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code of the equipment.</param>
        /// <returns>Returns the Models.EquipmentTranslationListResponse response from the API call.</returns>
        public Models.EquipmentTranslationListResponse GetEquipmentTranslations(
                string equipmentCode)
            => CoreHelper.RunTask(GetEquipmentTranslationsAsync(equipmentCode));

        /// <summary>
        /// getEquipmentTranslations EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code of the equipment.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentTranslationListResponse response from the API call.</returns>
        public async Task<Models.EquipmentTranslationListResponse> GetEquipmentTranslationsAsync(
                string equipmentCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentTranslationListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/equipment/{equipmentCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("equipmentCode", equipmentCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Equipment not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateEquipmentTranslations EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code of the equipment.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse UpdateEquipmentTranslations(
                string equipmentCode,
                Models.EquipmentTranslation body)
            => CoreHelper.RunTask(UpdateEquipmentTranslationsAsync(equipmentCode, body));

        /// <summary>
        /// updateEquipmentTranslations EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code of the equipment.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> UpdateEquipmentTranslationsAsync(
                string equipmentCode,
                Models.EquipmentTranslation body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/equipment/{equipmentCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("equipmentCode", equipmentCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Equipment not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}