// <copyright file="ProgramsProgramWeeksController.cs" company="APIMatic">
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
    /// ProgramsProgramWeeksController.
    /// </summary>
    public class ProgramsProgramWeeksController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramsProgramWeeksController"/> class.
        /// </summary>
        internal ProgramsProgramWeeksController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getWeeksForProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ProgramsWeeksResponse response from the API call.</returns>
        public Models.ProgramsWeeksResponse GetWeeksForProgram(
                int programId)
            => CoreHelper.RunTask(GetWeeksForProgramAsync(programId));

        /// <summary>
        /// getWeeksForProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProgramsWeeksResponse response from the API call.</returns>
        public async Task<Models.ProgramsWeeksResponse> GetWeeksForProgramAsync(
                int programId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProgramsWeeksResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/programs/{programId}/weeks")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("programId", programId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Program not found", (_reason, _context) => new ProgramsWeeks404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// addWeekToProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ProgramsWeeksResponse1 response from the API call.</returns>
        public Models.ProgramsWeeksResponse1 AddWeekToProgram(
                int programId,
                Models.Week body)
            => CoreHelper.RunTask(AddWeekToProgramAsync(programId, body));

        /// <summary>
        /// addWeekToProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProgramsWeeksResponse1 response from the API call.</returns>
        public async Task<Models.ProgramsWeeksResponse1> AddWeekToProgramAsync(
                int programId,
                Models.Week body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProgramsWeeksResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/programs/{programId}/weeks")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("programId", programId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ProgramsWeeks400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Program not found", (_reason, _context) => new ProgramsWeeks404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}