using System;
using System.IO;
using System.Xml;

namespace Cake.Common.NuGet
{
    internal sealed class NuSpecParser
    {
        public NuSpec Parse(Stream stream)
        {
            var document = new XmlDocument();
            document.Load(stream);
            return Parse(document);
        }

        private NuSpec Parse(XmlDocument document)
        {
            throw new NotImplementedException();
        }
    }
}
