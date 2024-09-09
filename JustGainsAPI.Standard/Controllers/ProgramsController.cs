// <copyright file="ProgramsController.cs" company="APIMatic">
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
    /// ProgramsController.
    /// </summary>
    public class ProgramsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramsController"/> class.
        /// </summary>
        internal ProgramsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getPrograms EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Example: 1.</param>
        /// <param name="pageSize">Optional parameter: Example: 20.</param>
        /// <param name="publishStatusCode">Optional parameter: Example: .</param>
        /// <param name="sortBy">Optional parameter: Example: .</param>
        /// <param name="sortOrder">Optional parameter: Example: desc.</param>
        /// <param name="userId">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.ProgramListResponse response from the API call.</returns>
        public Models.ProgramListResponse GetPrograms(
                int? page = 1,
                int? pageSize = 20,
                string publishStatusCode = null,
                string sortBy = null,
                Models.SortOrderEnum? sortOrder = Models.SortOrderEnum.Desc,
                Guid? userId = null)
            => CoreHelper.RunTask(GetProgramsAsync(page, pageSize, publishStatusCode, sortBy, sortOrder, userId));

        /// <summary>
        /// getPrograms EndPoint.
        /// </summary>
        /// <param name="page">Optional parameter: Example: 1.</param>
        /// <param name="pageSize">Optional parameter: Example: 20.</param>
        /// <param name="publishStatusCode">Optional parameter: Example: .</param>
        /// <param name="sortBy">Optional parameter: Example: .</param>
        /// <param name="sortOrder">Optional parameter: Example: desc.</param>
        /// <param name="userId">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProgramListResponse response from the API call.</returns>
        public async Task<Models.ProgramListResponse> GetProgramsAsync(
                int? page = 1,
                int? pageSize = 20,
                string publishStatusCode = null,
                string sortBy = null,
                Models.SortOrderEnum? sortOrder = Models.SortOrderEnum.Desc,
                Guid? userId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProgramListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/programs")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("page", page ?? 1))
                      .Query(_query => _query.Setup("pageSize", pageSize ?? 20))
                      .Query(_query => _query.Setup("publishStatusCode", publishStatusCode))
                      .Query(_query => _query.Setup("sortBy", sortBy))
                      .Query(_query => _query.Setup("sortOrder", (sortOrder.HasValue) ? ApiHelper.JsonSerialize(sortOrder.Value).Trim('\"') : "desc"))
                      .Query(_query => _query.Setup("userId", userId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// createProgram EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ProgramResponse response from the API call.</returns>
        public Models.ProgramResponse CreateProgram(
                Models.Program body)
            => CoreHelper.RunTask(CreateProgramAsync(body));

        /// <summary>
        /// createProgram EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProgramResponse response from the API call.</returns>
        public async Task<Models.ProgramResponse> CreateProgramAsync(
                Models.Program body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProgramResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/programs")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// getProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ProgramResponse response from the API call.</returns>
        public Models.ProgramResponse GetProgram(
                int programId)
            => CoreHelper.RunTask(GetProgramAsync(programId));

        /// <summary>
        /// getProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProgramResponse response from the API call.</returns>
        public async Task<Models.ProgramResponse> GetProgramAsync(
                int programId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProgramResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/programs/{programId}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("programId", programId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Program not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// updateProgram EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public Models.JustGainsResponse UpdateProgram(
                Models.Program body,
                int programId)
            => CoreHelper.RunTask(UpdateProgramAsync(body, programId));

        /// <summary>
        /// updateProgram EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsResponse response from the API call.</returns>
        public async Task<Models.JustGainsResponse> UpdateProgramAsync(
                Models.Program body,
                int programId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/programs/{programId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Template(_template => _template.Setup("programId", programId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Program not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// deleteProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public Models.JustGainsBasicResponse DeleteProgram(
                int programId)
            => CoreHelper.RunTask(DeleteProgramAsync(programId));

        /// <summary>
        /// deleteProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.JustGainsBasicResponse response from the API call.</returns>
        public async Task<Models.JustGainsBasicResponse> DeleteProgramAsync(
                int programId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.JustGainsBasicResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/programs/{programId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("programId", programId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Program not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}