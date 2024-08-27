// <copyright file="ProgramsProgramViewsController.cs" company="APIMatic">
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
    /// ProgramsProgramViewsController.
    /// </summary>
    public class ProgramsProgramViewsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramsProgramViewsController"/> class.
        /// </summary>
        internal ProgramsProgramViewsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// addViewProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ProgramsViewsResponse response from the API call.</returns>
        public Models.ProgramsViewsResponse AddViewProgram(
                int programId,
                Models.ProgramView body)
            => CoreHelper.RunTask(AddViewProgramAsync(programId, body));

        /// <summary>
        /// addViewProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProgramsViewsResponse response from the API call.</returns>
        public async Task<Models.ProgramsViewsResponse> AddViewProgramAsync(
                int programId,
                Models.ProgramView body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProgramsViewsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/programs/{programId}/views")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("programId", programId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ProgramsViews400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Program not found", (_reason, _context) => new ProgramsViews404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}