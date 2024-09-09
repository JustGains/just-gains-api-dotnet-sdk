// <copyright file="ExercisesControllerTest.cs" company="APIMatic">
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
            List<string> exerciseCategoryCodes = ApiHelper.JsonDeserialize<List<string>>("[\"STRENGTH\",\"CARDIO\"]");
            List<string> exerciseEquipmentCodes = null;
            List<string> exerciseMetricCodes = null;
            List<string> exerciseMuscleCodes = null;
            List<string> exerciseTypeCodes = null;
            string localeCode = "en-US";
            string nameSearch = "Bench Press";
            int? pageIndex = 1;
            int? pageSize = 100;
            List<string> publishedStatusCodes = null;

            // Perform API call
            Standard.Models.ExerciseListResponse result = null;
            try
            {
                result = await this.controller.GetExercisesAsync(exerciseCategoryCodes, exerciseEquipmentCodes, exerciseMetricCodes, exerciseMuscleCodes, exerciseTypeCodes, localeCode, nameSearch, pageIndex, pageSize, publishedStatusCodes);
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