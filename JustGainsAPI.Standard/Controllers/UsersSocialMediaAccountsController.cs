// <copyright file="UsersSocialMediaAccountsController.cs" company="APIMatic">
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
    /// UsersSocialMediaAccountsController.
    /// </summary>
    public class UsersSocialMediaAccountsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersSocialMediaAccountsController"/> class.
        /// </summary>
        internal UsersSocialMediaAccountsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of Users|Social Media Accounts with optional name filter.
        /// </summary>
        /// <param name="name">Optional parameter: Filter platforms by name.</param>
        /// <returns>Returns the Models.SocialMediaPlatformListResponse response from the API call.</returns>
        public Models.SocialMediaPlatformListResponse ListUsersSocialMediaAccounts(
                string name = null)
            => CoreHelper.RunTask(ListUsersSocialMediaAccountsAsync(name));

        /// <summary>
        /// Retrieve a list of Users|Social Media Accounts with optional name filter.
        /// </summary>
        /// <param name="name">Optional parameter: Filter platforms by name.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SocialMediaPlatformListResponse response from the API call.</returns>
        public async Task<Models.SocialMediaPlatformListResponse> ListUsersSocialMediaAccountsAsync(
                string name = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SocialMediaPlatformListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/social-media-platforms")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("name", name))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new social media platform.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.SocialMediaPlatformResponse response from the API call.</returns>
        public Models.SocialMediaPlatformResponse CreateSocialMediaPlatform(
                Models.SocialMediaPlatformCreate body)
            => CoreHelper.RunTask(CreateSocialMediaPlatformAsync(body));

        /// <summary>
        /// Create a new social media platform.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SocialMediaPlatformResponse response from the API call.</returns>
        public async Task<Models.SocialMediaPlatformResponse> CreateSocialMediaPlatformAsync(
                Models.SocialMediaPlatformCreate body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SocialMediaPlatformResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/social-media-platforms")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieve details of a specific social media platform.
        /// </summary>
        /// <param name="socialMediaPlatformCode">Required parameter: The unique code of the social media platform.</param>
        /// <returns>Returns the Models.SocialMediaPlatformResponse response from the API call.</returns>
        public Models.SocialMediaPlatformResponse GetSocialMediaPlatform(
                string socialMediaPlatformCode)
            => CoreHelper.RunTask(GetSocialMediaPlatformAsync(socialMediaPlatformCode));

        /// <summary>
        /// Retrieve details of a specific social media platform.
        /// </summary>
        /// <param name="socialMediaPlatformCode">Required parameter: The unique code of the social media platform.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SocialMediaPlatformResponse response from the API call.</returns>
        public async Task<Models.SocialMediaPlatformResponse> GetSocialMediaPlatformAsync(
                string socialMediaPlatformCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SocialMediaPlatformResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/social-media-platforms/{socialMediaPlatformCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("socialMediaPlatformCode", socialMediaPlatformCode))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update an existing social media platform.
        /// </summary>
        /// <param name="socialMediaPlatformCode">Required parameter: The unique code of the social media platform.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.SocialMediaPlatformResponse response from the API call.</returns>
        public Models.SocialMediaPlatformResponse UpdateSocialMediaPlatform(
                string socialMediaPlatformCode,
                Models.SocialMediaPlatformUpdate body)
            => CoreHelper.RunTask(UpdateSocialMediaPlatformAsync(socialMediaPlatformCode, body));

        /// <summary>
        /// Update an existing social media platform.
        /// </summary>
        /// <param name="socialMediaPlatformCode">Required parameter: The unique code of the social media platform.</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SocialMediaPlatformResponse response from the API call.</returns>
        public async Task<Models.SocialMediaPlatformResponse> UpdateSocialMediaPlatformAsync(
                string socialMediaPlatformCode,
                Models.SocialMediaPlatformUpdate body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SocialMediaPlatformResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/social-media-platforms/{socialMediaPlatformCode}")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("socialMediaPlatformCode", socialMediaPlatformCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a social media platform.
        /// </summary>
        /// <param name="socialMediaPlatformCode">Required parameter: The unique code of the social media platform.</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse DeleteSocialMediaPlatform(
                string socialMediaPlatformCode)
            => CoreHelper.RunTask(DeleteSocialMediaPlatformAsync(socialMediaPlatformCode));

        /// <summary>
        /// Delete a social media platform.
        /// </summary>
        /// <param name="socialMediaPlatformCode">Required parameter: The unique code of the social media platform.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> DeleteSocialMediaPlatformAsync(
                string socialMediaPlatformCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/social-media-platforms/{socialMediaPlatformCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("socialMediaPlatformCode", socialMediaPlatformCode))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// validateSocialMediaUsername EndPoint.
        /// </summary>
        /// <param name="socialMediaPlatformCode">Required parameter: The code of the social media platform to check against.</param>
        /// <param name="username">Required parameter: The username to validate.</param>
        /// <returns>Returns the Models.SocialMediaPlatformsValidateUsernameResponse response from the API call.</returns>
        public Models.SocialMediaPlatformsValidateUsernameResponse ValidateSocialMediaUsername(
                string socialMediaPlatformCode,
                string username)
            => CoreHelper.RunTask(ValidateSocialMediaUsernameAsync(socialMediaPlatformCode, username));

        /// <summary>
        /// validateSocialMediaUsername EndPoint.
        /// </summary>
        /// <param name="socialMediaPlatformCode">Required parameter: The code of the social media platform to check against.</param>
        /// <param name="username">Required parameter: The username to validate.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SocialMediaPlatformsValidateUsernameResponse response from the API call.</returns>
        public async Task<Models.SocialMediaPlatformsValidateUsernameResponse> ValidateSocialMediaUsernameAsync(
                string socialMediaPlatformCode,
                string username,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SocialMediaPlatformsValidateUsernameResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/social-media-platforms/{socialMediaPlatformCode}/validate-username/{username}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("socialMediaPlatformCode", socialMediaPlatformCode))
                      .Template(_template => _template.Setup("username", username))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}