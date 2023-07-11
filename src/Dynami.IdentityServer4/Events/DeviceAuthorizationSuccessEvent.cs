
using Dynami.IdentityServer4.Extensions;
using Dynami.IdentityServer4.ResponseHandling;
using Dynami.IdentityServer4.Validation;

namespace Dynami.IdentityServer4.Events
{
    /// <summary>
    /// Event for device authorization failure
    /// </summary>
    /// <seealso cref="Dynami.IdentityServer4.Events.Event" />
    public class DeviceAuthorizationSuccessEvent : Event
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAuthorizationSuccessEvent"/> class.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="request">The request.</param>
        public DeviceAuthorizationSuccessEvent(DeviceAuthorizationResponse response, DeviceAuthorizationRequestValidationResult request)
            : this()
        {
            ClientId = request.ValidatedRequest.Client?.ClientId;
            ClientName = request.ValidatedRequest.Client?.ClientName;
            Endpoint = Constants.EndpointNames.DeviceAuthorization;
            Scopes = request.ValidatedRequest.ValidatedResources?.RawScopeValues.ToSpaceSeparatedString();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAuthorizationSuccessEvent"/> class.
        /// </summary>
        protected DeviceAuthorizationSuccessEvent()
            : base(EventCategories.DeviceFlow,
                "Device Authorization Success",
                EventTypes.Success,
                EventIds.DeviceAuthorizationSuccess)
        {
        }


        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>
        /// The client identifier.
        /// </value>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        /// <value>
        /// The name of the client.
        /// </value>
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the endpoint.
        /// </summary>
        /// <value>
        /// The endpoint.
        /// </value>
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the scopes.
        /// </summary>
        /// <value>
        /// The scopes.
        /// </value>
        public string Scopes { get; set; }
    }
}