using System.IO;

namespace Vsite.Oom.Polymorhism
{
    public class StoryWriter
    {
        public StoryWriter(TextWriter writer)
        {
            this.writer = writer;
        }

        private char GetHeadingUnderlineCharacter(int level)
        {
            switch (level)
            {
                case 1:
                    return '=';
                case 2:
                    return '-';
                case 3:
                    return '.';
                default:
                    return ' ';
            }
        }

        public void WriteHeading(string text, int level)
        {
            writer.WriteLine(text);
            writer.WriteLine(new string(GetHeadingUnderlineCharacter(level), text.Length));
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
