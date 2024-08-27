// <copyright file="EquipmentController.cs" company="APIMatic">
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
    /// EquipmentController.
    /// </summary>
    public class EquipmentController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentController"/> class.
        /// </summary>
        internal EquipmentController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getEquipments EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment names..</param>
        /// <returns>Returns the Models.EquipmentResponse response from the API call.</returns>
        public Models.EquipmentResponse GetEquipments(
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetEquipmentsAsync(localeCode));

        /// <summary>
        /// getEquipments EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment names..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentResponse response from the API call.</returns>
        public async Task<Models.EquipmentResponse> GetEquipmentsAsync(
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/equipment")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// createEquipment EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.EquipmentResponse1 response from the API call.</returns>
        public Models.EquipmentResponse1 CreateEquipment(
                Models.Equipment body)
            => CoreHelper.RunTask(CreateEquipmentAsync(body));

        /// <summary>
        /// createEquipment EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentResponse1 response from the API call.</returns>
        public async Task<Models.EquipmentResponse1> CreateEquipmentAsync(
                Models.Equipment body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/equipment")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid request data.", (_reason, _context) => new Equipment400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment..</param>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment names..</param>
        /// <returns>Returns the Models.EquipmentResponse1 response from the API call.</returns>
        public Models.EquipmentResponse1 GetEquipment(
                string equipmentCode,
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetEquipmentAsync(equipmentCode, localeCode));

        /// <summary>
        /// getEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment..</param>
        /// <param name="localeCode">Optional parameter: The locale to use for the localized equipment names..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentResponse1 response from the API call.</returns>
        public async Task<Models.EquipmentResponse1> GetEquipmentAsync(
                string equipmentCode,
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/equipment/{equipmentCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("equipmentCode", equipmentCode))
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Equipment not found with the given code.", (_reason, _context) => new Equipment404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// UpdateEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.EquipmentResponse1 response from the API call.</returns>
        public Models.EquipmentResponse1 UpdateEquipment(
                string equipmentCode,
                Models.Equipment body)
            => CoreHelper.RunTask(UpdateEquipmentAsync(equipmentCode, body));

        /// <summary>
        /// UpdateEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentResponse1 response from the API call.</returns>
        public async Task<Models.EquipmentResponse1> UpdateEquipmentAsync(
                string equipmentCode,
                Models.Equipment body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/equipment/{equipmentCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("equipmentCode", equipmentCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request. Invalid input data.", (_reason, _context) => new Equipment400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Equipment not found with the given code.", (_reason, _context) => new Equipment404ErrorException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Conflict. The equipment code already exists for a different equipment.", (_reason, _context) => new Equipment409ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// deleteEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment to delete..</param>
        /// <returns>Returns the Models.EquipmentResponse4 response from the API call.</returns>
        public Models.EquipmentResponse4 DeleteEquipment(
                string equipmentCode)
            => CoreHelper.RunTask(DeleteEquipmentAsync(equipmentCode));

        /// <summary>
        /// deleteEquipment EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code identifying the equipment to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentResponse4 response from the API call.</returns>
        public async Task<Models.EquipmentResponse4> DeleteEquipmentAsync(
                string equipmentCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/equipment/{equipmentCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("equipmentCode", equipmentCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to delete the equipment or equipment does not exist.", (_reason, _context) => new Equipment400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getEquipmentTranslations EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code of the equipment.</param>
        /// <returns>Returns the Models.EquipmentTranslationsResponse response from the API call.</returns>
        public Models.EquipmentTranslationsResponse GetEquipmentTranslations(
                string equipmentCode)
            => CoreHelper.RunTask(GetEquipmentTranslationsAsync(equipmentCode));

        /// <summary>
        /// getEquipmentTranslations EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code of the equipment.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentTranslationsResponse response from the API call.</returns>
        public async Task<Models.EquipmentTranslationsResponse> GetEquipmentTranslationsAsync(
                string equipmentCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentTranslationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/equipment/{equipmentCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("equipmentCode", equipmentCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new EquipmentTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Equipment not found", (_reason, _context) => new EquipmentTranslations404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateEquipmentTranslations EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code of the equipment.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.EquipmentTranslationsResponse1 response from the API call.</returns>
        public Models.EquipmentTranslationsResponse1 UpdateEquipmentTranslations(
                string equipmentCode,
                Models.EquipmentTranslation body)
            => CoreHelper.RunTask(UpdateEquipmentTranslationsAsync(equipmentCode, body));

        /// <summary>
        /// updateEquipmentTranslations EndPoint.
        /// </summary>
        /// <param name="equipmentCode">Required parameter: The unique code of the equipment.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EquipmentTranslationsResponse1 response from the API call.</returns>
        public async Task<Models.EquipmentTranslationsResponse1> UpdateEquipmentTranslationsAsync(
                string equipmentCode,
                Models.EquipmentTranslation body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EquipmentTranslationsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/equipment/{equipmentCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("equipmentCode", equipmentCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new EquipmentTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Equipment not found", (_reason, _context) => new EquipmentTranslations404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}