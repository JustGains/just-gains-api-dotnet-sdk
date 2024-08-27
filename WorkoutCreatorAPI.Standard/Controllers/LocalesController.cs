// <copyright file="LocalesController.cs" company="APIMatic">
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
using WorkoutCreatorAPI.Standard.Http.Client;
using WorkoutCreatorAPI.Standard.Utilities;

namespace WorkoutCreatorAPI.Standard.Controllers
{
    /// <summary>
    /// LocalesController.
    /// </summary>
    public class LocalesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalesController"/> class.
        /// </summary>
        internal LocalesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getLocales EndPoint.
        /// </summary>
        /// <param name="showAll">Required parameter: Example: false.</param>
        /// <returns>Returns the Models.LocalesResponse response from the API call.</returns>
        public Models.LocalesResponse GetLocales(
                bool showAll)
            => CoreHelper.RunTask(GetLocalesAsync(showAll));

        /// <summary>
        /// getLocales EndPoint.
        /// </summary>
        /// <param name="showAll">Required parameter: Example: false.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LocalesResponse response from the API call.</returns>
        public async Task<Models.LocalesResponse> GetLocalesAsync(
                bool showAll,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LocalesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/locales")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("showAll", showAll))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new locale EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.LocalesResponse response from the API call.</returns>
        public Models.LocalesResponse CreateANewLocale(
                Models.Locale body)
            => CoreHelper.RunTask(CreateANewLocaleAsync(body));

        /// <summary>
        /// Create a new locale EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LocalesResponse response from the API call.</returns>
        public async Task<Models.LocalesResponse> CreateANewLocaleAsync(
                Models.Locale body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LocalesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/locales")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getLocale EndPoint.
        /// </summary>
        /// <param name="localeCode">Required parameter: The locale code to retrieve..</param>
        /// <returns>Returns the Models.LocalesResponse response from the API call.</returns>
        public Models.LocalesResponse GetLocale(
                string localeCode)
            => CoreHelper.RunTask(GetLocaleAsync(localeCode));

        /// <summary>
        /// getLocale EndPoint.
        /// </summary>
        /// <param name="localeCode">Required parameter: The locale code to retrieve..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LocalesResponse response from the API call.</returns>
        public async Task<Models.LocalesResponse> GetLocaleAsync(
                string localeCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LocalesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/locales/{localeCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("localeCode", localeCode))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update a locale EndPoint.
        /// </summary>
        /// <param name="localeCode">Required parameter: The locale code to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.LocalesResponse response from the API call.</returns>
        public Models.LocalesResponse UpdateALocale(
                string localeCode,
                Models.Locale body)
            => CoreHelper.RunTask(UpdateALocaleAsync(localeCode, body));

        /// <summary>
        /// Update a locale EndPoint.
        /// </summary>
        /// <param name="localeCode">Required parameter: The locale code to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LocalesResponse response from the API call.</returns>
        public async Task<Models.LocalesResponse> UpdateALocaleAsync(
                string localeCode,
                Models.Locale body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LocalesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/locales/{localeCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("localeCode", localeCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a locale EndPoint.
        /// </summary>
        /// <param name="localeCode">Required parameter: The locale code to delete..</param>
        /// <returns>Returns the Models.LocalesResponse4 response from the API call.</returns>
        public Models.LocalesResponse4 DeleteALocale(
                string localeCode)
            => CoreHelper.RunTask(DeleteALocaleAsync(localeCode));

        /// <summary>
        /// Delete a locale EndPoint.
        /// </summary>
        /// <param name="localeCode">Required parameter: The locale code to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LocalesResponse4 response from the API call.</returns>
        public async Task<Models.LocalesResponse4> DeleteALocaleAsync(
                string localeCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LocalesResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/locales/{localeCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("localeCode", localeCode))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}