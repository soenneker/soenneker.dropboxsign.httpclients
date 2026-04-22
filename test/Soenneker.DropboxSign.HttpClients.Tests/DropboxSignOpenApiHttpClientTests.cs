using Soenneker.DropboxSign.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.DropboxSign.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class DropboxSignOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IDropboxSignOpenApiHttpClient _httpclient;

    public DropboxSignOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IDropboxSignOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
