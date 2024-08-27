// <copyright file="PublishedStatusController.cs" company="APIMatic">
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
    /// PublishedStatusController.
    /// </summary>
    public class PublishedStatusController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedStatusController"/> class.
        /// </summary>
        internal PublishedStatusController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getAllPublishedStatus EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: Locale code for translations (e.g., en-US).</param>
        /// <returns>Returns the Models.PublishedStatusResponse response from the API call.</returns>
        public Models.PublishedStatusResponse GetAllPublishedStatus(
                string localeCode = null)
            => CoreHelper.RunTask(GetAllPublishedStatusAsync(localeCode));

        /// <summary>
        /// getAllPublishedStatus EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: Locale code for translations (e.g., en-US).</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PublishedStatusResponse response from the API call.</returns>
        public async Task<Models.PublishedStatusResponse> GetAllPublishedStatusAsync(
                string localeCode = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PublishedStatusResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/published-status")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new PublishedStatus400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new published status EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.PublishedStatusResponse1 response from the API call.</returns>
        public Models.PublishedStatusResponse1 CreateANewPublishedStatus(
                Models.PublishedStatus body)
            => CoreHelper.RunTask(CreateANewPublishedStatusAsync(body));

        /// <summary>
        /// Create a new published status EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PublishedStatusResponse1 response from the API call.</returns>
        public async Task<Models.PublishedStatusResponse1> CreateANewPublishedStatusAsync(
                Models.PublishedStatus body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PublishedStatusResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/published-status")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new PublishedStatus400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getPublishedStatus EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <param name="localeCode">Optional parameter: Locale code for translations (e.g., en-US).</param>
        /// <returns>Returns the Models.PublishedStatusResponse1 response from the API call.</returns>
        public Models.PublishedStatusResponse1 GetPublishedStatus(
                string publishedStatusCode,
                string localeCode = null)
            => CoreHelper.RunTask(GetPublishedStatusAsync(publishedStatusCode, localeCode));

        /// <summary>
        /// getPublishedStatus EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <param name="localeCode">Optional parameter: Locale code for translations (e.g., en-US).</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PublishedStatusResponse1 response from the API call.</returns>
        public async Task<Models.PublishedStatusResponse1> GetPublishedStatusAsync(
                string publishedStatusCode,
                string localeCode = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PublishedStatusResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/published-status/{publishedStatusCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("publishedStatusCode", publishedStatusCode))
                      .Query(_query => _query.Setup("localeCode", localeCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Published status not found", (_reason, _context) => new PublishedStatus404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update a published status EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.PublishedStatusResponse1 response from the API call.</returns>
        public Models.PublishedStatusResponse1 UpdateAPublishedStatus(
                string publishedStatusCode,
                Models.PublishedStatus body)
            => CoreHelper.RunTask(UpdateAPublishedStatusAsync(publishedStatusCode, body));

        /// <summary>
        /// Update a published status EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PublishedStatusResponse1 response from the API call.</returns>
        public async Task<Models.PublishedStatusResponse1> UpdateAPublishedStatusAsync(
                string publishedStatusCode,
                Models.PublishedStatus body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PublishedStatusResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/published-status/{publishedStatusCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("publishedStatusCode", publishedStatusCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new PublishedStatus400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Published status not found", (_reason, _context) => new PublishedStatus404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a published status EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <returns>Returns the Models.PublishedStatusResponse4 response from the API call.</returns>
        public Models.PublishedStatusResponse4 DeleteAPublishedStatus(
                string publishedStatusCode)
            => CoreHelper.RunTask(DeleteAPublishedStatusAsync(publishedStatusCode));

        /// <summary>
        /// Delete a published status EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PublishedStatusResponse4 response from the API call.</returns>
        public async Task<Models.PublishedStatusResponse4> DeleteAPublishedStatusAsync(
                string publishedStatusCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PublishedStatusResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/published-status/{publishedStatusCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("publishedStatusCode", publishedStatusCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Published status not found", (_reason, _context) => new PublishedStatus404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getAllPublishedStatusTranslations EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: The unique code of the published status.</param>
        /// <returns>Returns the Models.PublishedStatusTranslationsResponse response from the API call.</returns>
        public Models.PublishedStatusTranslationsResponse GetAllPublishedStatusTranslations(
                string publishedStatusCode)
            => CoreHelper.RunTask(GetAllPublishedStatusTranslationsAsync(publishedStatusCode));

        /// <summary>
        /// getAllPublishedStatusTranslations EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: The unique code of the published status.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PublishedStatusTranslationsResponse response from the API call.</returns>
        public async Task<Models.PublishedStatusTranslationsResponse> GetAllPublishedStatusTranslationsAsync(
                string publishedStatusCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PublishedStatusTranslationsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/published-status/{publishedStatusCode}/translations")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("publishedStatusCode", publishedStatusCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new PublishedStatusTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Published status not found", (_reason, _context) => new PublishedStatusTranslations404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updatePublishedStatusTranslations EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: The unique code of the published status.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.PublishedStatusTranslationsResponse1 response from the API call.</returns>
        public Models.PublishedStatusTranslationsResponse1 UpdatePublishedStatusTranslations(
                string publishedStatusCode,
                List<Models.PublishedStatusTranslation> body)
            => CoreHelper.RunTask(UpdatePublishedStatusTranslationsAsync(publishedStatusCode, body));

        /// <summary>
        /// updatePublishedStatusTranslations EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: The unique code of the published status.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PublishedStatusTranslationsResponse1 response from the API call.</returns>
        public async Task<Models.PublishedStatusTranslationsResponse1> UpdatePublishedStatusTranslationsAsync(
                string publishedStatusCode,
                List<Models.PublishedStatusTranslation> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PublishedStatusTranslationsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/published-status/{publishedStatusCode}/translations")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("publishedStatusCode", publishedStatusCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new PublishedStatusTranslations400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new PublishedStatusTranslations401ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Published status not found", (_reason, _context) => new PublishedStatusTranslations404ErrorException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Unprocessable Entity", (_reason, _context) => new PublishedStatusTranslations422ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}