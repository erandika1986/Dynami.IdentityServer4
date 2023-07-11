
using Dynami.IdentityServer4.Models;
using System.Collections.Specialized;

namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Interface for the introspection request validator
    /// </summary>
    public interface IIntrospectionRequestValidator
    {
        /// <summary>
        /// Validates the request.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <param name="api">The API.</param>
        /// <returns></returns>
        Task<IntrospectionRequestValidationResult> ValidateAsync(NameValueCollection parameters, ApiResource api);
    }
}