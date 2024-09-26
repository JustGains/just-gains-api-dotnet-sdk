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
using JustGainsAPI.Standard;
using JustGainsAPI.Standard.Exceptions;
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace JustGainsAPI.Standard.Controllers
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
        /// <returns>Returns the string response from the API call.</returns>
        public string CheckServerAlive()
            => CoreHelper.RunTask(CheckServerAliveAsync());

        /// <summary>
        /// Returns a simple message to indicate that the API is working.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the string response from the API call.</returns>
        public async Task<string> CheckServerAliveAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new ApiException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not found", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a JSON response simulating an unauthorized access attempt.
        /// </summary>
        public void TestUnauthorized()
            => CoreHelper.RunVoidTask(TestUnauthorizedAsync());

        /// <summary>
        /// Returns a JSON response simulating an unauthorized access attempt.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task TestUnauthorizedAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/test/unauthorized"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized response", (_reason, _context) => new JustGainsResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}