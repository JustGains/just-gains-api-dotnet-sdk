// <copyright file="ExerciseLibraryExerciseMetricsController.cs" company="APIMatic">
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
using JustGainsAPI.Standard.Exceptions;
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace JustGainsAPI.Standard.Controllers
{
    /// <summary>
    /// ExerciseLibraryExerciseMetricsController.
    /// </summary>
    public class ExerciseLibraryExerciseMetricsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseLibraryExerciseMetricsController"/> class.
        /// </summary>
        internal ExerciseLibraryExerciseMetricsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve a list of all exercise metrics - Since the exercise type is never displayed, we don't have a translation for it.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale for the metric names and measurement data.</param>
        /// <returns>Returns the Models.ExerciseMetricListResponse response from the API call.</returns>
        public Models.ExerciseMetricListResponse GetExerciseMetrics(
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetExerciseMetricsAsync(localeCode));

        /// <summary>
        /// Retrieve a list of all exercise metrics - Since the exercise type is never displayed, we don't have a translation for it.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale for the metric names and measurement data.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseMetricListResponse response from the API call.</returns>
        public async Task<Models.ExerciseMetricListResponse> GetExerciseMetricsAsync(
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseMetricListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercise-metrics")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new exercise metric EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse CreateANewExerciseMetric(
                Models.ExerciseMetric body)
            => CoreHelper.RunTask(CreateANewExerciseMetricAsync(body));

        /// <summary>
        /// Create a new exercise metric EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> CreateANewExerciseMetricAsync(
                Models.ExerciseMetric body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/exercise-metrics")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update an exercise metric EndPoint.
        /// </summary>
        /// <param name="metricCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse UpdateAnExerciseMetric(
                string metricCode,
                Models.ExerciseMetric body)
            => CoreHelper.RunTask(UpdateAnExerciseMetricAsync(metricCode, body));

        /// <summary>
        /// Update an exercise metric EndPoint.
        /// </summary>
        /// <param name="metricCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> UpdateAnExerciseMetricAsync(
                string metricCode,
                Models.ExerciseMetric body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercise-metrics/{metricCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("metricCode", metricCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise metric not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an exercise metric EndPoint.
        /// </summary>
        /// <param name="metricCode">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse DeleteAnExerciseMetric(
                string metricCode)
            => CoreHelper.RunTask(DeleteAnExerciseMetricAsync(metricCode));

        /// <summary>
        /// Delete an exercise metric EndPoint.
        /// </summary>
        /// <param name="metricCode">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> DeleteAnExerciseMetricAsync(
                string metricCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/exercise-metrics/{metricCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("metricCode", metricCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Exercise metric not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}