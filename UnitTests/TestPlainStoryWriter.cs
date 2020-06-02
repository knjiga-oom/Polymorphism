using System;
using System.Linq;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Polymorhism
{
    [TestClass]
    public class TestPlainStoryWriter
    {
    [TestMethod]
        public void HeadingContainsUnderlinedCaption()
        {
            using (StringWriter writer = new StringWriter())
            {
                StoryWriter sw = new StoryWriter(writer);
                sw.WriteHeading("Title");

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
    }
}
