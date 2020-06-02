namespace Vsite.Oom.Polymorhism
{
    public class Story
    {
        public Story(StoryWriter writer)
        {
            this.writer = writer;
        }

        public void AddHeading(string text, int level)
        {
            writer.WriteHeading(text, level);
        }

        public void AddParagraph(string text)
        {
            writer.WriteParagraph(text);
        }


        public void Hyperlink(string caption, string link)
        {
            writer.WriteHyperlink(caption, link);
        }

        private readonly StoryWriter writer;
    }
}
