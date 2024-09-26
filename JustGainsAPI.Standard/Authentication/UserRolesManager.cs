// <copyright file="UserRolesManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JustGainsAPI.Standard.Http.Request;
using APIMatic.Core.Authentication;

namespace JustGainsAPI.Standard.Authentication
{
    /// <summary>
    /// UserRolesManager Class.
    /// </summary>
    internal class UserRolesManager : AuthManager, IUserRolesCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRolesManager"/> class.
        /// </summary>
        /// <param name="userRoles">UserRoles.</param>
        public UserRolesManager(UserRolesModel userRolesModel)
        {
            XUserRole = userRolesModel?.XUserRole;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("X-User-Role", XUserRole).Required())
            );
        }

        /// <summary>
        /// Gets string value for xUserRole.
        /// </summary>
        public string XUserRole { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="xUserRole"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string xUserRole)
        {
            return xUserRole.Equals(this.XUserRole);
        }
    }

    public sealed class UserRolesModel
    {
        internal UserRolesModel()
        {
        }

        internal string XUserRole { get; set; }

        /// <summary>
        /// Creates an object of the UserRolesModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(XUserRole);
        }

        /// <summary>
        /// Builder class for UserRolesModel.
        /// </summary>
        public class Builder
        {
            private string xUserRole;

            public Builder(string xUserRole)
            {
                this.xUserRole = xUserRole ?? throw new ArgumentNullException(nameof(xUserRole));
            }

            /// <summary>
            /// Sets XUserRole.
            /// </summary>
            /// <param name="xUserRole">XUserRole.</param>
            /// <returns>Builder.</returns>
            public Builder XUserRole(string xUserRole)
            {
                this.xUserRole = xUserRole ?? throw new ArgumentNullException(nameof(xUserRole));
                return this;
            }


            /// <summary>
            /// Creates an object of the UserRolesModel using the values provided for the builder.
            /// </summary>
            /// <returns>UserRolesModel.</returns>
            public UserRolesModel Build()
            {
                return new UserRolesModel()
                {
                    XUserRole = this.xUserRole
                };
            }
        }
    }
    
}