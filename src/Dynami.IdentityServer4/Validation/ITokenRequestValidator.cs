
using System.Collections.Specialized;

namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Interface for the token request validator
    /// </summary>
    public interface ITokenRequestValidator
    {
        /// <summary>
        /// Validates the request.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <param name="clientValidationResult">The client validation result.</param>
        /// <returns></returns>
        Task<TokenRequestValidationResult> ValidateRequestAsync(NameValueCollection parameters, ClientSecretValidationResult clientValidationResult);
    }
}