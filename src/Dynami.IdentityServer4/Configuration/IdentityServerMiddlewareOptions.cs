﻿namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// Options for the IdentityServer middleware
    /// </summary>
    public class IdentityServerMiddlewareOptions
    {
        /// <summary>
        /// Callback to wire up an authentication middleware
        /// </summary>
        public Action<IApplicationBuilder> AuthenticationMiddleware { get; set; } = (app) => app.UseAuthentication();
    }
}