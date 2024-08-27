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
using Newtonsoft.Json.Converters;
using System.Net.Http;
using WorkoutCreatorAPI.Standard;
using WorkoutCreatorAPI.Standard.Exceptions;
using WorkoutCreatorAPI.Standard.Http.Client;
using WorkoutCreatorAPI.Standard.Utilities;

namespace WorkoutCreatorAPI.Standard.Controllers
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
        /// Get a list of all users EndPoint.
        /// </summary>
        /// <returns>Returns the List of Models.UsersResponse response from the API call.</returns>
        public List<Models.UsersResponse> GetAListOfAllUsers()
            => CoreHelper.RunTask(GetAListOfAllUsersAsync());

        /// <summary>
        /// Get a list of all users EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the List of Models.UsersResponse response from the API call.</returns>
        public async Task<List<Models.UsersResponse>> GetAListOfAllUsersAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.UsersResponse>>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/users")
                  .WithAuth("bearerAuth"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new Users401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Access denied", (_reason, _context) => new Users403ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get a user by ID EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UsersResponse1 response from the API call.</returns>
        public Models.UsersResponse1 GetAUserByID(
                string userId)
            => CoreHelper.RunTask(GetAUserByIDAsync(userId));

        /// <summary>
        /// Get a user by ID EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UsersResponse1 response from the API call.</returns>
        public async Task<Models.UsersResponse1> GetAUserByIDAsync(
                string userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsersResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/users/{userId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("userId", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid user ID format", (_reason, _context) => new Users400ErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Authentication required", (_reason, _context) => new Users401ErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Access denied", (_reason, _context) => new Users403ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("User not found", (_reason, _context) => new Users404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update a user EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UsersResponse2 response from the API call.</returns>
        public Models.UsersResponse2 UpdateAUser(
                string userId,
                Models.UserWithoutCreatorProfile body)
            => CoreHelper.RunTask(UpdateAUserAsync(userId, body));

        /// <summary>
        /// Update a user EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UsersResponse2 response from the API call.</returns>
        public async Task<Models.UsersResponse2> UpdateAUserAsync(
                string userId,
                Models.UserWithoutCreatorProfile body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsersResponse2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/users/{userId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("userId", userId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid user data", (_reason, _context) => new Users400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("User not found", (_reason, _context) => new Users404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a user EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UsersResponse3 response from the API call.</returns>
        public Models.UsersResponse3 DeleteAUser(
                string userId)
            => CoreHelper.RunTask(DeleteAUserAsync(userId));

        /// <summary>
        /// Delete a user EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UsersResponse3 response from the API call.</returns>
        public async Task<Models.UsersResponse3> DeleteAUserAsync(
                string userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsersResponse3>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/users/{userId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("userId", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("User not found", (_reason, _context) => new Users404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}