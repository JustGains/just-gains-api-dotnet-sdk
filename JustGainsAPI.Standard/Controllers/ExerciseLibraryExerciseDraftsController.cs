// <copyright file="ExerciseLibraryExerciseDraftsController.cs" company="APIMatic">
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
    /// ExerciseLibraryExerciseDraftsController.
    /// </summary>
    public class ExerciseLibraryExerciseDraftsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExerciseLibraryExerciseDraftsController"/> class.
        /// </summary>
        internal ExerciseLibraryExerciseDraftsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create/Update an exercise with ExerciseDraftDTO EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseResponse response from the API call.</returns>
        public Models.ExerciseResponse CreateUpdateAnExerciseWithExerciseDraftDTO(
                Models.ExerciseDraftDTO body)
            => CoreHelper.RunTask(CreateUpdateAnExerciseWithExerciseDraftDTOAsync(body));

        /// <summary>
        /// Create/Update an exercise with ExerciseDraftDTO EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseResponse response from the API call.</returns>
        public async Task<Models.ExerciseResponse> CreateUpdateAnExerciseWithExerciseDraftDTOAsync(
                Models.ExerciseDraftDTO body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ExerciseResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/exercise-draft")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Exercise not found", (_reason, _context) => new JustGainsErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}