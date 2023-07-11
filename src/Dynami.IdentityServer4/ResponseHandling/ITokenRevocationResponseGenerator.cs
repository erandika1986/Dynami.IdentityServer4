using Dynami.IdentityServer4.Validation;

namespace Dynami.IdentityServer4.ResponseHandling
{
    /// <summary>
    /// Interface for the userinfo response generator
    /// </summary>
    public interface ITokenRevocationResponseGenerator
    {
        /// <summary>
        /// Creates the revocation endpoint response and processes the revocation request.
        /// </summary>
        /// <param name="validationResult">The userinfo request validation result.</param>
        /// <returns></returns>
        Task<TokenRevocationResponse> ProcessAsync(TokenRevocationRequestValidationResult validationResult);
    }
}