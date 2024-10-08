// <copyright file="CommonPublishedStatusController.cs" company="APIMatic">
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
    /// CommonPublishedStatusController.
    /// </summary>
    public class CommonPublishedStatusController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonPublishedStatusController"/> class.
        /// </summary>
        internal CommonPublishedStatusController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getAllPublishedStatus EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: Locale code for translations (e.g., en-US).</param>
        /// <param name="localeCodes">Optional parameter: The array of locales for the instructions (e.g., 'en-US', 'es-ES').</param>
        /// <returns>Returns the Models.PublishedStatusListResponse response from the API call.</returns>
        public Models.PublishedStatusListResponse GetAllPublishedStatus(
                string localeCode = null,
                List<string> localeCodes = null)
            => CoreHelper.RunTask(GetAllPublishedStatusAsync(localeCode, localeCodes));

        /// <summary>
        /// getAllPublishedStatus EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: Locale code for translations (e.g., en-US).</param>
        /// <param name="localeCodes">Optional parameter: The array of locales for the instructions (e.g., 'en-US', 'es-ES').</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PublishedStatusListResponse response from the API call.</returns>
        public async Task<Models.PublishedStatusListResponse> GetAllPublishedStatusAsync(
                string localeCode = null,
                List<string> localeCodes = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PublishedStatusListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/published-status")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode))
                      .Query(_query => _query.Setup("localeCodes", localeCodes))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new published status EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse CreateANewPublishedStatus(
                Models.PublishedStatus body)
            => CoreHelper.RunTask(CreateANewPublishedStatusAsync(body));

        /// <summary>
        /// Create a new published status EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> CreateANewPublishedStatusAsync(
                Models.PublishedStatus body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/published-status")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update a published status EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse UpdateAPublishedStatus(
                string publishedStatusCode,
                Models.PublishedStatus body)
            => CoreHelper.RunTask(UpdateAPublishedStatusAsync(publishedStatusCode, body));

        /// <summary>
        /// Update a published status EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> UpdateAPublishedStatusAsync(
                string publishedStatusCode,
                Models.PublishedStatus body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/published-status/{publishedStatusCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("publishedStatusCode", publishedStatusCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Published status not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a published status EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse DeleteAPublishedStatus(
                string publishedStatusCode)
            => CoreHelper.RunTask(DeleteAPublishedStatusAsync(publishedStatusCode));

        /// <summary>
        /// Delete a published status EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> DeleteAPublishedStatusAsync(
                string publishedStatusCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/published-status/{publishedStatusCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("publishedStatusCode", publishedStatusCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Published status not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getAllPublishedStatusTranslations EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: The unique code of the published status.</param>
        /// <returns>Returns the Models.PublishedStatusTranslationListResponse response from the API call.</returns>
        public Models.PublishedStatusTranslationListResponse GetAllPublishedStatusTranslations(
                string publishedStatusCode)
            => CoreHelper.RunTask(GetAllPublishedStatusTranslationsAsync(publishedStatusCode));

        /// <summary>
        /// getAllPublishedStatusTranslations EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: The unique code of the published status.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PublishedStatusTranslationListResponse response from the API call.</returns>
        public async Task<Models.PublishedStatusTranslationListResponse> GetAllPublishedStatusTranslationsAsync(
                string publishedStatusCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PublishedStatusTranslationListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/published-status/{publishedStatusCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("publishedStatusCode", publishedStatusCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Published status not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updatePublishedStatusTranslations EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: The unique code of the published status.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse UpdatePublishedStatusTranslations(
                string publishedStatusCode,
                List<Models.PublishedStatusTranslation> body)
            => CoreHelper.RunTask(UpdatePublishedStatusTranslationsAsync(publishedStatusCode, body));

        /// <summary>
        /// updatePublishedStatusTranslations EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: The unique code of the published status.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> UpdatePublishedStatusTranslationsAsync(
                string publishedStatusCode,
                List<Models.PublishedStatusTranslation> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/published-status/{publishedStatusCode}/translations")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("publishedStatusCode", publishedStatusCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Published status not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}