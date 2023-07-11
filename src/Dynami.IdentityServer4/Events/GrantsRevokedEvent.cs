
namespace Dynami.IdentityServer4.Events
{
    /// <summary>
    /// Event for revoked grants.
    /// </summary>
    /// <seealso cref="Dynami.IdentityServer4.Events.Event" />
    public class GrantsRevokedEvent : Event
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantsRevokedEvent" /> class.
        /// </summary>
        /// <param name="subjectId">The subject identifier.</param>
        /// <param name="clientId">The client identifier.</param>
        public GrantsRevokedEvent(string subjectId, string clientId)
            : base(EventCategories.Grants,
                  "Grants revoked",
                  EventTypes.Information,
                  EventIds.GrantsRevoked)
        {
            SubjectId = subjectId;
            ClientId = clientId;
        }

        /// <summary>
        /// Gets or sets the subject identifier.
        /// </summary>
        /// <value>
        /// The subject identifier.
        /// </value>
        public string SubjectId { get; set; }

        /// <summary>
        /// Gets or sets the client ID.
        /// </summary>
        /// <value>
        /// The client identifier.
        /// </value>
        public string ClientId { get; set; }
    }
}