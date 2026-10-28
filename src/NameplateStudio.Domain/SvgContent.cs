using System;
using System.Xml;
using System.Xml.Linq;

namespace NameplateStudio.Domain
{
    public sealed record SvgContent
    {
        public string Value { get; }

        private SvgContent(string value)
        {
            Value = value;
        }

        public static Result<SvgContent> Create(string? svgContent)
        {
            if (string.IsNullOrWhiteSpace(svgContent))
                return Errors.SvgContentRequired;

            var settings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Prohibit,
                XmlResolver = null
            };

            try
            {
                using var input = new StringReader(svgContent);
                using var reader = XmlReader.Create(input, settings);
                var document = XDocument.Load(reader);

                if (document.Root?.Name != XName.Get("svg", "http://www.w3.org/2000/svg"))
                    return Errors.SvgContentInvalidRoot;
            }
            catch (XmlException)
            {
                return Errors.SvgContentInvalidXml;
            }

            return new SvgContent(svgContent);
        }
    }
}
