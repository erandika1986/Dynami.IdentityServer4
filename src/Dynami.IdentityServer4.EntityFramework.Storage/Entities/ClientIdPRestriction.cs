﻿
#pragma warning disable 1591

namespace Dynami.IdentityServer4.EntityFramework.Entities
{
    public class ClientIdPRestriction
    {
        public int Id { get; set; }
        public string Provider { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}