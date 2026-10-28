using NameplateStudio.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Tests
{
    public class SvgContentTests
    {
        [Fact]
        public void Create_ValidSVG_PreservesContent()
        {
            var svg = "<svg xmlns=\"http://www.w3.org/2000/svg\"/>";
            var result = SvgContent.Create(svg);

            Assert.True(result.IsSuccess);
            Assert.Equal(svg, result.Value?.Value);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Create_EmptyContent_ReturnsRequiredError(string? svg)
        {
            var result = SvgContent.Create(svg);

            Assert.False(result.IsSuccess);
            Assert.Equal(Errors.SvgContentRequired, result.Error);
        }

        [Theory]
        [InlineData("<svg xmlns=\"http://www.w3.org/2000/svg\">")]
        [InlineData("<svg xmlns=\"http://www.w3.org/2000/svg\"/><svg/>")]
        public void Create_InvalidXml_ReturnsInvalidXmlError(string svg)
        {
            var result = SvgContent.Create(svg);

            Assert.False(result.IsSuccess);
            Assert.Equal(Errors.SvgContentInvalidXml, result.Error);
        }

        [Theory]
        [InlineData("<html xmlns=\"http://www.w3.org/2000/svg\"/>")]
        [InlineData("<svg/>")]
        [InlineData("<svg xmlns=\"urn:other\"/>")]
        public void Create_InvalidRoot_ReturnsInvalidRootError(string svg)
        {
            var result = SvgContent.Create(svg);

            Assert.False(result.IsSuccess);
            Assert.Equal(Errors.SvgContentInvalidRoot, result.Error);
        }

        [Theory]
        [InlineData("<!DOCTYPE svg><svg xmlns=\"http://www.w3.org/2000/svg\"/>")]
        [InlineData("<!DOCTYPE svg SYSTEM \"file:///nonexistent-svg.dtd\"><svg xmlns=\"http://www.w3.org/2000/svg\"/>")]
        public void Create_Dtd_ReturnsInvalidXmlError(string svg)
        {
            var result = SvgContent.Create(svg);

            Assert.False(result.IsSuccess);
            Assert.Equal(Errors.SvgContentInvalidXml, result.Error);
        }

        [Fact]
        public void Create_PrefixedSvg_PreservesContent()
        {
            var svg = "\n<s:svg xmlns:s=\"http://www.w3.org/2000/svg\">\n  <s:path d=\"M0 0 L10 10\"/>\n</s:svg>\n";
            var result = SvgContent.Create(svg);

            Assert.True(result.IsSuccess);
            Assert.Equal(svg, result.Value?.Value);
        }
    }
}
