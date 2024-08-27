// <copyright file="ProgramsControllerTest.cs" company="APIMatic">
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
    /// ProgramsControllerTest.
    /// </summary>
    [TestFixture]
    public class ProgramsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ProgramsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ProgramsController;
        }

        /// <summary>
        /// Get a list of programs.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetPrograms()
        {
            // Parameters for the API call
            int? page = 1;
            int? pageSize = 20;
            Standard.Models.SortByEnum sortBy = ApiHelper.JsonDeserialize<Standard.Models.SortByEnum>("\"createdAt\"");
            Standard.Models.SortOrderEnum sortOrder = ApiHelper.JsonDeserialize<Standard.Models.SortOrderEnum>("\"desc\"");
            string publishStatusCode = null;
            Guid? userId = null;

            // Perform API call
            Standard.Models.ProgramsResponse result = null;
            try
            {
                result = await this.controller.GetProgramsAsync(page, pageSize, sortBy, sortOrder, publishStatusCode, userId);
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