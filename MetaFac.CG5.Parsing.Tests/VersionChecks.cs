using FluentAssertions;
using Xunit;

namespace MetaFac.CG5.Parsing.Tests
{
    public class VersionChecks
    {
        [Fact]
        public void VersionCheck()
        {
            typeof(Combinators).Assembly.FullName.Should().StartWith("MetaFac.CG5.Parsing, Version=1.0.");
        }
    }
}
