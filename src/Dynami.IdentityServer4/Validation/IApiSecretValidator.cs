using Microsoft.AspNetCore.Http;

namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Validator for handling API client authentication.
    /// </summary>
    public interface IApiSecretValidator
    {
        /// <summary>
        /// Tries to authenticate an API client based on the incoming request
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        Task<ApiSecretValidationResult> ValidateAsync(HttpContext context);
    }
}