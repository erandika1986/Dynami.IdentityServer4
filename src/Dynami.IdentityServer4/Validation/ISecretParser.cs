﻿
using Dynami.IdentityServer4.Models;
using Microsoft.AspNetCore.Http;

namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// A service for parsing secrets found on the request
    /// </summary>
    public interface ISecretParser
    {
        /// <summary>
        /// Tries to find a secret on the context that can be used for authentication
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns>
        /// A parsed secret
        /// </returns>
        Task<ParsedSecret> ParseAsync(HttpContext context);

        /// <summary>
        /// Returns the authentication method name that this parser implements
        /// </summary>
        /// <value>
        /// The authentication method.
        /// </value>
        string AuthenticationMethod { get; }
    }
}