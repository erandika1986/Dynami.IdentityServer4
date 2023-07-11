using Dynami.IdentityServer4.Stores;

namespace Dynami.IdentityServer4.Extensions
{
    public static class PersistedGrantFilterExtensions
    {
        public static void Validate(this PersistedGrantFilter filter)
        {
            if (filter == null) throw new ArgumentNullException(nameof(filter));

            if (String.IsNullOrWhiteSpace(filter.ClientId) &&
                String.IsNullOrWhiteSpace(filter.SessionId) &&
                String.IsNullOrWhiteSpace(filter.SubjectId) &&
                String.IsNullOrWhiteSpace(filter.Type))
            {
                throw new ArgumentException("No filter values set.", nameof(filter));
            }
        }
    }
}
