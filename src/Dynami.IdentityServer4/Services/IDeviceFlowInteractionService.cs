using Dynami.IdentityServer4.Models;

namespace Dynami.IdentityServer4.Services
{
    /// <summary>
    ///  Provide services be used by the user interface to communicate with IdentityServer.
    /// </summary>
    public interface IDeviceFlowInteractionService
    {
        /// <summary>
        /// Gets the authorization context asynchronous.
        /// </summary>
        /// <param name="userCode">The user code.</param>
        /// <returns></returns>
        Task<DeviceFlowAuthorizationRequest> GetAuthorizationContextAsync(string userCode);

        /// <summary>
        /// Handles the request asynchronous.
        /// </summary>
        /// <param name="userCode">The user code.</param>
        /// <param name="consent">The consent.</param>
        /// <returns></returns>
        Task<DeviceFlowInteractionResult> HandleRequestAsync(string userCode, ConsentResponse consent);
    }
}