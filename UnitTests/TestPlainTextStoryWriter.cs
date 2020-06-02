using System;
using System.Linq;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Polymorhism
{
    [TestClass]
    public class TestPlainTextStoryWriter
    {
        [TestMethod]
        public void Heading1ContainsCaptionUnderlinedWithEqualsAndAnEmptyLine()
        {
            using (StringWriter writer = new StringWriter())
            {
                StoryWriter sw = new StoryWriter(writer);
                sw.WriteHeading("Title", 1);

                string[] delimiters = { Environment.NewLine, @"\n" };
                string[] lines = writer.ToString().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                Assert.AreEqual(2, lines.Length);
                Assert.AreEqual("Title", lines[0]);
                Assert.AreEqual("=====", lines[1]);

                lines = writer.ToString().Split(delimiters, StringSplitOptions.None);
                Assert.AreEqual(4, lines.Length);
                Assert.AreEqual("Title", lines[0]);
                Assert.AreEqual("=====", lines[1]);
                Assert.AreEqual(0, lines[2].Length);
                Assert.AreEqual(0, lines[3].Length);
            }
        }

        [TestMethod]
        public void Heading2ContainsCaptionUnderlinedWithDashesAndAnEmptyLine()
        {
            using (StringWriter writer = new StringWriter())
            {
                StoryWriter sw = new StoryWriter(writer);
                sw.WriteHeading("Title", 2);

                string[] delimiters = { Environment.NewLine, @"\n" };
                string[] lines = writer.ToString().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                Assert.AreEqual(2, lines.Length);
                Assert.AreEqual("Title", lines[0]);
                Assert.AreEqual("-----", lines[1]);

                lines = writer.ToString().Split(delimiters, StringSplitOptions.None);
                Assert.AreEqual(4, lines.Length);
                Assert.AreEqual("Title", lines[0]);
                Assert.AreEqual("-----", lines[1]);
                Assert.AreEqual(0, lines[2].Length);
                Assert.AreEqual(0, lines[3].Length);
            }
        }

        [TestMethod]
        public void ParagraphContainsTextAndEmptyLine()
        {
            using (StringWriter writer = new StringWriter())
            {
                StoryWriter sw = new StoryWriter(writer);
                sw.WriteParagraph("This is a paragraph");

                string[] delimiters = { Environment.NewLine, @"\n" };
                string[] lines = writer.ToString().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                Assert.AreEqual(1, lines.Length);
                Assert.AreEqual("This is a paragraph", lines[0]);

                lines = writer.ToString().Split(delimiters, StringSplitOptions.None);
                Assert.AreEqual(3, lines.Length);
                Assert.AreEqual("This is a paragraph", lines[0]);
                Assert.AreEqual(0, lines[1].Length);
                Assert.AreEqual(0, lines[2].Length);
            }
        }

        [TestMethod]
        public void HyperlinkContainsTextAndEmptyLine()
        {
            using (StringWriter writer = new StringWriter())
            {
                StoryWriter sw = new StoryWriter(writer);
                sw.WriteHyperlink("Caption", "link");

                string[] delimiters = { Environment.NewLine, @"\n" };
                string[] lines = writer.ToString().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                Assert.AreEqual(1, lines.Length);
                Assert.AreEqual("Caption [link]", lines[0]);
            }
        }
    }
}
