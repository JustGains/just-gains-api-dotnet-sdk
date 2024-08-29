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
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Exceptions;
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace JustGainsAPI.Standard.Controllers
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
        /// Create / Update an existing exercise with the ExerciseDraft format EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ExerciseResponse response from the API call.</returns>
        public Models.ExerciseResponse CreateUpdateAnExistingExerciseWithTheExerciseDraftFormat(
                Models.ExerciseDraftDTO body)
            => CoreHelper.RunTask(CreateUpdateAnExistingExerciseWithTheExerciseDraftFormatAsync(body));

        /// <summary>
        /// Create / Update an existing exercise with the ExerciseDraft format EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ExerciseResponse response from the API call.</returns>
        public async Task<Models.ExerciseResponse> CreateUpdateAnExistingExerciseWithTheExerciseDraftFormatAsync(
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