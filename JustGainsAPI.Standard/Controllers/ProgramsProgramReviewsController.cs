// <copyright file="ProgramsProgramReviewsController.cs" company="APIMatic">
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
    /// ProgramsProgramReviewsController.
    /// </summary>
    public class ProgramsProgramReviewsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramsProgramReviewsController"/> class.
        /// </summary>
        internal ProgramsProgramReviewsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getReviewsProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ProgramReviewResponse response from the API call.</returns>
        public Models.ProgramReviewResponse GetReviewsProgram(
                int programId)
            => CoreHelper.RunTask(GetReviewsProgramAsync(programId));

        /// <summary>
        /// getReviewsProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProgramReviewResponse response from the API call.</returns>
        public async Task<Models.ProgramReviewResponse> GetReviewsProgramAsync(
                int programId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProgramReviewResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/programs/{programId}/reviews")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("programId", programId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Program not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// addReviewProgram EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ProgramReviewResponse response from the API call.</returns>
        public Models.ProgramReviewResponse AddReviewProgram(
                Models.ProgramReview body,
                int programId)
            => CoreHelper.RunTask(AddReviewProgramAsync(body, programId));

        /// <summary>
        /// addReviewProgram EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProgramReviewResponse response from the API call.</returns>
        public async Task<Models.ProgramReviewResponse> AddReviewProgramAsync(
                Models.ProgramReview body,
                int programId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProgramReviewResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/programs/{programId}/reviews")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Template(_template => _template.Setup("programId", programId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Program not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}