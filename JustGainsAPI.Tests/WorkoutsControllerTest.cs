// <copyright file="WorkoutsControllerTest.cs" company="APIMatic">
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
    /// WorkoutsControllerTest.
    /// </summary>
    [TestFixture]
    public class WorkoutsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private WorkoutsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.WorkoutsController;
        }

        /// <summary>
        /// Get a paginated list of workouts.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetAPaginatedListOfWorkouts()
        {
            // Parameters for the API call
            int? page = 1;
            int? pageSize = 20;
            string sortBy = null;
            Standard.Models.SortOrderEnum sortOrder = ApiHelper.JsonDeserialize<Standard.Models.SortOrderEnum>("\"desc\"");

            // Perform API call
            Standard.Models.WorkoutTableListResponse result = null;
            try
            {
                result = await this.controller.GetAPaginatedListOfWorkoutsAsync(page, pageSize, sortBy, sortOrder);
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
        /// Get a workout by ID.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetAWorkoutByID()
        {
            // Parameters for the API call
            Guid workoutId = Guid.Parse("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");

            // Perform API call
            Standard.Models.WorkoutResponse result = null;
            try
            {
                result = await this.controller.GetAWorkoutByIDAsync(workoutId);
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
        /// Soft-deletes a workout and all associated data.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteAWorkout()
        {
            // Parameters for the API call
            Guid workoutId = Guid.Parse("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");

            // Perform API call
            Standard.Models.WorkoutResponse result = null;
            try
            {
                result = await this.controller.DeleteAWorkoutAsync(workoutId);
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

        /// <summary>
        /// Get a workout by workout slug.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetAWorkoutByWorkoutSlug()
        {
            // Parameters for the API call
            string workoutSlug = "full-body-strength-training";

            // Perform API call
            Standard.Models.WorkoutResponse result = null;
            try
            {
                result = await this.controller.GetAWorkoutByWorkoutSlugAsync(workoutSlug);
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