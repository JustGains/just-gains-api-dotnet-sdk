// <copyright file="EquipmentEquipmentGroupsControllerTest.cs" company="APIMatic">
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
    /// EquipmentEquipmentGroupsControllerTest.
    /// </summary>
    [TestFixture]
    public class EquipmentEquipmentGroupsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private EquipmentEquipmentGroupsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.EquipmentEquipmentGroupsController;
        }

        /// <summary>
        /// Get a list of all equipment groups.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetEquipmentGroups()
        {
            // Parameters for the API call
            string localeCode = "en-US";

            // Perform API call
            Standard.Models.EquipmentGroupsResponse result = null;
            try
            {
                result = await this.controller.GetEquipmentGroupsAsync(localeCode);
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