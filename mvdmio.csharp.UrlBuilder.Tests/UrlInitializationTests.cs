using FluentAssertions;

namespace mvdmio.csharp.UrlBuilder.Tests
{
   [TestClass]
   public class UrlBuildingTests
   {
      [TestMethod]
      public void ShouldSupportEmptyInitialization()
      {
         var url = new Url();

         url.Protocol.Should().Be(UrlProtocol.Undefined);
         url.Host.Should().Be(string.Empty);
         url.Path.Should().Be(string.Empty);
         url.Query.Should().Be(string.Empty);
         url.ToString().Should().Be(string.Empty);
      }
   }
}