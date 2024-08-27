// <copyright file="LocalesControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using Newtonsoft.Json.Converters;
using NUnit.Framework;
using WorkoutCreatorAPI.Standard;
using WorkoutCreatorAPI.Standard.Controllers;
using WorkoutCreatorAPI.Standard.Exceptions;
using WorkoutCreatorAPI.Standard.Http.Client;
using WorkoutCreatorAPI.Standard.Http.Response;
using WorkoutCreatorAPI.Standard.Utilities;

namespace WorkoutCreatorAPI.Tests
{
    /// <summary>
    /// LocalesControllerTest.
    /// </summary>
    [TestFixture]
    public class LocalesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private LocalesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.LocalesController;
        }

        /// <summary>
        /// Get a list of all locales.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetLocales()
        {
            // Parameters for the API call
            bool showAll = false;

            // Perform API call
            Standard.Models.LocalesResponse result = null;
            try
            {
                result = await this.controller.GetLocalesAsync(showAll);
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