
#pragma warning disable 1591

namespace Dynami.IdentityServer4.EntityFramework.Entities
{
    public class ApiScopeProperty : Property
    {
        public int ScopeId { get; set; }
        public ApiScope Scope { get; set; }
    }
}