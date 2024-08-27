// <copyright file="AuthenticationNewController.cs" company="APIMatic">
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
    /// AuthenticationNewController.
    /// </summary>
    public class AuthenticationNewController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationNewController"/> class.
        /// </summary>
        internal AuthenticationNewController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Register a new user EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AuthSignupResponse response from the API call.</returns>
        public Models.AuthSignupResponse RegisterANewUser(
                Models.UserRegisterRequest body)
            => CoreHelper.RunTask(RegisterANewUserAsync(body));

        /// <summary>
        /// Register a new user EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthSignupResponse response from the API call.</returns>
        public async Task<Models.AuthSignupResponse> RegisterANewUserAsync(
                Models.UserRegisterRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthSignupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/signup")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid parameters", (_reason, _context) => new AuthSignup400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Sign in a user EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AuthSigninResponse response from the API call.</returns>
        public Models.AuthSigninResponse SignInAUser(
                Models.UserLoginRequest body)
            => CoreHelper.RunTask(SignInAUserAsync(body));

        /// <summary>
        /// Sign in a user EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthSigninResponse response from the API call.</returns>
        public async Task<Models.AuthSigninResponse> SignInAUserAsync(
                Models.UserLoginRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthSigninResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/signin")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid credentials", (_reason, _context) => new AuthSignin400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Resend confirmation email EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AuthResendConfirmationEmailResponse response from the API call.</returns>
        public Models.AuthResendConfirmationEmailResponse ResendConfirmationEmail(
                Models.ConfirmEmailRequest body)
            => CoreHelper.RunTask(ResendConfirmationEmailAsync(body));

        /// <summary>
        /// Resend confirmation email EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthResendConfirmationEmailResponse response from the API call.</returns>
        public async Task<Models.AuthResendConfirmationEmailResponse> ResendConfirmationEmailAsync(
                Models.ConfirmEmailRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthResendConfirmationEmailResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/resend-confirmation-email")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to send confirmation email", (_reason, _context) => new AuthResendConfirmationEmail400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Initiate forgot password process EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AuthForgotPasswordResponse response from the API call.</returns>
        public Models.AuthForgotPasswordResponse InitiateForgotPasswordProcess(
                Models.ForgotPasswordRequest body)
            => CoreHelper.RunTask(InitiateForgotPasswordProcessAsync(body));

        /// <summary>
        /// Initiate forgot password process EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthForgotPasswordResponse response from the API call.</returns>
        public async Task<Models.AuthForgotPasswordResponse> InitiateForgotPasswordProcessAsync(
                Models.ForgotPasswordRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthForgotPasswordResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/forgot-password")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Reset user password EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.AuthResetPasswordResponse response from the API call.</returns>
        public Models.AuthResetPasswordResponse ResetUserPassword(
                Models.ResetPasswordRequest body)
            => CoreHelper.RunTask(ResetUserPasswordAsync(body));

        /// <summary>
        /// Reset user password EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthResetPasswordResponse response from the API call.</returns>
        public async Task<Models.AuthResetPasswordResponse> ResetUserPasswordAsync(
                Models.ResetPasswordRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthResetPasswordResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/reset-password")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Failed to reset password", (_reason, _context) => new AuthResetPassword400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Refresh authentication token EndPoint.
        /// </summary>
        /// <returns>Returns the Models.AuthRefreshTokenResponse response from the API call.</returns>
        public Models.AuthRefreshTokenResponse RefreshAuthenticationToken()
            => CoreHelper.RunTask(RefreshAuthenticationTokenAsync());

        /// <summary>
        /// Refresh authentication token EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuthRefreshTokenResponse response from the API call.</returns>
        public async Task<Models.AuthRefreshTokenResponse> RefreshAuthenticationTokenAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthRefreshTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/refresh-token"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Sign out the current user EndPoint.
        /// </summary>
        /// <returns>Returns the Models.JustGainsDefaultResponse response from the API call.</returns>
        public Models.JustGainsDefaultResponse SignOutTheCurrentUser()
            => CoreHelper.RunTask(SignOutTheCurrentUserAsync());

        /// <summary>
        /// Sign out the current user EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsDefaultResponse response from the API call.</returns>
        public async Task<Models.JustGainsDefaultResponse> SignOutTheCurrentUserAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsDefaultResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/auth/signout"))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}