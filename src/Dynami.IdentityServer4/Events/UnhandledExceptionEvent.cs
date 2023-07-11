﻿namespace Dynami.IdentityServer4.Events
{
    /// <summary>
    /// Event for unhandled exceptions
    /// </summary>
    /// <seealso cref="Dynami.IdentityServer4.Events.Event" />
    public class UnhandledExceptionEvent : Event
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnhandledExceptionEvent"/> class.
        /// </summary>
        /// <param name="ex">The ex.</param>
        public UnhandledExceptionEvent(Exception ex)
            : base(EventCategories.Error,
                  "Unhandled Exception",
                  EventTypes.Error, 
                  EventIds.UnhandledException,
                  ex.Message)
        {
            Details = ex.ToString();
        }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        /// <value>
        /// The details.
        /// </value>
        public string Details { get; set; }
    }
}