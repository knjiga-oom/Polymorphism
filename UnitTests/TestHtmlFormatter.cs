using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Polymorhism
{
    [TestClass]
    public class TestHtmlFormatter
    {
        [TestMethod]
        public void Heading1ContainsCaptionWithH1Tags()
        {
            HtmlFormatter hf = new HtmlFormatter();
            hf.WriteHeading("Title", 1);

            Assert.AreEqual("<h1>Title</h1>", hf.ToString(), true);
        }

        [TestMethod]
        public void Heading2ContainsCaptionWithH2Tags()
        {
            HtmlFormatter hf = new HtmlFormatter();
            hf.WriteHeading("Title", 2);

            Assert.AreEqual("<h2>Title</h2>", hf.ToString(), true);
        }

        [TestMethod]
        public void ParagraphContainsTextWithPTags()
        {
            HtmlFormatter hf = new HtmlFormatter();
            hf.WriteParagraph("This is a paragraph");

            Assert.AreEqual("<p>This is a paragraph</p>", hf.ToString(), true);
        }

        [TestMethod]
        public void HyperlinkContainsCaptionEncloseWithHrefTag()
        {
            HtmlFormatter hf = new HtmlFormatter();
            hf.WriteHyperlink("Caption", "link");

            Assert.AreEqual("<a href=\"link\">Caption</a>", hf.ToString(), true);
        }
    }
}
