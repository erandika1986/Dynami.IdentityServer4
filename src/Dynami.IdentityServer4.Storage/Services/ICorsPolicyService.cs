using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynami.IdentityServer4.Services
{
    public interface ICorsPolicyService
    {
        Task<bool> IsOriginAllowedAsync(string origin);
    }
}
