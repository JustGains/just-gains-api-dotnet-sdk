// <copyright file="MediaAssetsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using WorkoutCreatorAPI.Standard;
using WorkoutCreatorAPI.Standard.Exceptions;
using WorkoutCreatorAPI.Standard.Http.Client;
using WorkoutCreatorAPI.Standard.Utilities;

namespace WorkoutCreatorAPI.Standard.Controllers
{
    /// <summary>
    /// MediaAssetsController.
    /// </summary>
    public class MediaAssetsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAssetsController"/> class.
        /// </summary>
        internal MediaAssetsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getMediaAssets EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Example: 1.</param>
        /// <param name="pageSize">Optional parameter: Example: 20.</param>
        /// <returns>Returns the Models.MediaAssetsResponse response from the API call.</returns>
        public Models.MediaAssetsResponse GetMediaAssets(
                int? page = 1,
                int? pageSize = 20)
            => CoreHelper.RunTask(GetMediaAssetsAsync(page, pageSize));

        /// <summary>
        /// getMediaAssets EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Example: 1.</param>
        /// <param name="pageSize">Optional parameter: Example: 20.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MediaAssetsResponse response from the API call.</returns>
        public async Task<Models.MediaAssetsResponse> GetMediaAssetsAsync(
                int? page = 1,
                int? pageSize = 20,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MediaAssetsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/media-assets")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page ?? 1))
                      .Query(_query => _query.Setup("pageSize", pageSize ?? 20))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Upload a new media asset EndPoint.
        /// </summary>
        /// <param name="file">Optional parameter: Example: .</param>
        /// <param name="mediaType">Optional parameter: Example: .</param>
        /// <param name="description">Optional parameter: Example: .</param>
        /// <param name="uploadDirectory">Optional parameter: Optional. Specify a custom upload directory..</param>
        /// <returns>Returns the Models.MediaAssetsResponse1 response from the API call.</returns>
        public Models.MediaAssetsResponse1 UploadANewMediaAsset(
                FileStreamInfo file = null,
                string mediaType = null,
                string description = null,
                string uploadDirectory = null)
            => CoreHelper.RunTask(UploadANewMediaAssetAsync(file, mediaType, description, uploadDirectory));

        /// <summary>
        /// Upload a new media asset EndPoint.
        /// </summary>
        /// <param name="file">Optional parameter: Example: .</param>
        /// <param name="mediaType">Optional parameter: Example: .</param>
        /// <param name="description">Optional parameter: Example: .</param>
        /// <param name="uploadDirectory">Optional parameter: Optional. Specify a custom upload directory..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MediaAssetsResponse1 response from the API call.</returns>
        public async Task<Models.MediaAssetsResponse1> UploadANewMediaAssetAsync(
                FileStreamInfo file = null,
                string mediaType = null,
                string description = null,
                string uploadDirectory = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MediaAssetsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/media-assets")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Form(_form => _form.Setup("file", file))
                      .Form(_form => _form.Setup("mediaType", mediaType))
                      .Form(_form => _form.Setup("description", description))
                      .Form(_form => _form.Setup("uploadDirectory", uploadDirectory))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getMediaAsset EndPoint.
        /// </summary>
        /// <param name="mediaAssetId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.MediaAssetsResponse1 response from the API call.</returns>
        public Models.MediaAssetsResponse1 GetMediaAsset(
                Guid mediaAssetId)
            => CoreHelper.RunTask(GetMediaAssetAsync(mediaAssetId));

        /// <summary>
        /// getMediaAsset EndPoint.
        /// </summary>
        /// <param name="mediaAssetId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MediaAssetsResponse1 response from the API call.</returns>
        public async Task<Models.MediaAssetsResponse1> GetMediaAssetAsync(
                Guid mediaAssetId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MediaAssetsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/media-assets/{mediaAssetId}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("mediaAssetId", mediaAssetId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Media asset not found", (_reason, _context) => new MediaAssets404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update a media asset EndPoint.
        /// </summary>
        /// <param name="mediaAssetId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.MediaAssetsResponse1 response from the API call.</returns>
        public Models.MediaAssetsResponse1 UpdateAMediaAsset(
                Guid mediaAssetId,
                Models.MediaAsset body)
            => CoreHelper.RunTask(UpdateAMediaAssetAsync(mediaAssetId, body));

        /// <summary>
        /// Update a media asset EndPoint.
        /// </summary>
        /// <param name="mediaAssetId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MediaAssetsResponse1 response from the API call.</returns>
        public async Task<Models.MediaAssetsResponse1> UpdateAMediaAssetAsync(
                Guid mediaAssetId,
                Models.MediaAsset body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MediaAssetsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/media-assets/{mediaAssetId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("mediaAssetId", mediaAssetId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Media asset not found", (_reason, _context) => new MediaAssets404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a media asset EndPoint.
        /// </summary>
        /// <param name="mediaAssetId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.MediaAssetsResponse4 response from the API call.</returns>
        public Models.MediaAssetsResponse4 DeleteAMediaAsset(
                Guid mediaAssetId)
            => CoreHelper.RunTask(DeleteAMediaAssetAsync(mediaAssetId));

        /// <summary>
        /// Delete a media asset EndPoint.
        /// </summary>
        /// <param name="mediaAssetId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MediaAssetsResponse4 response from the API call.</returns>
        public async Task<Models.MediaAssetsResponse4> DeleteAMediaAssetAsync(
                Guid mediaAssetId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MediaAssetsResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/media-assets/{mediaAssetId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("mediaAssetId", mediaAssetId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Media asset not found", (_reason, _context) => new MediaAssets404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getMediaAssetDetail EndPoint.
        /// </summary>
        /// <param name="mediaAssetId">Required parameter: Example: .</param>
        /// <param name="fileName">Required parameter: Example: .</param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public Stream GetMediaAssetDetail(
                Guid mediaAssetId,
                string fileName)
            => CoreHelper.RunTask(GetMediaAssetDetailAsync(mediaAssetId, fileName));

        /// <summary>
        /// getMediaAssetDetail EndPoint.
        /// </summary>
        /// <param name="mediaAssetId">Required parameter: Example: .</param>
        /// <param name="fileName">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public async Task<Stream> GetMediaAssetDetailAsync(
                Guid mediaAssetId,
                string fileName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Stream>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/media-assets/{mediaAssetId}/{fileName}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("mediaAssetId", mediaAssetId))
                      .Template(_template => _template.Setup("fileName", fileName))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Media asset not found", (_reason, _context) => new MediaAssets404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}