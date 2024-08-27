// <copyright file="ExercisesControllerTest.cs" company="APIMatic">
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
    /// ExercisesControllerTest.
    /// </summary>
    [TestFixture]
    public class ExercisesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ExercisesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ExercisesController;
        }

        /// <summary>
        /// Get a list of all exercises.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetExercises()
        {
            // Parameters for the API call
            List<string> exerciseCategoryCodes = null;
            List<string> exerciseTypeCodes = null;
            List<string> exerciseEquipmentCodes = null;
            List<string> exerciseMuscleCodes = null;
            List<string> exerciseMetricCodes = null;
            List<string> publishedStatusCodes = null;
            string localeCode = "en-US";
            int? pageIndex = 1;
            int? pageSize = 100;

            // Perform API call
            Standard.Models.ExercisesResponse result = null;
            try
            {
                result = await this.controller.GetExercisesAsync(exerciseCategoryCodes, exerciseTypeCodes, exerciseEquipmentCodes, exerciseMuscleCodes, exerciseMetricCodes, publishedStatusCodes, localeCode, pageIndex, pageSize);
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