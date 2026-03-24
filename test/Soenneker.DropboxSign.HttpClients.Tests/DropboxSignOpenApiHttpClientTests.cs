using Soenneker.DropboxSign.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.DropboxSign.HttpClients.Tests;

[Collection("Collection")]
public sealed class DropboxSignOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IDropboxSignOpenApiHttpClient _httpclient;

    public DropboxSignOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IDropboxSignOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
