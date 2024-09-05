// <copyright file="UsersRoleManagementControllerTest.cs" company="APIMatic">
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
    /// UsersRoleManagementControllerTest.
    /// </summary>
    [TestFixture]
    public class UsersRoleManagementControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private UsersRoleManagementController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.UsersRoleManagementController;
        }

        /// <summary>
        /// Get all roles.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetAllRoles()
        {
            // Perform API call
            Standard.Models.RolesResponse result = null;
            try
            {
                result = await this.controller.GetAllRolesAsync();
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
    }
}