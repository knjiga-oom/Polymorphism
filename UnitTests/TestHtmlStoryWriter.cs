using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Polymorhism
{
    [TestClass]
    public class TestHtmlStoryWriter
    {
        [TestMethod]
        public void Heading1ContainsCaptionWithH1Tags()
        {
            using (StringWriter writer = new StringWriter())
            {
                StoryWriter sw = new StoryWriter(writer);
                sw.WriteHeading("Title", 1);

                Assert.AreEqual("<h1>Title</h1>", writer.ToString(), true);
            }
        }

        [TestMethod]
        public void Heading2ContainsCaptionWithH2Tags()
        {
            using (StringWriter writer = new StringWriter())
            {
                StoryWriter sw = new StoryWriter(writer);
                sw.WriteHeading("Title", 2);

                Assert.AreEqual("<h2>Title</h2>", writer.ToString(), true);
            }
        }

        [TestMethod]
        public void ParagraphContainsTextWithPTags()
        {
            using (StringWriter writer = new StringWriter())
            {
                StoryWriter sw = new StoryWriter(writer);
                sw.WriteParagraph("This is a paragraph");

                Assert.AreEqual("<p>This is a paragraph</p>", writer.ToString(), true);
            }
        }

        [TestMethod]
        public void HyperlinkContainsCaptionEncloseWithHrefTag()
        {
            using (StringWriter writer = new StringWriter())
            {
                StoryWriter sw = new StoryWriter(writer);
                sw.WriteHyperlink("Caption", "link");

                Assert.AreEqual("<a href=\"link\">Caption</a>", writer.ToString(), true);
            }
        }
    }
}
