namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Allows inserting custom validation logic into token requests
    /// </summary>
    public interface ICustomTokenRequestValidator
    {
        /// <summary>
        /// Custom validation logic for a token request.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        /// The validation result
        /// </returns>
        Task ValidateAsync(CustomTokenRequestValidationContext context);
    }
}