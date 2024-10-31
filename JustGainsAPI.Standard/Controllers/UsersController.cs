// <copyright file="UsersController.cs" company="APIMatic">
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
    /// UsersController.
    /// </summary>
    public class UsersController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        internal UsersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Get a list of all users for admin management EndPoint.
        /// </summary>
        /// <returns>Returns the Models.UserInfoListResponse response from the API call.</returns>
        public Models.UserInfoListResponse GetAListOfAllUsersForAdminManagement()
            => CoreHelper.RunTask(GetAListOfAllUsersForAdminManagementAsync());

        /// <summary>
        /// Get a list of all users for admin management EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserInfoListResponse response from the API call.</returns>
        public async Task<Models.UserInfoListResponse> GetAListOfAllUsersForAdminManagementAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserInfoListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/users")
                  .WithAuth("bearerAuth"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Access denied", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get a user by ID EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UserResponse response from the API call.</returns>
        public Models.UserResponse GetAUserByID(
                string userId)
            => CoreHelper.RunTask(GetAUserByIDAsync(userId));

        /// <summary>
        /// Get a user by ID EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserResponse response from the API call.</returns>
        public async Task<Models.UserResponse> GetAUserByIDAsync(
                string userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/users/{userId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("userId", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid user ID format", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Access denied", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("User not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update a user EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UserResponse response from the API call.</returns>
        public Models.UserResponse UpdateAUser(
                string userId,
                Models.UpdateUserRequest body)
            => CoreHelper.RunTask(UpdateAUserAsync(userId, body));

        /// <summary>
        /// Update a user EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserResponse response from the API call.</returns>
        public async Task<Models.UserResponse> UpdateAUserAsync(
                string userId,
                Models.UpdateUserRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/users/{userId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("userId", userId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid user data", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("User not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a user EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse DeleteAUser(
                string userId)
            => CoreHelper.RunTask(DeleteAUserAsync(userId));

        /// <summary>
        /// Delete a user EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> DeleteAUserAsync(
                string userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/users/{userId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("userId", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("User not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// assignUserCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: The ID of the creator profile to assign to the user.</param>
        /// <param name="userId">Required parameter: The ID of the user to assign the creator profile to.</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse AssignUserCreatorProfile(
                string creatorProfileId,
                string userId)
            => CoreHelper.RunTask(AssignUserCreatorProfileAsync(creatorProfileId, userId));

        /// <summary>
        /// assignUserCreatorProfile EndPoint.
        /// </summary>
        /// <param name="creatorProfileId">Required parameter: The ID of the creator profile to assign to the user.</param>
        /// <param name="userId">Required parameter: The ID of the user to assign the creator profile to.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> AssignUserCreatorProfileAsync(
                string creatorProfileId,
                string userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/user/{userId}/{creatorProfileId}")
                  .WithOrAuth(_orAuth => _orAuth
                      .Add("bearerAuth")
                      .Add("userRoles")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("creatorProfileId", creatorProfileId))
                      .Template(_template => _template.Setup("userId", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to assign creator profile to user", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("409", CreateErrorCase("Creator profile is already assigned to another user", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}