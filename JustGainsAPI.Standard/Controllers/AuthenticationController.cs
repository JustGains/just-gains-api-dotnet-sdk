// <copyright file="AuthenticationController.cs" company="APIMatic">
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
    /// AuthenticationController.
    /// </summary>
    public class AuthenticationController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationController"/> class.
        /// </summary>
        internal AuthenticationController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getUserInfo EndPoint.
        /// </summary>
        /// <returns>Returns the Models.UserInfoResponse response from the API call.</returns>
        public Models.UserInfoResponse GetUserInfo()
            => CoreHelper.RunTask(GetUserInfoAsync());

        /// <summary>
        /// getUserInfo EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserInfoResponse response from the API call.</returns>
        public async Task<Models.UserInfoResponse> GetUserInfoAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserInfoResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/auth/user")
                  .WithAuth("bearerAuth"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Failed to retrieve user information", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateUserInfo EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse UpdateUserInfo(
                Models.UpdateUserRequest body)
            => CoreHelper.RunTask(UpdateUserInfoAsync(body));

        /// <summary>
        /// updateUserInfo EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> UpdateUserInfoAsync(
                Models.UpdateUserRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/auth/user")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to update user information", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// registerUser EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.UserInfoResponse response from the API call.</returns>
        public Models.UserInfoResponse RegisterUser(
                Models.UserRegisterRequest body)
            => CoreHelper.RunTask(RegisterUserAsync(body));

        /// <summary>
        /// registerUser EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UserInfoResponse response from the API call.</returns>
        public async Task<Models.UserInfoResponse> RegisterUserAsync(
                Models.UserRegisterRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserInfoResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/signup")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid parameters", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// loginUser EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AuthSigninResponse response from the API call.</returns>
        public Models.AuthSigninResponse LoginUser(
                Models.UserLoginRequest body)
            => CoreHelper.RunTask(LoginUserAsync(body));

        /// <summary>
        /// loginUser EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthSigninResponse response from the API call.</returns>
        public async Task<Models.AuthSigninResponse> LoginUserAsync(
                Models.UserLoginRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthSigninResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/signin")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid credentials", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// resendConfirmationEmail EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse ResendConfirmationEmail(
                Models.ConfirmEmailRequest body)
            => CoreHelper.RunTask(ResendConfirmationEmailAsync(body));

        /// <summary>
        /// resendConfirmationEmail EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> ResendConfirmationEmailAsync(
                Models.ConfirmEmailRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/resend-confirmation-email")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to send confirmation email", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// forgotPassword EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse ForgotPassword(
                Models.ForgotPasswordRequest body)
            => CoreHelper.RunTask(ForgotPasswordAsync(body));

        /// <summary>
        /// forgotPassword EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> ForgotPasswordAsync(
                Models.ForgotPasswordRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/forgot-password")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Failed to send password reset email", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// resetPassword EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse ResetPassword(
                Models.ResetPasswordRequest body)
            => CoreHelper.RunTask(ResetPasswordAsync(body));

        /// <summary>
        /// resetPassword EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> ResetPasswordAsync(
                Models.ResetPasswordRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/reset-password")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to reset password", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// refreshToken EndPoint.
        /// </summary>
        /// <returns>Returns the Models.AuthRefreshTokenResponse response from the API call.</returns>
        public Models.AuthRefreshTokenResponse RefreshToken()
            => CoreHelper.RunTask(RefreshTokenAsync());

        /// <summary>
        /// refreshToken EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthRefreshTokenResponse response from the API call.</returns>
        public async Task<Models.AuthRefreshTokenResponse> RefreshTokenAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthRefreshTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/refresh-token"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to refresh token", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// signout EndPoint.
        /// </summary>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse Signout()
            => CoreHelper.RunTask(SignoutAsync());

        /// <summary>
        /// signout EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> SignoutAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/signout")
                  .WithAuth("bearerAuth"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to sign out user", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// initiateAuth EndPoint.
        /// </summary>
        /// <param name="provider">Required parameter: OAuth provider name (e.g., 'google', 'facebook').</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AuthInitiateResponse response from the API call.</returns>
        public Models.AuthInitiateResponse InitiateAuth(
                string provider,
                Models.InitiateAuthRequest body)
            => CoreHelper.RunTask(InitiateAuthAsync(provider, body));

        /// <summary>
        /// initiateAuth EndPoint.
        /// </summary>
        /// <param name="provider">Required parameter: OAuth provider name (e.g., 'google', 'facebook').</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthInitiateResponse response from the API call.</returns>
        public async Task<Models.AuthInitiateResponse> InitiateAuthAsync(
                string provider,
                Models.InitiateAuthRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthInitiateResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/{provider}/initiate")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("provider", provider))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to initiate OAuth flow", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// handleCallback EndPoint.
        /// </summary>
        /// <param name="provider">Required parameter: OAuth provider name (e.g., 'google', 'facebook').</param>
        /// <param name="code">Required parameter: Authorization code from OAuth provider.</param>
        /// <param name="error">Optional parameter: Error code from OAuth provider.</param>
        /// <param name="errorDescription">Optional parameter: Detailed error description from OAuth provider.</param>
        /// <returns>Returns the Models.AuthCallbackResponse response from the API call.</returns>
        public Models.AuthCallbackResponse HandleCallback(
                string provider,
                string code,
                string error = null,
                string errorDescription = null)
            => CoreHelper.RunTask(HandleCallbackAsync(provider, code, error, errorDescription));

        /// <summary>
        /// handleCallback EndPoint.
        /// </summary>
        /// <param name="provider">Required parameter: OAuth provider name (e.g., 'google', 'facebook').</param>
        /// <param name="code">Required parameter: Authorization code from OAuth provider.</param>
        /// <param name="error">Optional parameter: Error code from OAuth provider.</param>
        /// <param name="errorDescription">Optional parameter: Detailed error description from OAuth provider.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthCallbackResponse response from the API call.</returns>
        public async Task<Models.AuthCallbackResponse> HandleCallbackAsync(
                string provider,
                string code,
                string error = null,
                string errorDescription = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthCallbackResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/auth/{provider}/callback")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("provider", provider))
                      .Query(_query => _query.Setup("code", code))
                      .Query(_query => _query.Setup("error", error))
                      .Query(_query => _query.Setup("errorDescription", errorDescription))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to handle OAuth callback", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getSettings EndPoint.
        /// </summary>
        /// <param name="provider">Required parameter: OAuth provider name (e.g., 'google', 'facebook').</param>
        /// <returns>Returns the Models.AuthSettingsResponse response from the API call.</returns>
        public Models.AuthSettingsResponse GetSettings(
                string provider)
            => CoreHelper.RunTask(GetSettingsAsync(provider));

        /// <summary>
        /// getSettings EndPoint.
        /// </summary>
        /// <param name="provider">Required parameter: OAuth provider name (e.g., 'google', 'facebook').</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthSettingsResponse response from the API call.</returns>
        public async Task<Models.AuthSettingsResponse> GetSettingsAsync(
                string provider,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthSettingsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/auth/{provider}/settings")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("provider", provider))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to retrieve OAuth provider settings", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}