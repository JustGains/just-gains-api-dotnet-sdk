// <copyright file="IUserRolesCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;

namespace JustGainsAPI.Standard.Authentication
{
    /// <summary>
    /// Authentication configuration interface for UserRoles.
    /// </summary>
    public interface IUserRolesCredentials
    {
        /// <summary>
        /// Gets string value for xUserRole.
        /// </summary>
        string XUserRole { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="xUserRole"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string xUserRole);
    }
}