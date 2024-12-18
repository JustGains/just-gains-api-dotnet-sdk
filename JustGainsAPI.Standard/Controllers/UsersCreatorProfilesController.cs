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
        /// <param name="page">Optional parameter: Page number for pagination.</param>
        /// <param name="mvpAssetsOnly">Optional parameter: Filter creator profiles with MVP assets only.</param>
        /// <param name="limit">Optional parameter: Number of items per page.</param>
        /// <param name="search">Optional parameter: Optional search term to filter creator profiles. The search is case-insensitive and matches against: - Creator's username - Creator's social media account usernames - Creator's full name (first name + last name)  Examples: - search=john (matches usernames, social media accounts, or names containing "john") - search=@twitter (matches social media accounts containing "@twitter") - search="John Doe" (matches full names containing "John Doe")  Leave empty to retrieve all profiles without filtering..</param>
        /// <returns>Returns the Models.CreatorProfileListResponse response from the API call.</returns>
        public Models.CreatorProfileListResponse GetCreatorProfiles(
                int? page = 1,
                bool? mvpAssetsOnly = null,
                int? limit = 20,
                string search = null)
            => CoreHelper.RunTask(GetCreatorProfilesAsync(page, mvpAssetsOnly, limit, search));

        /// <summary>
        /// getCreatorProfiles EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Page number for pagination.</param>
        /// <param name="mvpAssetsOnly">Optional parameter: Filter creator profiles with MVP assets only.</param>
        /// <param name="limit">Optional parameter: Number of items per page.</param>
        /// <param name="search">Optional parameter: Optional search term to filter creator profiles. The search is case-insensitive and matches against: - Creator's username - Creator's social media account usernames - Creator's full name (first name + last name)  Examples: - search=john (matches usernames, social media accounts, or names containing "john") - search=@twitter (matches social media accounts containing "@twitter") - search="John Doe" (matches full names containing "John Doe")  Leave empty to retrieve all profiles without filtering..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatorProfileListResponse response from the API call.</returns>
        public async Task<Models.CreatorProfileListResponse> GetCreatorProfilesAsync(
                int? page = 1,
                bool? mvpAssetsOnly = null,
                int? limit = 20,
                string search = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatorProfileListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/creator-profiles")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page ?? 1))
                      .Query(_query => _query.Setup("mvpAssetsOnly", mvpAssetsOnly))
                      .Query(_query => _query.Setup("limit", limit ?? 20))
                      .Query(_query => _query.Setup("search", search))))
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
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreatorProfileResponse response from the API call.</returns>
        public Models.CreatorProfileResponse UpdateCreatorProfile(
                Guid creatorProfileId,
                Models.CreatorProfile body)
            => CoreHelper.RunTask(UpdateCreatorProfileAsync(creatorProfileId, body));

        /// <summary>
        /// updateCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatorProfileResponse response from the API call.</returns>
        public async Task<Models.CreatorProfileResponse> UpdateCreatorProfileAsync(
                Guid creatorProfileId,
                Models.CreatorProfile body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatorProfileResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/creator-profiles/{creatorProfileId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
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