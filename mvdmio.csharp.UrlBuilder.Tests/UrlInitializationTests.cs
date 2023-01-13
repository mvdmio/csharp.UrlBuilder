using FluentAssertions;

namespace mvdmio.csharp.UrlBuilder.Tests
{
   [TestClass]
   public class UrlInitializationTests
   {
      [TestMethod]
      public void ShouldSupportEmptyInitialization()
      {
         var url = new Url();

         url.Protocol.Should().Be(string.Empty);
         url.Host.Should().Be(string.Empty);
         url.Path.Should().Be(string.Empty);
         url.Query.Should().Be(string.Empty);
         url.ToString().Should().Be(string.Empty);
      }

      [TestMethod]
      public void ShouldInitializeWithSimpleUrl()
      {
         var url = new Url("http://www.simple.com");

         url.Protocol.Should().Be("http");
         url.Host.Should().Be("www.simple.com");
         url.Path.Should().Be(string.Empty);
         url.Query.Should().Be(string.Empty);
         url.ToString().Should().Be("http://www.simple.com");
      }
   }
}