using Dynami.IdentityServer4.Validation;

namespace Dynami.IdentityServer4.ResponseHandling
{
    /// <summary>
    /// Interface the token response generator
    /// </summary>
    public interface ITokenResponseGenerator
    {
        /// <summary>
        /// Processes the response.
        /// </summary>
        /// <param name="validationResult">The validation result.</param>
        /// <returns></returns>
        Task<TokenResponse> ProcessAsync(TokenRequestValidationResult validationResult);
    }
}