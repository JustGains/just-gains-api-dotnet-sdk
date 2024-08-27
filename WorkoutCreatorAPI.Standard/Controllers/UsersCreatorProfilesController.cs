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
using Newtonsoft.Json.Converters;
using System.Net.Http;
using WorkoutCreatorAPI.Standard;
using WorkoutCreatorAPI.Standard.Exceptions;
using WorkoutCreatorAPI.Standard.Http.Client;
using WorkoutCreatorAPI.Standard.Utilities;

namespace WorkoutCreatorAPI.Standard.Controllers
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
        /// <param name="limit">Optional parameter: Number of items per page.</param>
        /// <returns>Returns the Models.CreatorProfilesResponse response from the API call.</returns>
        public Models.CreatorProfilesResponse GetCreatorProfiles(
                int? page = 1,
                int? limit = 20)
            => CoreHelper.RunTask(GetCreatorProfilesAsync(page, limit));

        /// <summary>
        /// getCreatorProfiles EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Page number for pagination.</param>
        /// <param name="limit">Optional parameter: Number of items per page.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatorProfilesResponse response from the API call.</returns>
        public async Task<Models.CreatorProfilesResponse> GetCreatorProfilesAsync(
                int? page = 1,
                int? limit = 20,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatorProfilesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/creator-profiles")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page ?? 1))
                      .Query(_query => _query.Setup("limit", limit ?? 20))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new CreatorProfiles400ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("An unexpected error occurred", (_reason, _context) => new CreatorProfiles500ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// createCreatorProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreatorProfilesResponse1 response from the API call.</returns>
        public Models.CreatorProfilesResponse1 CreateCreatorProfile(
                Models.CreatorProfile body)
            => CoreHelper.RunTask(CreateCreatorProfileAsync(body));

        /// <summary>
        /// createCreatorProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatorProfilesResponse1 response from the API call.</returns>
        public async Task<Models.CreatorProfilesResponse1> CreateCreatorProfileAsync(
                Models.CreatorProfile body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatorProfilesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/creator-profiles")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new CreatorProfiles400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new CreatorProfiles401ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error", (_reason, _context) => new CreatorProfiles500ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreatorProfilesResponse1 response from the API call.</returns>
        public Models.CreatorProfilesResponse1 GetCreatorProfile(
                Guid creatorProfileId)
            => CoreHelper.RunTask(GetCreatorProfileAsync(creatorProfileId));

        /// <summary>
        /// getCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatorProfilesResponse1 response from the API call.</returns>
        public async Task<Models.CreatorProfilesResponse1> GetCreatorProfileAsync(
                Guid creatorProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatorProfilesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/creator-profiles/{creatorProfileId}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Creator profile not found", (_reason, _context) => new CreatorProfiles404ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error", (_reason, _context) => new CreatorProfiles500ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreatorProfilesResponse1 response from the API call.</returns>
        public Models.CreatorProfilesResponse1 UpdateCreatorProfile(
                Guid creatorProfileId,
                Models.CreatorProfile body)
            => CoreHelper.RunTask(UpdateCreatorProfileAsync(creatorProfileId, body));

        /// <summary>
        /// updateCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatorProfilesResponse1 response from the API call.</returns>
        public async Task<Models.CreatorProfilesResponse1> UpdateCreatorProfileAsync(
                Guid creatorProfileId,
                Models.CreatorProfile body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatorProfilesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/creator-profiles/{creatorProfileId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new CreatorProfiles400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new CreatorProfiles401ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Creator profile not found", (_reason, _context) => new CreatorProfiles404ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error", (_reason, _context) => new CreatorProfiles500ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// deleteCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.CreatorProfilesResponse4 response from the API call.</returns>
        public Models.CreatorProfilesResponse4 DeleteCreatorProfile(
                Guid creatorProfileId)
            => CoreHelper.RunTask(DeleteCreatorProfileAsync(creatorProfileId));

        /// <summary>
        /// deleteCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CreatorProfilesResponse4 response from the API call.</returns>
        public async Task<Models.CreatorProfilesResponse4> DeleteCreatorProfileAsync(
                Guid creatorProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreatorProfilesResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/creator-profiles/{creatorProfileId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new CreatorProfiles401ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Creator profile not found", (_reason, _context) => new CreatorProfiles404ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error", (_reason, _context) => new CreatorProfiles500ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}