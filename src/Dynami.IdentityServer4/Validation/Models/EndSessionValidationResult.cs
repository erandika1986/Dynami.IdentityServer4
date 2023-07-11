
namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Validation result for end session requests
    /// </summary>
    /// <seealso cref="Dynami.IdentityServer4.Validation.ValidationResult" />
    public class EndSessionValidationResult : ValidationResult
    {
        /// <summary>
        /// Gets or sets the validated request.
        /// </summary>
        /// <value>
        /// The validated request.
        /// </value>
        public ValidatedEndSessionRequest ValidatedRequest { get; set; }
    }
}