// <copyright file="ExerciseMetricsController.cs" company="APIMatic">
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
    /// ExerciseMetricsController.
    /// </summary>
    public class ExerciseMetricsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseMetricsController"/> class.
        /// </summary>
        internal ExerciseMetricsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getExerciseMetrics EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale for the metric names and measurement data.</param>
        /// <returns>Returns the Models.ExerciseMetricsResponse response from the API call.</returns>
        public Models.ExerciseMetricsResponse GetExerciseMetrics(
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetExerciseMetricsAsync(localeCode));

        /// <summary>
        /// getExerciseMetrics EndPoint.
        /// </summary>
        /// <param name="localeCode">Optional parameter: The locale for the metric names and measurement data.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseMetricsResponse response from the API call.</returns>
        public async Task<Models.ExerciseMetricsResponse> GetExerciseMetricsAsync(
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseMetricsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercise-metrics")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExerciseMetrics400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Create a new exercise metric EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseMetricsResponse1 response from the API call.</returns>
        public Models.ExerciseMetricsResponse1 CreateANewExerciseMetric(
                Models.ExerciseMetric body)
            => CoreHelper.RunTask(CreateANewExerciseMetricAsync(body));

        /// <summary>
        /// Create a new exercise metric EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseMetricsResponse1 response from the API call.</returns>
        public async Task<Models.ExerciseMetricsResponse1> CreateANewExerciseMetricAsync(
                Models.ExerciseMetric body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseMetricsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/exercise-metrics")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExerciseMetrics400ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getExerciseMetric EndPoint.
        /// </summary>
        /// <param name="metricCode">Required parameter: Example: .</param>
        /// <param name="localeCode">Optional parameter: The locale for the metric name and measurement data.</param>
        /// <returns>Returns the Models.ExerciseMetricsResponse1 response from the API call.</returns>
        public Models.ExerciseMetricsResponse1 GetExerciseMetric(
                string metricCode,
                string localeCode = "en-US")
            => CoreHelper.RunTask(GetExerciseMetricAsync(metricCode, localeCode));

        /// <summary>
        /// getExerciseMetric EndPoint.
        /// </summary>
        /// <param name="metricCode">Required parameter: Example: .</param>
        /// <param name="localeCode">Optional parameter: The locale for the metric name and measurement data.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseMetricsResponse1 response from the API call.</returns>
        public async Task<Models.ExerciseMetricsResponse1> GetExerciseMetricAsync(
                string metricCode,
                string localeCode = "en-US",
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseMetricsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/exercise-metrics/{metricCode}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("metricCode", metricCode))
                      .Query(_query => _query.Setup("localeCode", localeCode ?? "en-US"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Exercise metric not found", (_reason, _context) => new ExerciseMetrics404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update an exercise metric EndPoint.
        /// </summary>
        /// <param name="metricCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseMetricsResponse1 response from the API call.</returns>
        public Models.ExerciseMetricsResponse1 UpdateAnExerciseMetric(
                string metricCode,
                Models.ExerciseMetric body)
            => CoreHelper.RunTask(UpdateAnExerciseMetricAsync(metricCode, body));

        /// <summary>
        /// Update an exercise metric EndPoint.
        /// </summary>
        /// <param name="metricCode">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseMetricsResponse1 response from the API call.</returns>
        public async Task<Models.ExerciseMetricsResponse1> UpdateAnExerciseMetricAsync(
                string metricCode,
                Models.ExerciseMetric body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseMetricsResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercise-metrics/{metricCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("metricCode", metricCode))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExerciseMetrics400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise metric not found", (_reason, _context) => new ExerciseMetrics404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete an exercise metric EndPoint.
        /// </summary>
        /// <param name="metricCode">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseMetricsResponse4 response from the API call.</returns>
        public Models.ExerciseMetricsResponse4 DeleteAnExerciseMetric(
                string metricCode)
            => CoreHelper.RunTask(DeleteAnExerciseMetricAsync(metricCode));

        /// <summary>
        /// Delete an exercise metric EndPoint.
        /// </summary>
        /// <param name="metricCode">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseMetricsResponse4 response from the API call.</returns>
        public async Task<Models.ExerciseMetricsResponse4> DeleteAnExerciseMetricAsync(
                string metricCode,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseMetricsResponse4>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/exercise-metrics/{metricCode}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("metricCode", metricCode))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Exercise metric deleted successfully", (_reason, _context) => new ExerciseMetrics404Error3Exception(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}