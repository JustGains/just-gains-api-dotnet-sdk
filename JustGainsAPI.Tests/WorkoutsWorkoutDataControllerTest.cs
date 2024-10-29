// <copyright file="WorkoutsWorkoutDataControllerTest.cs" company="APIMatic">
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
    /// WorkoutsWorkoutDataControllerTest.
    /// </summary>
    [TestFixture]
    public class WorkoutsWorkoutDataControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private WorkoutsWorkoutDataController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.WorkoutsWorkoutDataController;
        }

        /// <summary>
        /// Get workout data by workout ID.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetWorkoutDataById()
        {
            // Parameters for the API call
            Guid workoutId = Guid.Parse("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");

            // Perform API call
            Standard.Models.WorkoutDataListResponse result = null;
            try
            {
                result = await this.controller.GetWorkoutDataByIdAsync(workoutId);
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