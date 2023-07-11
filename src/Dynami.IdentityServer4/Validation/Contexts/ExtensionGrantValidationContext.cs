﻿
using Dynami.IdentityServer4.Models;

namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Class describing the extension grant validation context
    /// </summary>
    public class ExtensionGrantValidationContext
    {
        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>
        /// The request.
        /// </value>
        public ValidatedTokenRequest Request { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public GrantValidationResult Result { get; set; } = new GrantValidationResult(TokenRequestErrors.InvalidGrant);
    }
}