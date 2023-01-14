using System.Text;

namespace mvdmio.csharp.UrlBuilder
{
   public enum UrlProtocol
   {
      Undefined = 0,
      Http = 1,
      Https = 2
   }

   public class Url
   {
      public UrlProtocol Protocol { get; private set; }
      public string Host { get; private set; }
      public string Path { get; private set; }
      public string Query { get; private set; }

      public Url()
      {
         Protocol = UrlProtocol.Undefined;
         Host = "";
         Path = "";
         Query = "";
      }

      public static Url Parse(string input)
      {
         if (input is null)
            throw new ArgumentNullException(nameof(input));

         if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException("Input cannot be empty", nameof(input));

         var sanitizedInput = input.Trim(' ', '\r', '\n');

         var result = new Url();

         var uri = new Uri(sanitizedInput);
         
         result.Protocol = uri.Scheme switch {
            "http" => UrlProtocol.Http,
            "https" => UrlProtocol.Https,
            _ => UrlProtocol.Undefined
         };

         result.Host = uri.Host;
         result.Path = uri.AbsolutePath.Trim('/');
         result.Query = uri.Query;

         return result;
      }

      public override string ToString()
      {
         var stringBuilder = new StringBuilder();

         if (Protocol != UrlProtocol.Undefined)
            stringBuilder.Append($"{Protocol.ToString().ToLower()}://");

         if (Host.Length > 0)
            stringBuilder.Append($"{Host}");

         if (Path.Length > 0)
            stringBuilder.Append($"/{Path}");

         if (Query.Length > 0)
            stringBuilder.Append($"{Query}");

         return stringBuilder.ToString();
      }
   }
}