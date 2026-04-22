using Soenneker.Tests.HostedUnit;

namespace Soenneker.Firecrawl.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class FirecrawlOpenApiClientRunnerTests : HostedUnitTest
{
    public FirecrawlOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
