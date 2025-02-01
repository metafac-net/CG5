using Shouldly;
using Xunit;

namespace MetaFac.CG5.Parsing.Tests
{
    public class VersionChecks
    {
        [Fact]
        public void VersionCheck()
        {
            typeof(Combinators).Assembly.FullName.ShouldStartWith("MetaFac.CG5.Parsing, Version=1.0.");
        }
    }
}
