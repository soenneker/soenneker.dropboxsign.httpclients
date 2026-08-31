using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.DropboxSign.HttpClients.Abstract;

/// <summary>
/// Provides a cached, authenticated <see cref="HttpClient"/> for Dropbox Sign's API.
/// </summary>
public interface IDropboxSignOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the client owned by this provider.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The configured Dropbox Sign client.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
