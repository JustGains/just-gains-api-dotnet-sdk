// <copyright file="BaseController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core;
using APIMatic.Core.Http.Configuration;
using APIMatic.Core.Response;
using JustGainsAPI.Standard.Exceptions;
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Http.Request;
using JustGainsAPI.Standard.Http.Response;
using JustGainsAPI.Standard.Utilities;
using System;
using System.Collections.Generic;

namespace JustGainsAPI.Standard.Controllers
{
    /// <summary>
    /// The base class for all controller classes.
    /// </summary>
    public class BaseController
    {
        private readonly GlobalConfiguration globalConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController"/> class.
        /// </summary>
        internal BaseController(GlobalConfiguration config) => globalConfiguration = config;

        protected static ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException> CreateErrorCase(string reason, Func<string, HttpContext, ApiException> error, bool isErrorTemplate = false)
            => new ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>(reason, error, isErrorTemplate);

        protected ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T> CreateApiCall<T>(ArraySerialization arraySerialization = ArraySerialization.Indexed)
            => new ApiCall<HttpRequest, HttpResponse, HttpContext, ApiException, T, T>(
                globalConfiguration,
                compatibilityFactory,
                serialization: arraySerialization,
                globalErrors: globalErrors
            );

        private static readonly CompatibilityFactory compatibilityFactory = new CompatibilityFactory();
        private static readonly Dictionary<string, ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>> globalErrors = new Dictionary<string, ErrorCase<HttpRequest, HttpResponse, HttpContext, ApiException>>
        {
            { "0", CreateErrorCase("An Error Occurred", (reason, context) => new JustGainsErrorResponseException(reason, context)) }
        };
    }
}