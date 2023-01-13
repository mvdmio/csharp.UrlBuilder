using System.Text.RegularExpressions;

namespace mvdmio.csharp.UrlBuilder
{
   public class Url
   {
      public string Protocol { get; }
      public string Host { get; }
      public string Path { get; }
      public string Query { get; }

      public Url()
         : this(string.Empty)
      {
         Host = "";
         Protocol = "";
         Path = "";
         Query = "";
      }

      public Url(string url)
      {
         // TODO
         //var urlRegex = "(http|https)://(.*)/(.*)?(.*)";
         //var match = Regex.Match(url, urlRegex);

         //var indexOfProtocolSeparator = url.IndexOf("://", StringComparison.Ordinal);

         //if (indexOfProtocolSeparator > 0)
         //   Protocol = url[..url.IndexOf("://", StringComparison.Ordinal)];

         //var indexOfPathStart = url.IndexOf("/")

         //Host = url[indexOfProtocolSeparator..]
      }
   }
}