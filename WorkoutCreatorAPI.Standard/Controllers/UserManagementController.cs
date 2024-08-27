// <copyright file="UserManagementController.cs" company="APIMatic">
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
    /// UserManagementController.
    /// </summary>
    public class UserManagementController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserManagementController"/> class.
        /// </summary>
        internal UserManagementController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Get current user information EndPoint.
        /// </summary>
        /// <returns>Returns the Models.AuthUserResponse response from the API call.</returns>
        public Models.AuthUserResponse GetCurrentUserInformation()
            => CoreHelper.RunTask(GetCurrentUserInformationAsync());

        /// <summary>
        /// Get current user information EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthUserResponse response from the API call.</returns>
        public async Task<Models.AuthUserResponse> GetCurrentUserInformationAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthUserResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/auth/user"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to retrieve user information", (_reason, _context) => new AuthUser400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update user information EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AuthUserResponse1 response from the API call.</returns>
        public Models.AuthUserResponse1 UpdateUserInformation(
                Models.UpdateUserRequest body)
            => CoreHelper.RunTask(UpdateUserInformationAsync(body));

        /// <summary>
        /// Update user information EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthUserResponse1 response from the API call.</returns>
        public async Task<Models.AuthUserResponse1> UpdateUserInformationAsync(
                Models.UpdateUserRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthUserResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/auth/user")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to update user information", (_reason, _context) => new AuthUser400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}