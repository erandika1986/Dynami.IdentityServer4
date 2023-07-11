
using Dynami.IdentityServer4.Models;

namespace Dynami.IdentityServer4.Validation
{
    /// <summary>
    /// Validation result for client validation
    /// </summary>
    public class ClientSecretValidationResult : ValidationResult
    {
        /// <summary>
        /// Gets or sets the client.
        /// </summary>
        /// <value>
        /// The client.
        /// </value>
        public Client Client { get; set; }

        /// <summary>
        /// Gets or sets the secret used to authenticate the client.
        /// </summary>
        /// <value>
        /// The secret.
        /// </value>
        public ParsedSecret Secret { get; set; }

        /// <summary>
        /// Gets or sets the value of the confirmation method (will become the cnf claim). Must be a JSON object.
        /// </summary>
        /// <value>
        /// The confirmation.
        /// </value>
        public string Confirmation { get; set; }
    }
}