// <copyright file="ProgramsProgramAnalyticsController.cs" company="APIMatic">
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
    /// ProgramsProgramAnalyticsController.
    /// </summary>
    public class ProgramsProgramAnalyticsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramsProgramAnalyticsController"/> class.
        /// </summary>
        internal ProgramsProgramAnalyticsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// getAnlyticsProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ProgramsAnalyticsResponse response from the API call.</returns>
        public Models.ProgramsAnalyticsResponse GetAnlyticsProgram(
                int programId)
            => CoreHelper.RunTask(GetAnlyticsProgramAsync(programId));

        /// <summary>
        /// getAnlyticsProgram EndPoint.
        /// </summary>
        /// <param name="programId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ProgramsAnalyticsResponse response from the API call.</returns>
        public async Task<Models.ProgramsAnalyticsResponse> GetAnlyticsProgramAsync(
                int programId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ProgramsAnalyticsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/programs/{programId}/analytics")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("programId", programId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("404", CreateErrorCase("Program not found", (_reason, _context) => new ProgramsAnalytics404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}