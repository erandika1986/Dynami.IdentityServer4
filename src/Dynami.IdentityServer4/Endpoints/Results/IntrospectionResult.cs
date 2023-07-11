using Dynami.IdentityServer4.Extensions;
using Dynami.IdentityServer4.Hosting;
using Microsoft.AspNetCore.Http;

namespace Dynami.IdentityServer4.Endpoints.Results
{
    /// <summary>
    /// Result for introspection
    /// </summary>
    /// <seealso cref="Dynami.IdentityServer4.Hosting.IEndpointResult" />
    public class IntrospectionResult : IEndpointResult
    {
        /// <summary>
        /// Gets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public Dictionary<string, object> Entries { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntrospectionResult"/> class.
        /// </summary>
        /// <param name="entries">The result.</param>
        /// <exception cref="System.ArgumentNullException">result</exception>
        public IntrospectionResult(Dictionary<string, object> entries)
        {
            Entries = entries ?? throw new ArgumentNullException(nameof(entries));
        }

        /// <summary>
        /// Executes the result.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns></returns>
        public Task ExecuteAsync(HttpContext context)
        {
            context.Response.SetNoCache();
            
            return context.Response.WriteJsonAsync(Entries);
        }
    }
}