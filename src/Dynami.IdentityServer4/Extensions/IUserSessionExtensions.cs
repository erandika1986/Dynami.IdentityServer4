
using Dynami.IdentityServer4.Extensions;
using Dynami.IdentityServer4.Models;

namespace Dynami.IdentityServer4.Services
{
    /// <summary>
    /// Extension for IUserSession.
    /// </summary>
    public static class IUserSessionExtensions
    {
        /// <summary>
        /// Creates a LogoutNotificationContext for the current user session.
        /// </summary>
        /// <returns></returns>
        public static async Task<LogoutNotificationContext> GetLogoutNotificationContext(this IUserSession session)
        {
            var clientIds = await session.GetClientListAsync();

            if (clientIds.Any())
            {
                var user = await session.GetUserAsync();
                var sub = user.GetSubjectId();
                var sid = await session.GetSessionIdAsync();

                return new LogoutNotificationContext
                {
                    SubjectId = sub,
                    SessionId = sid,
                    ClientIds = clientIds
                };
            }

            return null;
        }
    }
}