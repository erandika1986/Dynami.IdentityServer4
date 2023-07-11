using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynami.IdentityServer4
{
    internal static class IdentityServerConstants
    {
        public static class ProtocolTypes
        {
            public const string OpenIdConnect = "oidc";
        }

        public static class SecretTypes
        {
            public const string SharedSecret = "SharedSecret";
        }
    }
}
