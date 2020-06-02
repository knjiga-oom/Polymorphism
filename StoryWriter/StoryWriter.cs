using System.IO;

namespace Vsite.Oom.Polymorhism
{
    public class StoryWriter
    {
        public StoryWriter(TextWriter writer)
        {
            this.writer = writer;
        }

        public void WriteHeading(string text)
        {
            writer.WriteLine(text);
            writer.WriteLine(new string('=', text.Length));
            writer.WriteLine(); // append empty line
        }

        public void WriteParagraph(string text)
        {
            writer.WriteLine(text);
            writer.WriteLine(); // append empty line
        }

        public void WriteHyperlink(string caption, string link)
        {
            writer.WriteLine($"{caption} [{link}]");
        }

        private TextWriter writer;
    }
}
