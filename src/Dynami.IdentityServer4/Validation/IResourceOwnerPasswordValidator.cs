namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Handles validation of resource owner password credentials
    /// </summary>
    public interface IResourceOwnerPasswordValidator
    {
        /// <summary>
        /// Validates the resource owner password credential
        /// </summary>
        /// <param name="context">The context.</param>
        Task ValidateAsync(ResourceOwnerPasswordValidationContext context);
    }
}