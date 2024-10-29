// <copyright file="WorkoutsWorkoutContentControllerTest.cs" company="APIMatic">
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
    /// WorkoutsWorkoutContentControllerTest.
    /// </summary>
    [TestFixture]
    public class WorkoutsWorkoutContentControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private WorkoutsWorkoutContentController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.WorkoutsWorkoutContentController;
        }

        /// <summary>
        /// Get workout content by ID.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetWorkoutContentByID()
        {
            // Parameters for the API call
            Guid workoutId = Guid.Parse("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");

            // Perform API call
            Standard.Models.WorkoutContentResponse result = null;
            try
            {
                result = await this.controller.GetWorkoutContentByIDAsync(workoutId);
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
        /// Update workout content by ID.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateWorkoutContentByID()
        {
            // Parameters for the API call
            Guid workoutId = Guid.Parse("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
            Standard.Models.WorkoutContent body = null;

            // Perform API call
            Standard.Models.WorkoutContentResponse result = null;
            try
            {
                result = await this.controller.UpdateWorkoutContentByIDAsync(workoutId, body);
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