// <copyright file="ExerciseDraftsController.cs" company="APIMatic">
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
    /// ExerciseDraftsController.
    /// </summary>
    public class ExerciseDraftsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseDraftsController"/> class.
        /// </summary>
        internal ExerciseDraftsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create or Update an existing exercise with the Exercise Draft format.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseDraftResponse response from the API call.</returns>
        public Models.ExerciseDraftResponse ExerciseDraftFormat(
                Models.ExerciseDraftDTO body)
            => CoreHelper.RunTask(ExerciseDraftFormatAsync(body));

        /// <summary>
        /// Create or Update an existing exercise with the Exercise Draft format.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseDraftResponse response from the API call.</returns>
        public async Task<Models.ExerciseDraftResponse> ExerciseDraftFormatAsync(
                Models.ExerciseDraftDTO body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseDraftResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercise-draft")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ExerciseDraft400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise not found", (_reason, _context) => new ExerciseDraft404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}