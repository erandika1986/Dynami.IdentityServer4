﻿
using Dynami.IdentityServer4.Test;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for the IdentityServer builder
    /// </summary>
    public static class IdentityServerBuilderExtensions
    {
        /// <summary>
        /// Adds test users.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="users">The users.</param>
        /// <returns></returns>
        public static IIdentityServerBuilder AddTestUsers(this IIdentityServerBuilder builder, List<TestUser> users)
        {
            builder.Services.AddSingleton(new TestUserStore(users));
            builder.AddProfileService<TestUserProfileService>();
            builder.AddResourceOwnerValidator<TestUserResourceOwnerPasswordValidator>();

            return builder;
        }
    }
}