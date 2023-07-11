
using Dynami.IdentityServer4.Endpoints.Results;
using Dynami.IdentityServer4.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace Dynami.IdentityServer4.Endpoints
{
    internal class CheckSessionEndpoint : IEndpointHandler
    {
        private readonly ILogger _logger;

        public CheckSessionEndpoint(ILogger<CheckSessionEndpoint> logger)
        {
            _logger = logger;
        }

        public Task<IEndpointResult> ProcessAsync(HttpContext context)
        {
            IEndpointResult result;

            if (!HttpMethods.IsGet(context.Request.Method))
            {
                _logger.LogWarning("Invalid HTTP method for check session endpoint");
                result = new StatusCodeResult(HttpStatusCode.MethodNotAllowed);
            }
            else
            {
                _logger.LogDebug("Rendering check session result");
                result = new CheckSessionResult();
            }

            return Task.FromResult(result);
        }
   }
}