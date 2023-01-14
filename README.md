# csharp.UrlBuilder
C# library for building URLs

# API
Create a new URL using `new Url()`

Parse an existing URL using `Url.Parse("https://some.existing.url");`

Get or set URL parts:
``` csharp
var url = new Url();
url.Protocol = UrlProtocol.Https;
url.Host = "some.host.com";
url.Path = "/some/path.php"
url.Query.Add("param1", "someValue")
url.Query.Add("param2", "anotherValue")

var result = url.ToString(); // Result: https://some.host.com/some/path?param1=someValue&param2=anotherValue
```