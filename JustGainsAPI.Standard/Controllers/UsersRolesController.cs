// <copyright file="UsersRolesController.cs" company="APIMatic">
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
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace JustGainsAPI.Standard.Controllers
{
    /// <summary>
    /// UsersRolesController.
    /// </summary>
    public class UsersRolesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRolesController"/> class.
        /// </summary>
        internal UsersRolesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Assign a role to a user EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UsersRolesResponse response from the API call.</returns>
        public Models.UsersRolesResponse AssignARoleToAUser(
                Guid userId,
                List<string> body)
            => CoreHelper.RunTask(AssignARoleToAUserAsync(userId, body));

        /// <summary>
        /// Assign a role to a user EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UsersRolesResponse response from the API call.</returns>
        public async Task<Models.UsersRolesResponse> AssignARoleToAUserAsync(
                Guid userId,
                List<string> body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsersRolesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/users/{userId}/roles")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("userId", userId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get user roles EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UsersRolesResponse1 response from the API call.</returns>
        public Models.UsersRolesResponse1 GetUserRoles(
                Guid userId)
            => CoreHelper.RunTask(GetUserRolesAsync(userId));

        /// <summary>
        /// Get user roles EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UsersRolesResponse1 response from the API call.</returns>
        public async Task<Models.UsersRolesResponse1> GetUserRolesAsync(
                Guid userId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsersRolesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/users/{userId}/roles")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("userId", userId))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Get all roles EndPoint.
        /// </summary>
        /// <returns>Returns the Models.RolesResponse response from the API call.</returns>
        public Models.RolesResponse GetAllRoles()
            => CoreHelper.RunTask(GetAllRolesAsync());

        /// <summary>
        /// Get all roles EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RolesResponse response from the API call.</returns>
        public async Task<Models.RolesResponse> GetAllRolesAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RolesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/roles"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new role EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RolesResponse1 response from the API call.</returns>
        public Models.RolesResponse1 CreateANewRole(
                Models.RoleCreateRequest body)
            => CoreHelper.RunTask(CreateANewRoleAsync(body));

        /// <summary>
        /// Create a new role EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RolesResponse1 response from the API call.</returns>
        public async Task<Models.RolesResponse1> CreateANewRoleAsync(
                Models.RoleCreateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RolesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/roles")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update a role EndPoint.
        /// </summary>
        /// <param name="roleName">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.RolesResponse1 response from the API call.</returns>
        public Models.RolesResponse1 UpdateARole(
                string roleName,
                Models.RoleUpdateRequest body)
            => CoreHelper.RunTask(UpdateARoleAsync(roleName, body));

        /// <summary>
        /// Update a role EndPoint.
        /// </summary>
        /// <param name="roleName">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RolesResponse1 response from the API call.</returns>
        public async Task<Models.RolesResponse1> UpdateARoleAsync(
                string roleName,
                Models.RoleUpdateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RolesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/roles/{roleName}")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("roleName", roleName))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a role EndPoint.
        /// </summary>
        /// <param name="roleName">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse DeleteARole(
                string roleName)
            => CoreHelper.RunTask(DeleteARoleAsync(roleName));

        /// <summary>
        /// Delete a role EndPoint.
        /// </summary>
        /// <param name="roleName">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> DeleteARoleAsync(
                string roleName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/roles/{roleName}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("roleName", roleName))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}