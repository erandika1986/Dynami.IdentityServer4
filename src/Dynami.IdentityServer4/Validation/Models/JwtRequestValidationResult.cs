namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Models the result of JWT request validation.
    /// </summary>
    public class JwtRequestValidationResult : ValidationResult
    {
        /// <summary>
        /// The key/value pairs from the JWT payload of a successfuly validated request.
        /// </summary>
        public Dictionary<string, string> Payload { get; set; }
    }
}