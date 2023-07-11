
using Dynami.IdentityServer4.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Validator for an Enumerable List of Secrets
    /// </summary>
    public interface ISecretsListValidator
    {
        /// <summary>
        /// Validates a list of secrets
        /// </summary>
        /// <param name="secrets">The stored secrets.</param>
        /// <param name="parsedSecret">The received secret.</param>
        /// <returns>A validation result</returns>
        Task<SecretValidationResult> ValidateAsync(IEnumerable<Secret> secrets, ParsedSecret parsedSecret);
    }
}
