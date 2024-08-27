// <copyright file="StatusController.cs" company="APIMatic">
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
    /// StatusController.
    /// </summary>
    public class StatusController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusController"/> class.
        /// </summary>
        internal StatusController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a simple message to indicate that the API is working.
        /// </summary>
        /// <returns>Returns the Models.Response response from the API call.</returns>
        public Models.Response CheckServerAlive()
            => CoreHelper.RunTask(CheckServerAliveAsync());

        /// <summary>
        /// Returns a simple message to indicate that the API is working.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.Response response from the API call.</returns>
        public async Task<Models.Response> CheckServerAliveAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Response>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new M400ErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found", (_reason, _context) => new M404ErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}