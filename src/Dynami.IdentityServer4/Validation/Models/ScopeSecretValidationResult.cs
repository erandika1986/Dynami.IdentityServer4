
using Dynami.IdentityServer4.Models;

namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Validation result for API validation
    /// </summary>
    public class ApiSecretValidationResult : ValidationResult
    {
        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        /// <value>
        /// The resource.
        /// </value>
        public ApiResource Resource { get; set; }
    }
}