using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.DropboxSign.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.DropboxSign.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class DropboxSignOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="DropboxSignOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddDropboxSignOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IDropboxSignOpenApiHttpClient, DropboxSignOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="DropboxSignOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddDropboxSignOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IDropboxSignOpenApiHttpClient, DropboxSignOpenApiHttpClient>();

        return services;
    }
}
