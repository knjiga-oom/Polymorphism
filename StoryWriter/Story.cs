namespace Vsite.Oom.Polymorhism
{
    public class Story
    {
        public Story(PlainTextFormatter formatter)
        {
            this.writer = formatter;
        }

        public void AddHeading(string text, int level)
        {
            writer.WriteHeading(text, level);
        }

        public void AddParagraphs(string[] text)
        {
            foreach (string paragraph in text)
                writer.WriteParagraph(paragraph);
        }

        public void Hyperlink(string caption, string link)
        {
            writer.WriteHyperlink(caption, link);
        }

        public override string ToString()
        {
            return writer.ToString();
        }

        private readonly PlainTextFormatter writer;
    }
}
