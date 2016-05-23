using System.IO;
using Cake.Common.NuGet;

namespace Cake.Common.Tests.Fixtures
{
    public sealed class NuSpecParserFixture
    {
        public string Xml { get; set; }

        public NuSpec Parse()
        {
            var parser = new NuSpecParser();
            return parser.Parse(GetStream(Xml));
        }

        public Stream GetStream(string xml)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(xml);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
