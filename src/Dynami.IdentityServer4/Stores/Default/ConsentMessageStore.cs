﻿
using Dynami.IdentityServer4.Models;

namespace Dynami.IdentityServer4.Stores
{
    internal class ConsentMessageStore : IConsentMessageStore
    {
        protected readonly MessageCookie<ConsentResponse> Cookie;

        public ConsentMessageStore(MessageCookie<ConsentResponse> cookie)
        {
            Cookie = cookie;
        }

        public virtual Task DeleteAsync(string id)
        {
            Cookie.Clear(id);
            return Task.CompletedTask;
        }

        public virtual Task<Message<ConsentResponse>> ReadAsync(string id)
        {
            return Task.FromResult(Cookie.Read(id));
        }

        public virtual Task WriteAsync(string id, Message<ConsentResponse> message)
        {
            Cookie.Write(id, message);
            return Task.CompletedTask;
        }
    }
}
