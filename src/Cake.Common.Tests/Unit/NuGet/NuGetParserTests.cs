using Cake.Common.Tests.Fixtures;
using Cake.Common.Tests.Properties;
using Xunit;

namespace Cake.Common.Tests.Unit.NuGet
{
    public sealed class NuGetParserTests
    {
        [Fact]
        public void Should_Parse_NuSpec()
        {
            // Given
            var fixture = new NuSpecParserFixture();
            fixture.Xml = Resources.Nuspec_Metadata_WithDependencies;

            // When
            var result = fixture.Parse();

            // Then
            Assert.Equal("The ID", result.Id);
        }
    }
}
