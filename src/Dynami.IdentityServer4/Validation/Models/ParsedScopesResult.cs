namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Represents the result of scope parsing.
    /// </summary>
    public class ParsedScopesResult
    {
        /// <summary>
        /// The valid parsed scopes.
        /// </summary>
        public ICollection<ParsedScopeValue> ParsedScopes { get; set; } = new HashSet<ParsedScopeValue>();

        /// <summary>
        /// The errors encountered while parsing.
        /// </summary>
        public ICollection<ParsedScopeValidationError> Errors { get; set; } = new HashSet<ParsedScopeValidationError>();

        /// <summary>
        /// Indicates if the result of parsing the scopes was successful.
        /// </summary>
        public bool Succeeded => Errors == null || !Errors.Any();
    }
}