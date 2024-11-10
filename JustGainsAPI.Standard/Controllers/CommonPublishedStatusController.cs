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
        /// <returns>Returns the Models.PublishedStatusListResponse response from the API call.</returns>
        public Models.PublishedStatusListResponse GetAllPublishedStatus()
            => CoreHelper.RunTask(GetAllPublishedStatusAsync());

        /// <summary>
        /// getAllPublishedStatus EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PublishedStatusListResponse response from the API call.</returns>
        public async Task<Models.PublishedStatusListResponse> GetAllPublishedStatusAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PublishedStatusListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/published-status"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create / Update a published status EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse CreateUpdateAPublishedStatus(
                string publishedStatusCode,
                Models.PublishedStatus body)
            => CoreHelper.RunTask(CreateUpdateAPublishedStatusAsync(publishedStatusCode, body));

        /// <summary>
        /// Create / Update a published status EndPoint.
        /// </summary>
        /// <param name="publishedStatusCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> CreateUpdateAPublishedStatusAsync(
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
    }
}