// <copyright file="UsersCreatorProfilesController.cs" company="APIMatic">
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
    /// UsersCreatorProfilesController.
    /// </summary>
    public class UsersCreatorProfilesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersCreatorProfilesController"/> class.
        /// </summary>
        internal UsersCreatorProfilesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getCreatorProfiles EndPoint.
        /// </summary>
        /// <param name="limit">Optional parameter: Number of items per page.</param>
        /// <param name="page">Optional parameter: Page number for pagination.</param>
        /// <returns>Returns the Models.CreatorProfileListResponse response from the API call.</returns>
        public Models.CreatorProfileListResponse GetCreatorProfiles(
                int? limit = 20,
                int? page = 1)
            => CoreHelper.RunTask(GetCreatorProfilesAsync(limit, page));

        /// <summary>
        /// getCreatorProfiles EndPoint.
        /// </summary>
        /// <param name="limit">Optional parameter: Number of items per page.</param>
        /// <param name="page">Optional parameter: Page number for pagination.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatorProfileListResponse response from the API call.</returns>
        public async Task<Models.CreatorProfileListResponse> GetCreatorProfilesAsync(
                int? limit = 20,
                int? page = 1,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatorProfileListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/creator-profiles")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("limit", limit ?? 20))
                      .Query(_query => _query.Setup("page", page ?? 1))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// createCreatorProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreatorProfileResponse response from the API call.</returns>
        public Models.CreatorProfileResponse CreateCreatorProfile(
                Models.CreatorProfile body)
            => CoreHelper.RunTask(CreateCreatorProfileAsync(body));

        /// <summary>
        /// createCreatorProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatorProfileResponse response from the API call.</returns>
        public async Task<Models.CreatorProfileResponse> CreateCreatorProfileAsync(
                Models.CreatorProfile body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatorProfileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/creator-profiles")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreatorProfileResponse response from the API call.</returns>
        public Models.CreatorProfileResponse GetCreatorProfile(
                Guid creatorProfileId)
            => CoreHelper.RunTask(GetCreatorProfileAsync(creatorProfileId));

        /// <summary>
        /// getCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatorProfileResponse response from the API call.</returns>
        public async Task<Models.CreatorProfileResponse> GetCreatorProfileAsync(
                Guid creatorProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatorProfileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/creator-profiles/{creatorProfileId}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Creator profile not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateCreatorProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreatorProfileResponse response from the API call.</returns>
        public Models.CreatorProfileResponse UpdateCreatorProfile(
                Models.CreatorProfile body,
                Guid creatorProfileId)
            => CoreHelper.RunTask(UpdateCreatorProfileAsync(body, creatorProfileId));

        /// <summary>
        /// updateCreatorProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatorProfileResponse response from the API call.</returns>
        public async Task<Models.CreatorProfileResponse> UpdateCreatorProfileAsync(
                Models.CreatorProfile body,
                Guid creatorProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatorProfileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/creator-profiles/{creatorProfileId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Creator profile not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// deleteCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse DeleteCreatorProfile(
                Guid creatorProfileId)
            => CoreHelper.RunTask(DeleteCreatorProfileAsync(creatorProfileId));

        /// <summary>
        /// deleteCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> DeleteCreatorProfileAsync(
                Guid creatorProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/creator-profiles/{creatorProfileId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Creator profile not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}