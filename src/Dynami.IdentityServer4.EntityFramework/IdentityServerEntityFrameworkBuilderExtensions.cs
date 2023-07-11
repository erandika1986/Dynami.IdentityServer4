﻿using Dynami.IdentityServer4.EntityFramework.DbContexts;
using Dynami.IdentityServer4.EntityFramework.Interfaces;
using Dynami.IdentityServer4.EntityFramework.Options;
using Dynami.IdentityServer4.EntityFramework.Services;
using Dynami.IdentityServer4.EntityFramework.Storage;
using Dynami.IdentityServer4.EntityFramework.Stores;
using Dynami.IdentityServer4.Stores;
using IdentityServer4.EntityFramework.Stores;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Dynami.IdentityServer4.EntityFramework
{
    namespace Microsoft.Extensions.DependencyInjection
    {
        /// <summary>
        /// Extension methods to add EF database support to IdentityServer.
        /// </summary>
        public static class IdentityServerEntityFrameworkBuilderExtensions
        {
            /// <summary>
            /// Configures EF implementation of IClientStore, IResourceStore, and ICorsPolicyService with IdentityServer.
            /// </summary>
            /// <param name="builder">The builder.</param>
            /// <param name="storeOptionsAction">The store options action.</param>
            /// <returns></returns>
            public static IIdentityServerBuilder AddConfigurationStore(
                this IIdentityServerBuilder builder,
                Action<ConfigurationStoreOptions> storeOptionsAction = null)
            {
                return builder.AddConfigurationStore<ConfigurationDbContext>(storeOptionsAction);
            }

            /// <summary>
            /// Configures EF implementation of IClientStore, IResourceStore, and ICorsPolicyService with IdentityServer.
            /// </summary>
            /// <typeparam name="TContext">The IConfigurationDbContext to use.</typeparam>
            /// <param name="builder">The builder.</param>
            /// <param name="storeOptionsAction">The store options action.</param>
            /// <returns></returns>
            public static IIdentityServerBuilder AddConfigurationStore<TContext>(
                this IIdentityServerBuilder builder,
                Action<ConfigurationStoreOptions> storeOptionsAction = null)
                where TContext : DbContext, IConfigurationDbContext
            {
                builder.Services.AddConfigurationDbContext<TContext>(storeOptionsAction);

                builder.AddClientStore<ClientStore>();
                builder.AddResourceStore<ResourceStore>();
                builder.AddCorsPolicyService<CorsPolicyService>();

                return builder;
            }

            /// <summary>
            /// Configures caching for IClientStore, IResourceStore, and ICorsPolicyService with IdentityServer.
            /// </summary>
            /// <param name="builder">The builder.</param>
            /// <returns></returns>
            public static IIdentityServerBuilder AddConfigurationStoreCache(
                this IIdentityServerBuilder builder)
            {
                builder.AddInMemoryCaching();

                // add the caching decorators
                builder.AddClientStoreCache<ClientStore>();
                builder.AddResourceStoreCache<ResourceStore>();
                builder.AddCorsPolicyCache<CorsPolicyService>();

                return builder;
            }

            /// <summary>
            /// Configures EF implementation of IPersistedGrantStore with IdentityServer.
            /// </summary>
            /// <param name="builder">The builder.</param>
            /// <param name="storeOptionsAction">The store options action.</param>
            /// <returns></returns>
            public static IIdentityServerBuilder AddOperationalStore(
                this IIdentityServerBuilder builder,
                Action<OperationalStoreOptions> storeOptionsAction = null)
            {
                return builder.AddOperationalStore<PersistedGrantDbContext>(storeOptionsAction);
            }

            /// <summary>
            /// Configures EF implementation of IPersistedGrantStore with IdentityServer.
            /// </summary>
            /// <typeparam name="TContext">The IPersistedGrantDbContext to use.</typeparam>
            /// <param name="builder">The builder.</param>
            /// <param name="storeOptionsAction">The store options action.</param>
            /// <returns></returns>
            public static IIdentityServerBuilder AddOperationalStore<TContext>(
                this IIdentityServerBuilder builder,
                Action<OperationalStoreOptions> storeOptionsAction = null)
                where TContext : DbContext, IPersistedGrantDbContext
            {
                builder.Services.AddOperationalDbContext<TContext>(storeOptionsAction);

                builder.Services.AddTransient<IPersistedGrantStore, PersistedGrantStore>();
                builder.Services.AddTransient<IDeviceFlowStore, DeviceFlowStore>();
                builder.Services.AddSingleton<IHostedService, TokenCleanupHost>();

                return builder;
            }

            /// <summary>
            /// Adds an implementation of the IOperationalStoreNotification to IdentityServer.
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="builder"></param>
            /// <returns></returns>
            public static IIdentityServerBuilder AddOperationalStoreNotification<T>(
               this IIdentityServerBuilder builder)
               where T : class, IOperationalStoreNotification
            {
                builder.Services.AddOperationalStoreNotification<T>();
                return builder;
            }
        }
    }
}
