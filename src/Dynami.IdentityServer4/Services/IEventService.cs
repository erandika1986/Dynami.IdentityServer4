﻿

using Dynami.IdentityServer4.Events;

namespace Dynami.IdentityServer4.Services
{
    /// <summary>
    /// Interface for the event service
    /// </summary>
    public interface IEventService
    {
        /// <summary>
        /// Raises the specified event.
        /// </summary>
        /// <param name="evt">The event.</param>
        Task RaiseAsync(Event evt);

        /// <summary>
        /// Indicates if the type of event will be persisted.
        /// </summary>
        bool CanRaiseEventType(EventTypes evtType);
    }
}