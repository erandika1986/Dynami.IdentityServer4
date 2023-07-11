using Dynami.IdentityServer4.Extensions;
using Dynami.IdentityServer4.Hosting;
using Microsoft.AspNetCore.Http;

namespace Dynami.IdentityServer4.Endpoints.Results
{
    internal class UserInfoResult : IEndpointResult
    {
        public Dictionary<string, object> Claims;

        public UserInfoResult(Dictionary<string, object> claims)
        {
            Claims = claims;
        }

        public async Task ExecuteAsync(HttpContext context)
        {
            context.Response.SetNoCache();
            await context.Response.WriteJsonAsync(Claims);
        }
    }
}