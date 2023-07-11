
#pragma warning disable 1591

namespace Dynami.IdentityServer4.EntityFramework.Entities
{
    public class ApiResourceClaim : UserClaim
    {
        public int ApiResourceId { get; set; }
        public ApiResource ApiResource { get; set; }
    }
}