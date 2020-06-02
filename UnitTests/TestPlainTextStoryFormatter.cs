using System;
using System.Linq;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Oom.Polymorhism
{
    [TestClass]
    public class TestPlainTextStoryFormatter
    {
        [TestMethod]
        public void Heading1ContainsCaptionUnderlinedWithEqualsAndAnEmptyLine()
        {
            PlainTextFormatter tf = new PlainTextFormatter();
            tf.WriteHeading("Title", 1);

            string[] delimiters = { Environment.NewLine, @"\n" };
            string[] lines = tf.ToString().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, lines.Length);
            Assert.AreEqual("Title", lines[0]);
            Assert.AreEqual("=====", lines[1]);

            lines = tf.ToString().Split(delimiters, StringSplitOptions.None);
            Assert.AreEqual(4, lines.Length);
            Assert.AreEqual("Title", lines[0]);
            Assert.AreEqual("=====", lines[1]);
            Assert.AreEqual(0, lines[2].Length);
            Assert.AreEqual(0, lines[3].Length);
        }

        [TestMethod]
        public void Heading2ContainsCaptionUnderlinedWithDashesAndAnEmptyLine()
        {
            PlainTextFormatter tf = new PlainTextFormatter();
            tf.WriteHeading("Title", 2);

            string[] delimiters = { Environment.NewLine, @"\n" };
            string[] lines = tf.ToString().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, lines.Length);
            Assert.AreEqual("Title", lines[0]);
            Assert.AreEqual("-----", lines[1]);

            lines = tf.ToString().Split(delimiters, StringSplitOptions.None);
            Assert.AreEqual(4, lines.Length);
            Assert.AreEqual("Title", lines[0]);
            Assert.AreEqual("-----", lines[1]);
            Assert.AreEqual(0, lines[2].Length);
            Assert.AreEqual(0, lines[3].Length);
        }

        [TestMethod]
        public void ParagraphContainsTextAndEmptyLine()
        {
            PlainTextFormatter tf = new PlainTextFormatter();
            tf.WriteParagraph("This is a paragraph");

            string[] delimiters = { Environment.NewLine, @"\n" };
            string[] lines = tf.ToString().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(1, lines.Length);
            Assert.AreEqual("This is a paragraph", lines[0]);

            lines = tf.ToString().Split(delimiters, StringSplitOptions.None);
            Assert.AreEqual(3, lines.Length);
            Assert.AreEqual("This is a paragraph", lines[0]);
            Assert.AreEqual(0, lines[1].Length);
            Assert.AreEqual(0, lines[2].Length);
        }

        [TestMethod]
        public void HyperlinkContainsTextAndEmptyLine()
        {
            PlainTextFormatter tf = new PlainTextFormatter();
            tf.WriteHyperlink("Caption", "link");

            string[] delimiters = { Environment.NewLine, @"\n" };
            string[] lines = tf.ToString().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(1, lines.Length);
            Assert.AreEqual("Caption [link]", lines[0]);
        }
    }
}
