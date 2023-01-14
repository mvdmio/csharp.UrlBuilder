using FluentAssertions;

namespace mvdmio.csharp.UrlBuilder.Tests;

[TestClass]
public class UrlParserTests
{
   [TestMethod]
   public void ShouldInitializeWithSimpleUrl()
   {
      var url = Url.Parse("http://www.simple.com");

      url.Protocol.Should().Be("http");
      url.Host.Should().Be("www.simple.com");
      url.Path.Should().Be(string.Empty);
      url.Query.Should().Be(string.Empty);
      url.ToString().Should().Be("http://www.simple.com");
   }
}