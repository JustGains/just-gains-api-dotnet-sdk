// <copyright file="MediaAssetsControllerTest.cs" company="APIMatic">
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
    /// MediaAssetsControllerTest.
    /// </summary>
    [TestFixture]
    public class MediaAssetsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private MediaAssetsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.MediaAssetsController;
        }

        /// <summary>
        /// Get a paginated list of all media assets.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetMediaAssets()
        {
            // Parameters for the API call
            int? page = 1;
            int? pageSize = 20;

            // Perform API call
            Standard.Models.MediaAssetsResponse result = null;
            try
            {
                result = await this.controller.GetMediaAssetsAsync(page, pageSize);
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
        /// Upload a new media asset.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUploadANewMediaAsset()
        {
            // Parameters for the API call
            FileStreamInfo file = null;
            string mediaType = "image/jpeg";
            string description = null;
            string uploadDirectory = null;

            // Perform API call
            Standard.Models.MediaAssetsResponse1 result = null;
            try
            {
                result = await this.controller.UploadANewMediaAssetAsync(file, mediaType, description, uploadDirectory);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");

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
        /// Get a specific media asset.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetMediaAsset()
        {
            // Parameters for the API call
            Guid mediaAssetId = Guid.Parse("9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1");

            // Perform API call
            Standard.Models.MediaAssetsResponse1 result = null;
            try
            {
                result = await this.controller.GetMediaAssetAsync(mediaAssetId);
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
        /// Delete a media asset.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteAMediaAsset()
        {
            // Parameters for the API call
            Guid mediaAssetId = Guid.Parse("9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1");

            // Perform API call
            Standard.Models.MediaAssetsResponse4 result = null;
            try
            {
                result = await this.controller.DeleteAMediaAssetAsync(mediaAssetId);
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