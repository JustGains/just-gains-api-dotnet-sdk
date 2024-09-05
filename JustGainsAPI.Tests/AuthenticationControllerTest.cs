// <copyright file="AuthenticationControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Controllers;
using JustGainsAPI.Standard.Exceptions;
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Http.Response;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using NUnit.Framework;

namespace JustGainsAPI.Tests
{
    /// <summary>
    /// AuthenticationControllerTest.
    /// </summary>
    [TestFixture]
    public class AuthenticationControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private AuthenticationController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.AuthenticationController;
        }

        /// <summary>
        /// Get current user information.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetCurrentUserInformation()
        {
            // Perform API call
            Standard.Models.UserInfoResponse result = null;
            try
            {
                result = await this.controller.GetCurrentUserInformationAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Refresh authentication token.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRefreshAuthenticationToken()
        {
            // Perform API call
            Standard.Models.AuthResponse result = null;
            try
            {
                result = await this.controller.RefreshAuthenticationTokenAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Sign out the current user.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestSignOutTheCurrentUser()
        {
            // Perform API call
            Standard.Models.JustGainsBasicResponse result = null;
            try
            {
                result = await this.controller.SignOutTheCurrentUserAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(204, HttpCallBack.Response.StatusCode, "Status should be 204");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }
    }
}