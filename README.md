[![](https://img.shields.io/nuget/v/soenneker.dropboxsign.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dropboxsign.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dropboxsign.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dropboxsign.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dropboxsign.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dropboxsign.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dropboxsign.httpclients/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dropboxsign.httpclients/actions/workflows/codeql.yml)

# Soenneker.DropboxSign.HttpClients

Provides a cached `HttpClient` configured for Dropbox Sign's API with API-key Basic authentication.

## Installation

```bash
dotnet add package Soenneker.DropboxSign.HttpClients
```

## Configuration

```json
{
  "DropboxSign": {
    "ApiKey": "your-api-key"
  }
}
```

The provider targets `https://api.hellosign.com/v3` and sends the API key as the Basic-auth username with an empty password. For an OAuth access token, set `DropboxSign:AuthHeaderValueTemplate` to `Bearer {token}`. `DropboxSign:ClientBaseUrl` and `DropboxSign:AuthHeaderName` can override the endpoint and header name.

## Registration and usage

```csharp
using Soenneker.DropboxSign.HttpClients.Abstract;
using Soenneker.DropboxSign.HttpClients.Registrars;

services.AddDropboxSignOpenApiHttpClientAsSingleton();

public sealed class DropboxSignAccountReader(IDropboxSignOpenApiHttpClient clients)
{
    public async Task<HttpResponseMessage> Get(CancellationToken cancellationToken)
    {
        HttpClient client = await clients.Get(cancellationToken);
        return await client.GetAsync("/account", cancellationToken);
    }
}
```

The provider owns the returned client. Singleton registration keeps one client for the application lifetime; scoped registration creates a separately owned cache entry per scope.
