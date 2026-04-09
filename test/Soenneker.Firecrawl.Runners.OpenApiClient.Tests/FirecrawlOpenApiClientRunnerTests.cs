using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Firecrawl.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class FirecrawlOpenApiClientRunnerTests : FixturedUnitTest
{
    public FirecrawlOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
