// <copyright file="CommonLocalesController.cs" company="APIMatic">
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
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace JustGainsAPI.Standard.Controllers
{
    /// <summary>
    /// CommonLocalesController.
    /// </summary>
    public class CommonLocalesController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonLocalesController"/> class.
        /// </summary>
        internal CommonLocalesController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getLocales EndPoint.
        /// </summary>
        /// <param name="showAll">Required parameter: Example: false.</param>
        /// <returns>Returns the Models.LocaleListResponse response from the API call.</returns>
        public Models.LocaleListResponse GetLocales(
                bool showAll)
            => CoreHelper.RunTask(GetLocalesAsync(showAll));

        /// <summary>
        /// getLocales EndPoint.
        /// </summary>
        /// <param name="showAll">Required parameter: Example: false.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LocaleListResponse response from the API call.</returns>
        public async Task<Models.LocaleListResponse> GetLocalesAsync(
                bool showAll,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LocaleListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/locales")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("showAll", showAll))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new locale EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse CreateANewLocale(
                Models.Locale body)
            => CoreHelper.RunTask(CreateANewLocaleAsync(body));

        /// <summary>
        /// Create a new locale EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> CreateANewLocaleAsync(
                Models.Locale body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
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
        /// <returns>Returns the Models.LocaleResponse response from the API call.</returns>
        public Models.LocaleResponse GetLocale(
                string localeCode)
            => CoreHelper.RunTask(GetLocaleAsync(localeCode));

        /// <summary>
        /// getLocale EndPoint.
        /// </summary>
        /// <param name="localeCode">Required parameter: The locale code to retrieve..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LocaleResponse response from the API call.</returns>
        public async Task<Models.LocaleResponse> GetLocaleAsync(
                string localeCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LocaleResponse>()
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
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse UpdateALocale(
                string localeCode,
                Models.Locale body)
            => CoreHelper.RunTask(UpdateALocaleAsync(localeCode, body));

        /// <summary>
        /// Update a locale EndPoint.
        /// </summary>
        /// <param name="localeCode">Required parameter: The locale code to update..</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> UpdateALocaleAsync(
                string localeCode,
                Models.Locale body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
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
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse DeleteALocale(
                string localeCode)
            => CoreHelper.RunTask(DeleteALocaleAsync(localeCode));

        /// <summary>
        /// Delete a locale EndPoint.
        /// </summary>
        /// <param name="localeCode">Required parameter: The locale code to delete..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> DeleteALocaleAsync(
                string localeCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/locales/{localeCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("localeCode", localeCode))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}